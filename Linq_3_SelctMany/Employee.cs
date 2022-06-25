using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_3_SelctMany
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public List<Techs> Technologies { get; set; }

    }

    public class Techs
    {
        public string TechName { get; set; }
    }
}
