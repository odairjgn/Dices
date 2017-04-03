using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using DicesCore.Entidades;

namespace DicesCore.Contexto
{
    public class Repositorio<TEntity> where TEntity : Base
    {
        private DicesContext _context;

        public Repositorio(DicesContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().Select(row => row);
        }

        public IQueryable<TEntity> Get(params Expression<Func<TEntity, object>>[] path)
        {
            var ret = _context.Set<TEntity>().AsQueryable();

            return path.Aggregate(ret, (current, p) => current.Include(p));
        }

        public TEntity Get(int key)
        {
            return _context.Set<TEntity>().Find(key);
        }

        public IQueryable<TEntity> Query(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter);
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            TEntity existing = _context.Set<TEntity>().Find(entity.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                Update(entity);
            }
        }

        public void AddOrUpdate(TEntity entity)
        {
            TEntity existing = _context.Set<TEntity>().Find(entity.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(entity);
            }
            else
            {
                _context.Set<TEntity>().Add(entity);
            }

            _context.SaveChanges();
        }

        public void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                AddOrUpdate(entity);
            }
        }

        public DbSqlQuery<TEntity> Query(string query, params string[] parametros)
        {
            return _context.Set<TEntity>().SqlQuery(query, parametros);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        
    }
}
