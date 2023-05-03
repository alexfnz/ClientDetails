using System;
using System.Collections.Generic;
using System.Text;

namespace ClientDetails.Dominio.Entidades
{
    public class Contato : Entidade
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public string Nome { get; set; }

        public string Cargo { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public ICollection<Tarefa> Tarefas { get; set; }
    }
}
