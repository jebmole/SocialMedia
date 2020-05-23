using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SocialMediaContext _context;
        public UserRepository(SocialMediaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var posts = await _context.Users.ToListAsync();
            return posts;
        }

        public async Task<User> GetUser(int id)
        {
            var post = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
            return post;
        }
    }
}
