using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TERCER_PARCIAL_PROGRAAM;

using Microsoft.EntityFrameworkCore;
public class Context : DbContext
{
    public DbSet<NOTAS> NOTAS { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("DESKTOP-NFDMETJ\\SQLEXPRESS01;Database=Parcial3; Trusted_Connection = SSPI; MultipleActiveResultSets = true;");
    }
}