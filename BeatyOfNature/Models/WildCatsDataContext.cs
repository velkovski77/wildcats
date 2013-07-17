using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeatyOfNature.Models
{
    public class WildCatsDataContext : DbContext
    {
        public DbSet<WildCat> WildCats { get; set; }

        //static WildCatsDataContext()
        //{
        //    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WildCatsDataContext>());
        //}
    }
}