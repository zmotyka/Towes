using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Towes.Repository
{
    //public interface IRepository<T> where T : class
    //{
    //    /// <summary>
    //    ///   Get the total objects count.
    //    /// </summary>
    //    int Count { get; }

    //    /// <summary>
    //    ///   Gets all objects from database
    //    /// </summary>
    //    IQueryable<T> All();

    //    /// <summary>
    //    ///   Gets object by primary key.
    //    /// </summary>
    //    /// <param name="id"> primary key </param>
    //    /// <returns> </returns>
    //    T GetById(object id);

    //    /// <summary>
    //    ///   Gets objects via optional filter, sort order, and includes
    //    /// </summary>
    //    /// <param name="filter"> </param>
    //    /// <param name="orderBy"> </param>
    //    /// <param name="includeProperties"> </param>
    //    /// <returns> </returns>
    //    IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

    //    /// <summary>
    //    ///   Gets objects from database by filter.
    //    /// </summary>
    //    /// <param name="predicate"> Specified a filter </param>
    //    IQueryable<T> Filter(Expression<Func<T, bool>> predicate);

    //    /// <summary>
    //    ///   Gets objects from database with filting and paging.
    //    /// </summary>
    //    /// <param name="filter"> Specified a filter </param>
    //    /// <param name="total"> Returns the total records count of the filter. </param>
    //    /// <param name="index"> Specified the page index. </param>
    //    /// <param name="size"> Specified the page size </param>
    //    IQueryable<T> Filter(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50);

    //    /// <summary>
    //    ///   Gets the object(s) is exists in database by specified filter.
    //    /// </summary>
    //    /// <param name="predicate"> Specified the filter expression </param>
    //    bool Contains(Expression<Func<T, bool>> predicate);

    //    /// <summary>
    //    ///   Find object by keys.
    //    /// </summary>
    //    /// <param name="keys"> Specified the search keys. </param>
    //    T Find(params object[] keys);

    //    /// <summary>
    //    ///   Find object by specified expression.
    //    /// </summary>
    //    /// <param name="predicate"> </param>
    //    T Find(Expression<Func<T, bool>> predicate);

    //    /// <summary>
    //    ///   Create a new object to database.
    //    /// </summary>
    //    /// <param name="entity"> Specified a new object to create. </param>
    //    T Create(T entity);

    //    /// <summary>
    //    ///   Deletes the object by primary key
    //    /// </summary>
    //    /// <param name="id"> </param>
    //    void Delete(object id);

    //    /// <summary>
    //    ///   Delete the object from database.
    //    /// </summary>
    //    /// <param name="entity"> Specified a existing object to delete. </param>
    //    void Delete(T entity);

    //    /// <summary>
    //    ///   Delete objects from database by specified filter expression.
    //    /// </summary>
    //    /// <param name="predicate"> </param>
    //    void Delete(Expression<Func<T, bool>> predicate);

    //    /// <summary>
    //    ///   Update object changes and save to database.
    //    /// </summary>
    //    /// <param name="entity"> Specified the object to save. </param>
    //    void Update(T entity);
    //}

    //public class Repository<T> : IRepository<T> where T : class
    //{
    //    protected readonly DbContext _dbContext;
    //    protected readonly DbSet<T> _dbSet;

    //    public Repository(DbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //        _dbSet = _dbContext.Set<T>();
    //    }

    //    public virtual int Count
    //    {
    //        get { return _dbSet.Count(); }
    //    }

    //    public virtual IQueryable<T> All()
    //    {
    //        return _dbSet.AsQueryable();
    //    }

    //    public virtual T GetById(object id)
    //    {
    //        return _dbSet.Find(id);
    //    }

    //    public virtual IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
    //    {
    //        IQueryable<T> query = _dbSet;

    //        if (filter != null)
    //        {
    //            query = query.Where(filter);
    //        }

    //        if (!String.IsNullOrWhiteSpace(includeProperties))
    //        {
    //            foreach (var includeProperty in includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
    //            {
    //                query = query.Include(includeProperty);
    //            }
    //        }

    //        if (orderBy != null)
    //        {
    //            return orderBy(query).AsQueryable();
    //        }
    //        else
    //        {
    //            return query.AsQueryable();
    //        }
    //    }

    //    public virtual IQueryable<T> Filter(Expression<Func<T, bool>> predicate)
    //    {
    //        return _dbSet.Where(predicate).AsQueryable();
    //    }

    //    public virtual IQueryable<T> Filter(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50)
    //    {
    //        int skipCount = index * size;
    //        var resetSet = filter != null ? _dbSet.Where(filter).AsQueryable() : _dbSet.AsQueryable();
    //        resetSet = skipCount == 0 ? resetSet.Take(size) : resetSet.Skip(skipCount).Take(size);
    //        total = resetSet.Count();
    //        return resetSet.AsQueryable();
    //    }

    //    public bool Contains(Expression<Func<T, bool>> predicate)
    //    {
    //        return _dbSet.Count(predicate) > 0;
    //    }

    //    public virtual T Find(params object[] keys)
    //    {
    //        return _dbSet.Find(keys);
    //    }

    //    public virtual T Find(Expression<Func<T, bool>> predicate)
    //    {
    //        return _dbSet.FirstOrDefault(predicate);
    //    }

    //    public virtual T Create(T entity)
    //    {
    //        var newEntry = _dbSet.Add(entity);
    //        return newEntry;
    //    }

    //    public virtual void Delete(object id)
    //    {
    //        var entityToDelete = _dbSet.Find(id);
    //        Delete(entityToDelete);
    //    }

    //    public virtual void Delete(T entity)
    //    {
    //        if (_dbContext.Entry(entity).State == EntityState.Detached)
    //        {
    //            _dbSet.Attach(entity);
    //        }
    //        _dbSet.Remove(entity);
    //    }

    //    public virtual void Delete(Expression<Func<T, bool>> predicate)
    //    {
    //        var entitiesToDelete = Filter(predicate);
    //        foreach (var entity in entitiesToDelete)
    //        {
    //            if (_dbContext.Entry(entity).State == EntityState.Detached)
    //            {
    //                _dbSet.Attach(entity);
    //            }
    //            _dbSet.Remove(entity);
    //        }
    //    }

    //    public virtual void Update(T entity)
    //    {
    //        var entry = _dbContext.Entry(entity);
    //        _dbSet.Attach(entity);
    //        entry.State = EntityState.Modified;
    //    }
    //}

    public class RepositoryBase<TObject>
        where TObject : class
    {
        protected DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public ICollection<TObject> GetAll()
        {
            return _context.Set<TObject>().ToList();
        }

        public async Task<ICollection<TObject>> GetAllAsync()
        {
            return await _context.Set<TObject>().ToListAsync();
        }

        public TObject Get(int id)
        {
            return _context.Set<TObject>().Find(id);
        }

        public async Task<TObject> GetAsync(int id)
        {
            return await _context.Set<TObject>().FindAsync(id);
        }

        public TObject Find(Expression<Func<TObject, bool>> match)
        {
            return _context.Set<TObject>().SingleOrDefault(match);
        }

        public async Task<TObject> FindAsync(Expression<Func<TObject, bool>> match)
        {
            return await _context.Set<TObject>().SingleOrDefaultAsync(match);
        }

        public ICollection<TObject> FindAll(Expression<Func<TObject, bool>> match)
        {
            return _context.Set<TObject>().Where(match).ToList();
        }

        public async Task<ICollection<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match)
        {
            return await _context.Set<TObject>().Where(match).ToListAsync();
        }

        public TObject Add(TObject t)
        {
            _context.Set<TObject>().Add(t);
            _context.SaveChanges();
            return t;
        }

        public async Task<TObject> AddAsync(TObject t)
        {
            _context.Set<TObject>().Add(t);
            await _context.SaveChangesAsync();
            return t;
        }

        public TObject Update(TObject updated, int key)
        {
            if (updated == null)
                return null;

            TObject existing = _context.Set<TObject>().Find(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                _context.SaveChanges();
            }
            return existing;
        }

        public async Task<TObject> UpdateAsync(TObject updated, int key)
        {
            if (updated == null)
                return null;

            TObject existing = await _context.Set<TObject>().FindAsync(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                await _context.SaveChangesAsync();
            }
            return existing;
        }

        public void Delete(TObject t)
        {
            _context.Set<TObject>().Remove(t);
            _context.SaveChanges();
        }

        public async Task<int> DeleteAsync(TObject t)
        {
            _context.Set<TObject>().Remove(t);
            return await _context.SaveChangesAsync();
        }

        public int Count()
        {
            return _context.Set<TObject>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Set<TObject>().CountAsync();
        }
    }
}
