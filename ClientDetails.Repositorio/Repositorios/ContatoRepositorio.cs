using ClientDetails.Dominio.Contratos;
using ClientDetails.Dominio.Entidades;
using ClientDetails.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientDetails.Repositorio.Repositorios
{
    public class ContatoRepositorio : BaseRepositorio<Contato>, IContatoRepositorio
    {
        public ContatoRepositorio(ClientDetailsContexto clientDetailsContexto) : base(clientDetailsContexto)
        {
        }
    }
}
