using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Baranova.class_models
{
    public class User
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName  { get; set;  } 
        public int zp { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; } 

    }
}
