using SocialMedia.Core.Entities;
using System;
using System.Threading.Tasks;

namespace SocialMedia.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Post> PostRepository { get; }

        IRepository<User> UserRepository { get; }

        IRepository<Comment> CommentRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
