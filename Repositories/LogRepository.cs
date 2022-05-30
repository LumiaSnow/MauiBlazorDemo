using MauiApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Repositories
{
    public class LogRepository
    {
        private readonly MyDbContext _dbContext;
        public LogRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task LogDebugAsync(string func, string content)
        {
            await _dbContext.AddAsync(new Log
            {
                Level = 0,
                Func = func,
                Content = content
            });
            await _dbContext.SaveChangesAsync();
        }

        public void LogDebug(string func, string content)
        {
            _dbContext.Add(new Log
            {
                Level = 0,
                Func = func,
                Content = content
            });
            _dbContext.SaveChanges();
            Console.WriteLine($"{func} {content}");
        }

        public async Task<List<Log>> GetAsync()
        {
            return await _dbContext.Set<Log>().OrderByDescending(x => x.Id).ToListAsync();
        }

    }
}
