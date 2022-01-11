using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Baranova.class_models
{
    public  class Position //должность
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int zp { get; set; }
        public int OtdelyId { get; set; }
        public Otdely Otdely { get; set; }
    }

}
