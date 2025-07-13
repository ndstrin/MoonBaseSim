using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonBaseSim
{
    internal class MoonBase
    {
        //Overall Class for Game Stats
        public int Level { get; set; } = 1;
        public string Name { get; set; } = string.Empty;
        public int EXP { get; set; } = 0;
        public int Next_Level_EXP { get; set; } = 300;
        public int Total_Workers { get; set; } = 10;
        public Resource Resources = new Resource();
        public CurrentWorker CurrentWorkers = new CurrentWorker();

        //Sub Class for Resources Units
        public class Resource 
        {
            public int Oxygen { get; set; } = 50;
            public int Food { get; set; } = 50;
            public int Water { get; set; } = 50;
            public int Ore { get; set; } = 25;
        }
        //Sub Class for Current Workers
        public class CurrentWorker 
        {
            public int Minners { get; set; } = 0;
            public int ProcessingWorkers { get; set; } = 0;
            public int Farmers { get; set; } = 0;
        }

        // Returns the Current Active Works Assigned Jobs in the Base
        public int ActiveWorkers() 
        {
            int Total = CurrentWorkers.Minners + CurrentWorkers.ProcessingWorkers + CurrentWorkers.Farmers;
            return Total;
        }
        // Returns the Current Free Works not Assigned to Jobs in the Base
        public int OpenWorkers() 
        {
            return Total_Workers - ActiveWorkers();
        }

    }

    
}
