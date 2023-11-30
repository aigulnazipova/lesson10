using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov11
{
    internal class Building
    {
        internal int buildingNumber;
        private double height;
        private int floors;
        private int apartments;
        private int entrances;

        private static int lastBuildingNumber = 0;

        public Building(double height, int floors, int apartments, int entrances)
        {
            buildingNumber = GenerateBuildingNumber();
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrances = entrances;
        }
        public Building()
        {
            buildingNumber = GenerateBuildingNumber();
        }
        private static int GenerateBuildingNumber()
        {
            lastBuildingNumber++;
            return lastBuildingNumber;
        }

        public int GetBuildingNumber()
        {
            return buildingNumber;
        }

        public double GetHeight()
        {
            return height;
        }

        public int GetFloors()
        {
            return floors;
        }

        public int GetApartments()
        {
            return apartments;
        }

        public int GetEntrances()
        {
            return entrances;
        }
        public double GetFloorHeight()
        {
            return height / floors;
        }

        public int GetApartmentsPerEntrance()
        {
            return apartments / entrances;
        }

        public int GetApartmentsPerFloor()
        {
            return apartments / floors;
        }
    }
}
