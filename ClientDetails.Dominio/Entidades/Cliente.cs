using System;
using System.Collections.Generic;
using System.Text;

namespace ClientDetails.Dominio.Entidades
{
    public class Cliente : Entidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

        public string Segmento { get; set; }

        public string Cnpj { get; set; }

        public string CodSistema { get; set; }

        public string CodExterno { get; set; }
    }
}
