using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_3_SelctMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> lst_std = new List<Student>
            {
                new Student{ Name ="manish",Address= "Knp",Id = 101,Subjects=new List<string>{ "c#","html","css"} },
                new Student{ Name ="sara",Address= "lko",Id = 102,Subjects=new List<string>{ "F#","html","css"} },
                new Student{ Name ="alok",Address= "delhi",Id = 103,Subjects=new List<string>{ "j#","spring","oracle"} },
                new Student{ Name ="ravi",Address= "jaipur",Id = 104,Subjects=new List<string>{ "mongo","node"} }

            };


            List<Employee> lst_emp = new List<Employee>
            {
                new Employee{ Name ="manish",Address= "Knp",Id = 101,Technologies=new List<Techs>{
                    new Techs { TechName="c#"},
                    new Techs { TechName="html"},
                    new Techs { TechName="css"},
                
                } },
                 new Employee{ Name ="sara",Address= "Lko",Id = 121,Technologies=new List<Techs>{
                    new Techs { TechName="j#"},
                    new Techs { TechName="oracle"},
                    new Techs { TechName="Entity"},

                } }

            };


            var rslt = lst_std.SelectMany(x => x.Subjects).ToList();

            var rsl_query = (from std in lst_std
                             from subjects in std.Subjects
                             select subjects).ToList();


            //using select many in Employee
            var rst_emp = lst_emp.SelectMany(e => e.Technologies).ToList();

            foreach (var item in rsl_query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------Emplyo Use----------");
            foreach (var item in rst_emp)
            {
                Console.WriteLine(item.TechName);
            }

            Console.ReadLine();
        }
    }
}
