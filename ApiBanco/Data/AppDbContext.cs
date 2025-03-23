using ApiInova.ApiService.Models;
using ApiInova.ApiService.Models.Models2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace ApiBanco.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //tabelas a serem criadas(meio campo com db)
        public DbSet<ContaModel> Contas { get; set; }

        public DbSet<TransacaoModel> Transacoes { get; set; }
    }
}
