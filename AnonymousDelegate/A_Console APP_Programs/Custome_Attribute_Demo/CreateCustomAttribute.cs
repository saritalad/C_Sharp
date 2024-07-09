using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custome_Attribute_Demo
{
    [AttributeUsage(AttributeTargets.All)]

    //Creating custom attribute class inherited from System.Attribute
    public class CreateCustomAttribute:System.Attribute
    {
        //private fields
        private string DevloperName;
        private double VersionNumber;

        //parameterized constructor
        public CreateCustomAttribute(string DevloperName, double VersionNumber)
        {
            this.DevloperName = DevloperName;
            this.VersionNumber = VersionNumber;
        }

        public virtual string DevName
        {
            get
            {
                return DevloperName;
            }
        }

        public virtual double VerNum
        {
            get
            {
                return VersionNumber;
            }
        }
    }
}
