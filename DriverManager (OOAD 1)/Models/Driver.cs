using DriverManager__OOAD_1_.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverManager__OOAD_1_
{
    public class Driver
    {
        private string name;
        private List<LicenseType> requiredLicenses;
        public bool isBusy;

        public Driver(string name, List<LicenseType> requiredLicenses)
        {
            Name = name;
            RequiredLicenses = requiredLicenses;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<LicenseType> RequiredLicenses
        {
            get { return requiredLicenses; }
            set { requiredLicenses = value; }
        }
        public void Drive(Location location)
        {
            //Логика метода Drive
        }
    }
}
