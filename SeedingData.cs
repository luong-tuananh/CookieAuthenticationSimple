using AuthenSimple.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenSimple
{
    public class SeedingData
    {
        private readonly AppDbContext _context;        

        public SeedingData(AppDbContext context)
        {
            _context = context;            
        }

        public async Task Seed()
        {
            if (!_context.Users.Any())
            {
                await _context.Users.AddAsync(new User { UserName = "John", Password = "123456", FullName = "Rico John" });
                await _context.SaveChangesAsync();                
            }       
        }
    }
}
