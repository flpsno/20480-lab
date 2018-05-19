using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace API_JQuery.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Partida> Partida { get; set; }
    }
}