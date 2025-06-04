using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerVision1.Strutture
{
    public class PercentualeColori
    {
        public int VolumeCubo { get; } = 0; 
        public int R { get; set; } = 0;
        public int G { get; set; } = 0;
        public int B { get; set; } = 0;

        public double PercR => (double)R / (double)VolumeCubo;
        public double PercG => (double)G / (double)VolumeCubo;
        public double PercB => (double)B / (double)VolumeCubo;

        public PercentualeColori(Size dimensioni)
        {
            VolumeCubo = dimensioni.Width * dimensioni.Height * 255;
        }
    }
}
