﻿using System;
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
        public string Desc { get; set; }
        public string parts { get; set; }

        public string getMenu()
        {
            return Menu;
        }

        
        public override string ToString()
        {
            if (Menu.Equals("アブドミナルマシンクランチ（マシン）"))
            {
                return Menu + "　　　　　　　　　                                                   " + Load;
            }

            if (Menu.Length < 27)
            { 
                return String.Format("%27s", Menu) + "                                                   " + Load;
            }

            else
            {
                return Menu + "                                                   " + Load;
            }
        }
    }
}
