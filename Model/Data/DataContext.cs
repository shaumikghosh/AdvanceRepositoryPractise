using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;

namespace Models.Data;
public class DataContext : DbContext
{
    public DataContext (DbContextOptions<DataContext> options): base(options)
    {
    }

    public DbSet<Student> ? Students { get; set; }
}
