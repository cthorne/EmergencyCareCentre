using EmergencyCareCentre.Data;
using EmergencyCareCentre.Models;
using EmergencyCareCentre.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Repositories
{
    public class CommentRepository : ICommentRepository, IDisposable
    {
        private bool disposedValue = false; 
        private ApplicationDbContext _dbContext;

        public CommentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteComment(int commentId)
        {
            CommentModel comment = _dbContext.Comments.Find(commentId);
            _dbContext.Comments.Remove(comment);
        }

        public CommentModel GetCommentById(int commentId)
        {
            return _dbContext.Comments.Find(commentId);
        }

        public IEnumerable<CommentModel> GetComments()
        {
            return _dbContext.Comments.ToList();
        }

        public void InsertComment(CommentModel comment)
        {
            _dbContext.Comments.Add(comment);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateComment(CommentModel comment)
        {
            _dbContext.Entry(comment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
