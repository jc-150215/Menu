using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace Menu
{
    public class Training
    {
        [PrimaryKey]

        public string Menu { get; set; }
        public string Load { get; set; }
        public String parts { get; set; }

        public String getMenu()
        {
            return Menu;
        }

        public override string ToString()
        {
            return Menu + 
                "                                                                                負荷度：" 
                +Load;
        }

    }
}
