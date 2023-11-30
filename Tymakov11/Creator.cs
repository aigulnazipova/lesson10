using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov11
{
    internal class Creator
    {
        private static Dictionary<int, Building> buildingDictionary = new Dictionary<int, Building>();

        private Creator() { }

        public static Building CreateBuilding(int number)
        {
            Building building = new Building
            {
                buildingNumber = number
            };
            buildingDictionary.Add(number, building);
            return building;
        }

        public static Building CreateBuild(int buildingNumber)
        {
            return CreateBuild(buildingNumber);
        }

        public static void RemoveBuilding(int buildingNumber)
        {
            if (buildingDictionary.ContainsKey(buildingNumber))
            {
                buildingDictionary.Remove(buildingNumber);
            }
        }
    }
}
