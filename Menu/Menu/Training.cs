using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Training
    {

        public string Menu { get; set; }
        public string Load { get; set; }
        public string parts { get; set; }

        public string getMenu()
        {
            return Menu;
        }

        
        public override string ToString()
        {
            if (Menu.Length < 27)
            {
                var zero = "";
                for (var i = 0; i < Menu.Length - 27; i++)
                {
                    zero += zero;
                }
                return Menu + zero + "                                                   " + Load;

            }

            else
            {
                return Menu + "                                                   " + Load;
            }
        }
    }
}
