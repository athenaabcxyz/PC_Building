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
            status = MotherboardCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = ProcessorCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = RAMCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = PSUCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = StorageCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = GPUCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = CaseCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = CaseCoolerCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = CPUCoolerCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);

            status = SocketCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = MotherboardFormFactorCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = RamCheck();
            if (status.CompatibilityName != "")
                Incompatibilities.Add(status);
            status = MemorySpeedCheck();
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
        public CompatibilityStatus MotherboardCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (string.IsNullOrEmpty(motherboard.Model))
            {
                status.CompatibilityName = "Missing Motherboard";
                status.SeriousityLevel = "Serious";
                status.Detail = "There is no Motherboard in current build.";
                return status;
            }
            else
                return status;
        }
        public CompatibilityStatus ProcessorCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (string.IsNullOrEmpty(processor.Model))
            {
                status.CompatibilityName = "Missing Processor";
                status.SeriousityLevel = "Serious";
                status.Detail = "There is no Processor in current build.";
                return status;
            }
            else
                return status;
        }
        public CompatibilityStatus RAMCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (string.IsNullOrEmpty(ram.Model))
            {
                status.CompatibilityName = "Missing RAM";
                status.SeriousityLevel = "Serious";
                status.Detail = "There is no RAM in current build.";
                return status;
            }
            else
                return status;
        }
        public CompatibilityStatus PSUCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (string.IsNullOrEmpty(powerSupply.Model))
            {
                status.CompatibilityName = "Missing Power Supply Unit";
                status.SeriousityLevel = "Serious";
                status.Detail = "There is no PSU in current build.";
                return status;
            }
            else
                return status;
        }
        public CompatibilityStatus CaseCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (string.IsNullOrEmpty(cpuCase.Model))
            {
                status.CompatibilityName = "Missing Case";
                status.SeriousityLevel = "Unrecommended";
                status.Detail = "There is no Case in current build.";
                return status;
            }
            else
                return status;
        }
        public CompatibilityStatus GPUCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (string.IsNullOrEmpty(graphicCard.Model))
            {
                status.CompatibilityName = "Missing Graphic Card";
                status.SeriousityLevel = "Normal";
                status.Detail = "There is no Graphic Card in current build.";
                return status;
            }
            else
                return status;
        }
        public CompatibilityStatus CPUCoolerCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (string.IsNullOrEmpty(cpuCooler.Model))
            {
                status.CompatibilityName = "Missing CPU Cooler";
                status.SeriousityLevel = "Unrecommended";
                status.Detail = "There is no CPU Cooler in current build.";
                return status;
            }
            else
                return status;
        }
        public CompatibilityStatus CaseCoolerCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (string.IsNullOrEmpty(caseCooler.Model))
            {
                status.CompatibilityName = "Missing Case Cooler";
                status.SeriousityLevel = "Normal";
                status.Detail = "There is no Case Cooler in current build.";
                return status;
            }
            else
                return status;
        }
        public CompatibilityStatus StorageCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (string.IsNullOrEmpty(storage.Model))
            {
                status.CompatibilityName = "Missing Storage Unit";
                status.SeriousityLevel = "Serious";
                status.Detail = "There is no Storage Unit in current build.";
                return status;
            }
            else
                return status;
        }
        public string CompatibilityLog()
        {
            CompatibilityCheck();
            string DetailLog = "";
            if (Incompatibilities.Count > 0)
            {
                for (int i = 0; i < Incompatibilities.Count; i++)
                {
                    DetailLog += "--------------------------------------------------------\n"
                        + "Incompatibility name: " + Incompatibilities[i].CompatibilityName + "\n\n"
                        + "Serious level: " + Incompatibilities[i].SeriousityLevel + "\n\n"
                        + "Detail problem: " + Incompatibilities[i].Detail + "\n\n";
                }
                DetailLog += "--------------------------------------------------------\n";
            }
            if (DetailLog != "")
                return DetailLog;
            else
                return "Your build is perfect!";
        }
        public CompatibilityStatus SocketCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (!string.IsNullOrEmpty(processor.Model) && !string.IsNullOrEmpty(motherboard.Model))
            {
                if (processor.SockerType != motherboard.SockerType)
                {
                    status.CompatibilityName = "Motherboard and Processor socket type unmatch";
                    status.SeriousityLevel = "Serious";
                    status.Detail = "The socket type of current Motherboard and Processor doesn't match.\n- Current Motherboard socket type: "
                        + motherboard.SockerType + "\n- Current Processor socket type: " + processor.SockerType;
                    return status;
                }
            }
            return status;

        }
        public CompatibilityStatus MemorySpeedCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (!string.IsNullOrEmpty(ram.Model) && !string.IsNullOrEmpty(motherboard.Model))
            {
                if (ram.RAMSpeed > motherboard.MemorySpeed)
                {
                    status.CompatibilityName = "The supported memory speed of Motherboard is lower than RAM speed";
                    status.SeriousityLevel = "Unrecommended";
                    status.Detail = "The memory speed of Motherboard lower than RAM speed will cause the ram to be downclocked.\n- Current Motherboard memory speed: "
                        + motherboard.MemorySpeed + "\n- Current RAM speed: " + ram.RAMSpeed;
                    return status;
                }
            }
            return status;

        }
        public CompatibilityStatus MotherboardFormFactorCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (!string.IsNullOrEmpty(cpuCase.Model) && !string.IsNullOrEmpty(motherboard.Model))
            {
                string[] motherboardsize = cpuCase.MotherboardSupport.Split(", ");
                bool match = false;
                for (int i = 0; i < motherboardsize.Length; i++)
                    if (motherboardsize[i] == motherboard.FormFactor)
                        match = true;
                if (!match)
                {
                    status.CompatibilityName = "Motherboard form factor is not supported";
                    status.SeriousityLevel = "Serious";
                    status.Detail = "The current PC case doesn't support current Motherboard form factor.\n- Current Motherboard form factor: "
                        + motherboard.FormFactor + "\n- Current PC case supported form factor: " + cpuCase.MotherboardSupport;
                }
            }
            return status;
        }
        public CompatibilityStatus RamCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (!string.IsNullOrEmpty(ram.Model) && !string.IsNullOrEmpty(motherboard.Model))
            {
                if (motherboard.MemoryType != ram.RAMType)
                {
                    status.CompatibilityName = "Motherboard and RAM memory type unmatch";
                    status.SeriousityLevel = "Serious";
                    status.Detail = "The memory type of current Motherboard and RAM doesn't match.\n- Current Motherboard memory type: "
                        + motherboard.MemoryType + "\n- Current RAM memory type: " + ram.RAMType;

                }
            }
            return status;
        }
        public CompatibilityStatus DriveCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (!string.IsNullOrEmpty(storage.Model) && !string.IsNullOrEmpty(motherboard.Model))
            {
                string[] drive = motherboard.StorageExpansion.Split(", ");
                bool match = false;
                for (int i = 0; i < drive.Length; i++)
                    if (drive[i] == storage.Interface)
                        match = true;
                if (!match)
                {
                    status.CompatibilityName = "Storage driver interface is not supported";
                    status.SeriousityLevel = "Serious";
                    status.Detail = "The current Motherboard doesn't support current Storage driver interface.\n- Current Storage driver interface: "
                        + storage.Interface + "\n- Current Motherboard supported interface: " + motherboard.StorageExpansion;
                }
            }
            return status;
        }
        public CompatibilityStatus GPULengthCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            if (!string.IsNullOrEmpty(cpuCase.Model) && !string.IsNullOrEmpty(graphicCard.Model))
            {
                if (cpuCase.MAXGPULength < graphicCard.Length)
                {
                    status.CompatibilityName = "The size of Graphic Card is not supported";
                    status.SeriousityLevel = "Serious";
                    status.Detail = "The size of Graphic Card doesn't fit the PC case.\n- Current Graphic Card length: "
                        + graphicCard.Length + "\n- PC case  max GPU length: " + cpuCase.MAXGPULength;

                }
            }
            return status;
        }
        public CompatibilityStatus PSUSCheck()
        {
            CompatibilityStatus status = new CompatibilityStatus();
            int length = powerSupply.Power.IndexOf(" W");
            if (!string.IsNullOrEmpty(processor.Model) && !string.IsNullOrEmpty(powerSupply.Model)&&!string.IsNullOrEmpty(graphicCard.Model))
            {
                double minumumPower = processor.MaxPowerConsumption + graphicCard.MaxPowerConsumption + 50;
                if (double.Parse(powerSupply.Power.Substring(0, length), CultureInfo.InvariantCulture) < minumumPower)
                {
                    status.CompatibilityName = "The power supply may be not enough";
                    status.SeriousityLevel = "Unrecommended";
                    status.Detail = "The current Power Supply unit may not provide enough power.\n- Current power supply: "
                        + powerSupply.Power + "\n- Recommend minimum power : " + minumumPower;

                }
            }
            return status;
        }
    }
}
