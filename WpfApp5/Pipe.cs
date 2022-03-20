using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Pipe
    {
        public int PipeId { get; set; }
        public string Quality { get; set; } = "годная";
        public string SteelGrade { get; set; }
        // Внутренний диаметр
        public double DN { get; set; } = 0;
        // Внешний диаметр
        public double DH { get; set; } = 0;
        public double S { get; set; } = 0;
        public double Weight { get; set; } = 0;

        //public int? PackageId { get; set; }
        //public virtual Package Package { get; set; }
    }
}
