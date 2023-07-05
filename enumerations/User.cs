using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerations
{
    internal class User
    {
        public string name { get; set; }
        Gender gender { get; set; }
        CarType carType { get; set; }

        public User(string name, int id, Gender gender, CarType carType)
        {
            this.name = name;
            this.gender = gender;
            this.carType = carType;
        }
    }

        enum Gender
        {
            MALE,
            FEMALE,
            OTHER
        }
        enum CarType
        {
            BASIC,
            PREMIUM,
            VAN
        }
    }
