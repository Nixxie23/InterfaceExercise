using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public bool USABased { get; set; }
        public string CompanyName { get; set; }
    }
}

