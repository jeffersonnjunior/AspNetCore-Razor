using Infrastructure.Interfaces.IPersistence.IRepositories;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Infrastructure.Persistence.Repositories;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;
    protected readonly ILogger<BaseRepository<T>> _logger;

    protected BaseRepository(AppDbContext context, ILogger<BaseRepository<T>> logger)
    {
        _context = context;
        _dbSet = context.Set<T>();
        _logger = logger;
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        _logger.LogInformation("GetByIdAsync chamado para {Entity} com Id {Id}", typeof(T).Name, id);
        try
        {
            return await _dbSet.FindAsync(id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro em GetByIdAsync para {Entity} com Id {Id}", typeof(T).Name, id);
            throw;
        }
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        _logger.LogInformation("GetAllAsync chamado para {Entity}", typeof(T).Name);
        try
        {
            return await _dbSet.ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro em GetAllAsync para {Entity}", typeof(T).Name);
            throw;
        }
    }

    public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        _logger.LogInformation("FindAsync chamado para {Entity}", typeof(T).Name);
        try
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro em FindAsync para {Entity}", typeof(T).Name);
            throw;
        }
    }

    public async Task AddAsync(T entity)
    {
        _logger.LogInformation("AddAsync chamado para {Entity}", typeof(T).Name);
        try
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro em AddAsync para {Entity}", typeof(T).Name);
            throw;
        }
    }

    public async Task UpdateAsync(T entity)
    {
        _logger.LogInformation("UpdateAsync chamado para {Entity}", typeof(T).Name);
        try
        {
            _dbSet.Update(entity);
            await Task.CompletedTask;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro em UpdateAsync para {Entity}", typeof(T).Name);
            throw;
        }
    }

    public async Task RemoveAsync(T entity)
    {
        _logger.LogInformation("RemoveAsync chamado para {Entity}", typeof(T).Name);
        try
        {
            _dbSet.Remove(entity);
            await Task.CompletedTask;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro em RemoveAsync para {Entity}", typeof(T).Name);
            throw;
        }
    }

    public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
    {
        _logger.LogInformation("ExistsAsync chamado para {Entity}", typeof(T).Name);
        try
        {
            return await _dbSet.AnyAsync(predicate);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro em ExistsAsync para {Entity}", typeof(T).Name);
            throw;
        }
    }
}