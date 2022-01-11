using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Baranova.class_models
{
    public class AppDb: DbContext
        {
            public DbSet<User> Users { get; set; }
            public DbSet<Otdely> Otdelies { get; set; }
            public DbSet<Position> Positions { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("User ID=postgres;Password=senale127;Server=localhost;Port=5432;Database=Kalen_datab;Search Path=public; Integrated Security=true;Pooling=true;");
            }
        }
    
}
