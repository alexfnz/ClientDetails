using ClientDetails.Dominio.Contratos;
using ClientDetails.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace ClientDetails.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly ClientDetailsContexto ClientDetailsContexto;

        public BaseRepositorio(ClientDetailsContexto clientDetailsContexto)
        {
            ClientDetailsContexto = clientDetailsContexto;
        }

        public void Adicionar(TEntity entity)
        {
            ClientDetailsContexto.Set<TEntity>().Add(entity);
            ClientDetailsContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            ClientDetailsContexto.Set<TEntity>().Update(entity);
            ClientDetailsContexto.SaveChanges();
        }

        public void Dispose()
        {
            ClientDetailsContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return ClientDetailsContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return ClientDetailsContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            ClientDetailsContexto.Remove(entity);
            ClientDetailsContexto.SaveChanges();
        }
    }
}
