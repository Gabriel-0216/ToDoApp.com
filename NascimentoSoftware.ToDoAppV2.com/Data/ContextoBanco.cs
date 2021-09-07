using Microsoft.EntityFrameworkCore;
using NascimentoSoftware.ToDoAppV2.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NascimentoSoftware.ToDoAppV2.com.Data
{
    public class ContextoBanco : DbContext
    {
        public ContextoBanco(DbContextOptions<ContextoBanco> options) : base(options)
        {
            
        }

        public DbSet<Tarefa> Tarefa { get; set; } 
    }
}
