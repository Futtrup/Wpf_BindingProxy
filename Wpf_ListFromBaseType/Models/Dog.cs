using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_ListFromBaseType.Models
{
    public class Dog : Animal
    {
        public string DogType { get; set; }

        public Dog(string name, string dogType)
        {
            Name = name;
            DogType = dogType;
        }
    }
}
