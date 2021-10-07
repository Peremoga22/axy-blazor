using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using web.EF.Models;
using web.Extension;

namespace web.EF
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
            if (!string.IsNullOrEmpty(Database.GetDbConnection().ConnectionString))
            {
                ConnectionString.Value = Database.GetDbConnection().ConnectionString;
            }
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
    }
}
