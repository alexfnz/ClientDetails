using System;
using System.Collections.Generic;
using System.Text;

namespace ClientDetails.Dominio.Entidades
{
    public class Tarefa : Entidade
    {
        public int Id { get; set; }

        public int ContatoId { get; set; }

        public string TipoTarefa { get; set; }

        public DateTime DataExecucao { get; set; }

        public string Colaborador { get; set; }
    }
}
