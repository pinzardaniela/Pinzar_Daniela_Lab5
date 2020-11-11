using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pinzar_Daniela_Lab5.Models;

namespace Pinzar_Daniela_Lab5.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) 
        : base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }

        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }

        public DbSet<Budget> Budget { get; set; }


    }
}
