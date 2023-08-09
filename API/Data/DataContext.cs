using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class DataContext : DbContext
    {
        
        //contructor
        public DataContext(DbContextOptions options) : base(options){
        }

        public DbSet<AppUser> Users { get; set;}
    }
}