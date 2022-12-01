using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Building
{
    public class Building_Simulator
    {
        public Processor processor = new Processor();
        public Motherboard motherboard = new Motherboard();
        public CPU_Cooler cpuCooler = new CPU_Cooler();
        public Case cpuCase = new Case();
        public Graphic_Card graphicCard = new Graphic_Card();
        public RAM ram = new RAM();
        public Storage storage = new Storage();
        public Case_Cooler caseCooler = new Case_Cooler();
        public Power_Supply powerSupply = new Power_Supply();
        public List<CompatibilityStatus> Incompatibilities = new List<CompatibilityStatus>();
        public void addProcessor(string name)
        {
            processor.LoadProduct(name);
        }
        public void addMotherboard(string name)
        {
            motherboard.LoadProduct(name);
        }
        public void addCPUCooler(string name)
        {
            cpuCooler.LoadProduct(name);    
        }
        public void addCase(string name)
        {
            cpuCase.LoadProduct(name);
        }
        public void addGraphicCard(string name)
        {
            graphicCard.LoadProduct(name);
        }
        public void addRAM(string name)
        {
            ram.LoadProduct(name);
        }
        public void addStorage(string name)
        {
            storage.LoadProduct(name);
        }
        public void addPSU(string name)
        {
            powerSupply.LoadProduct(name);
        }
        public void addCaseCooler(string name)
        {
            caseCooler.LoadProduct(name);
        }
        public void CompatibilityCheck()
        {            
            Incompatibilities.Clear();
            CompatibilityStatus status = new CompatibilityStatus();
            status = SocketCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = MotherboardFormFactorCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = RamCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = DriveCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = GPULengthCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = PSUSCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
        }
        public string CompatibilityLog()
        {
            CompatibilityCheck();
            string DetailLog = "";
            if (Incompatibilities.Count > 0)
            {
                for (int i = 0; i < Incompatibilities.Count; i++)
                {
                    DetailLog += "---------------------------------------------------\n"
                        + "Incompatibility name: " + Incompatibilities[i].CompatibilityName + "\n"
                        + "Serious level: " + Incompatibilities[i].SeriousityLevel + "\n"
                        + "Detail problem: " + Incompatibilities[i].Detail + "\n";
                }
                DetailLog += "---------------------------------------------------\n";
            }
            if (DetailLog != "")
                return DetailLog;
            else
                return "Your build is perfect!";
        }
        public CompatibilityStatus SocketCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (processor.SockerType != motherboard.SockerType)
            {
                status.CompatibilityName = "Motherboard and Processor socket type unmatch";
                status.SeriousityLevel = "Serious";
                status.Detail = "The socket type of current Motherboard and Processor doesn't match.\n- Current Motherboard socket type: "
                    + motherboard.SockerType + "\n- Current Processor socket type: " + processor.SockerType;
                return status;
            }
            else
                return status;
        }
        public CompatibilityStatus MotherboardFormFactorCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            string[] motherboardsize = cpuCase.MotherboardSupport.Split(", ");
            bool match = false;
            for (int i = 0; i < motherboardsize.Length; i++)
                if (motherboardsize[i] == motherboard.FormFactor)
                    match = true;
            if (match)
            {
                status.CompatibilityName = "Motherboard form factor is not supported";
                status.SeriousityLevel = "Serious";
                status.Detail = "The current PC case doesn't support current Motherboard form factor.\n- Current Motherboard form factor: "
                    + motherboard.FormFactor + "\n- Current PC case supported form factor: " + cpuCase.MotherboardSupport;
            }
            return status;
        }
        public CompatibilityStatus RamCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (motherboard.MemoryType != ram.RAMType)
            {
                status.CompatibilityName = "Motherboard and RAM memory type unmatch";
                status.SeriousityLevel = "Serious";
                status.Detail = "The memory type of current Motherboard and RAM doesn't match.\n- Current Motherboard memory type: "
                    + motherboard.MemoryType + "\n- Current RAM memory type: " + ram.RAMType;
                
            }
            return status;
        }
        public CompatibilityStatus DriveCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            string[] drive = motherboard.StorageExpansion.Split(", ");
            bool match = false;
            for (int i = 0; i < drive.Length; i++)
                if (drive[i] == motherboard.StorageExpansion)
                    match = true;
            if (match)
            {
                status.CompatibilityName = "Storage driver interface is not supported";
                status.SeriousityLevel = "Serious";
                status.Detail = "The current Motherboard doesn't support current Storage driver interface.\n- Current Storage driver interface: "
                    + storage.Interface + "\n- Current Motherboard supported interface: " + motherboard.StorageExpansion;
            }
            return status;
        }
        public CompatibilityStatus GPULengthCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (cpuCase.MAXGPULength<graphicCard.Length)
            {
                status.CompatibilityName = "The size of Graphic Card is not supported";
                status.SeriousityLevel = "Serious";
                status.Detail = "The size of Graphic Card doesn't fit the PC case.\n- Current Graphic Card length: "
                    + graphicCard.Length + "\n- PC case  max GPU length: " + cpuCase.MAXGPULength;

            }
            return status;
        }
        public CompatibilityStatus PSUSCheck()
        {
            int length = powerSupply.Power.IndexOf(" W");
            CompatibilityStatus status = new CompatibilityStatus();
            double minumumPower = processor.MaxPowerConsumption + graphicCard.MaxPowerConsumption+50;
            if (double.Parse(powerSupply.Power.Substring(0, length),CultureInfo.InvariantCulture) <minumumPower)
            {
                status.CompatibilityName = "The power supply may be not enough";
                status.SeriousityLevel = "Unrecommended";
                status.Detail = "The current Power Supply unit may not provide enough power.\n- Current power supply: "
                    + powerSupply.Power + "\n- Recommend minimum power : " + minumumPower;

            }
            return status;
        }
    }
}
