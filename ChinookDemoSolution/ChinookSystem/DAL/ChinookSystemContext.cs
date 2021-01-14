using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using ChinookSystem.Entities;
using System.Data.Entity;
#endregion

namespace ChinookSystem.DAL
{
    //connect this class to EntityFramework by inheriting DbContext
    internal class ChinookSystemContext: DbContext
    {
        
        //constructor that 
        //passes the connection string name to EntityFramework 
        //via the inherited class DbContext
        public ChinookSystemContext() : base("name = ChinookDB")
        { 

        }

        //properties to interact with EntityFramework
        //these properties represent the whole table and all data
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}
