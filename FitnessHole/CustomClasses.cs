using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessHole
{
    public partial class Role
    {
        public override string ToString()
        {
            return Role1;
        }
    }
    public partial class Employee
    {
        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
    public partial class Service
    {
        public override string ToString()
        {
            return ServiceName;
        }
    }
    public partial class Package
    {
        public override string ToString()
        {
            return Name;
        }
    }
    public partial class Customer
    {
        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }
    }
}
