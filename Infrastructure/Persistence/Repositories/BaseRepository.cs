using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class BaseRepository : IBaseRepository
{
    private readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }

    public T Add<T>(T entity) where T : class
    {
        _context.Set<T>().Add(entity);
        return entity;
    }

    public void Delete<T>(T entity) where T : class
    {
        _context.Set<T>().Remove(entity);
    }

    public T? Find<T>(Guid id) where T : class
    {
        return _context.Set<T>().Find(id);
    }

    public IQueryable<T> Query<T>() where T : class
    {
        return _context.Set<T>().AsQueryable();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }

    public void Update<T>(T entity) where T : class
    {
        _context.Set<T>().Update(entity);
    }
}