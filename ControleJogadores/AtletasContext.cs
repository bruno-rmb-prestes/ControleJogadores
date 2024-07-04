using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControleJogadores
{
    public class AtletasContext : DbContext
    {
        public AtletasContext() : base("name=AtletasContext")
        {
        }

        public DbSet<Atleta> Atletas { get; set; }
    }
}