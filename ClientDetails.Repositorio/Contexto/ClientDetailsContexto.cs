using ClientDetails.Dominio.Entidades;
using ClientDetails.Repositorio.Config;
using Microsoft.EntityFrameworkCore;

namespace ClientDetails.Repositorio.Contexto
{
    public class ClientDetailsContexto : DbContext
    {
        public DbSet<Contato> Contatos {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Tarefa> Tarefas { get; set; }

        public ClientDetailsContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new TarefaConfiguration());

            //tabela contato
            modelBuilder.Entity<Contato>().HasData(new Contato() { Id = 1, Cargo = "Dev", Email = "contatodev@teste.com", Nome = "Eliana", Telefone = "6299999-9999"});
            modelBuilder.Entity<Contato>().HasData(new Contato() { Id = 2, Cargo = "RH", Email = "contatorh@teste.com", Nome = "Roberto", Telefone = "6299999-9999" });
            modelBuilder.Entity<Contato>().HasData(new Contato() { Id = 3, Cargo = "Suporte", Email = "contatosup@teste.com", Nome = "Alan", Telefone = "6299999-9999" });

            //tabela cliente
            modelBuilder.Entity<Cliente>().HasData(new Cliente() { Id = 1,  Nome = "FNZ Inc", Telefone = "6295555-5555", Email = "cliente@teste.com", 
                Endereco = "Rua dotnet, 2220", Segmento = "TI", Cnpj = "98.654.321/0009-88", CodExterno = "321", CodSistema = "4567"});

            //tabela tarefa
            modelBuilder.Entity<Tarefa>().HasData(new Tarefa() { Id = 1, Colaborador = "Roberto", DataExecucao = System.DateTime.Now, TipoTarefa = "Corretiva" });
            modelBuilder.Entity<Tarefa>().HasData(new Tarefa() { Id = 2, Colaborador = "Eliana", DataExecucao = System.DateTime.Now, TipoTarefa = "Preventiva" });

            base.OnModelCreating(modelBuilder);
        }
    }
}