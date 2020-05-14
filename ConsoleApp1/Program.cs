using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Phone {
        public int number { get; set; }
    }

    class Program
    {
        public string Name { get; set; }
        public string Surname { get; set; }
       
        static void Main(string[] args)
        {
            List<Program> programs = new List<Program>()
            {
                new Program(){Name = "stas", Surname = "Pidoras" },
                new Program(){Name = "dat", Surname = "boi" },
                new Program(){Name = "max", Surname = "cry" }

            };
            List<Phone> phones = new List<Phone>()
            {
                new Phone(){number = 812838912},
                new Phone(){number = 813821123}

            };
            var nani = from r in programs
                      from t in phones
                      orderby r.Surname
                      select new
                      {
                          Surname = r.Surname,
                          Numbers = t.number
                      };
           foreach(var kuk in nani)
            {
                Console.WriteLine($"{kuk.Surname} {kuk.Numbers}");
            }
            Console.WriteLine();
            //var rorg = from r in programs let nan = "Mr. " + r.Name  where r.Name == "stas" select nan;
            //var rorg = programs.Where(u => u.Name == "stas");
            var rorg = from r in programs
                       let nan = "Mr. " + r.Name
                       where r.Name == "stas"
                       select new
                       {
                          Name = nan,
                          Surname = r.Surname
                       };
            foreach (var rirg in rorg)
                Console.WriteLine($"{rirg.Name} {rirg.Surname}");

            string[] str = { "ras", "Rsa", "saas" };
            int[] unt = { 1, 2, 3, 4, 54, 5 };

            var rar = unt.Where(t => t % 2 == 0);
            foreach(var dat in rar)
                Console.WriteLine(dat);
           
        }

       
    }
}
