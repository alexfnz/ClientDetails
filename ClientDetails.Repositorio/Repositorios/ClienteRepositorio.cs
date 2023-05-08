using ClientDetails.Dominio.Contratos;
using ClientDetails.Dominio.Entidades;
using ClientDetails.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientDetails.Repositorio.Repositorios
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(ClientDetailsContexto clientDetailsContexto) : base(clientDetailsContexto)
        {
        }
    }
}
