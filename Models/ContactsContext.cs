using Microsoft.EntityFrameworkCore;

namespace  ApiSQLVin.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet <COntacts> ContactSet {get ; set;}
    }
}