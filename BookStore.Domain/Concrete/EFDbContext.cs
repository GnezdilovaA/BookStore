using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Concrete;
using System.Data.Entity;
using BookStore.Domain.Entities;

namespace BookStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet <Book> Books { get; set; }
    }
}
