using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevPlaceApiTEST.Models;

namespace DevPlaceApiTEST.Data
{
    public class DevPlaceAPIContext : DbContext
    {
        
        public DevPlaceAPIContext(DbContextOptions<DevPlaceAPIContext> options)
            : base(options)
        {

        }
        
        public DbSet<DevPlaceApiTEST.Models.Personaje> Personaje { get; set; }

        

    }
}
