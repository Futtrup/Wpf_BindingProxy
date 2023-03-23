using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_ListFromBaseType.Models
{
    public class Cat : Animal
    {
        public string CatType { get; set; }

        public Cat(string name, string catType)
        {
            Name = name;
            CatType = catType;
        }
    }
}
