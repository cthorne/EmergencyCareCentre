using EmergencyCareCentre.Models;
using EmergencyCareCentre.Repositories.Interfaces;
using EmergencyCareCentre.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Services
{
    public class CommentService : ICommentService
    {
        ICommentRepository _commentRepo;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepo = commentRepository;
        }

        public void DeleteComment(int commentId)
        {
            _commentRepo.DeleteComment(commentId);
        }

        public CommentModel GetCommentById(int commentId)
        {
            return _commentRepo.GetCommentById(commentId);
        }

        public IEnumerable<CommentModel> GetComments()
        {
            return _commentRepo.GetComments();
        }

        public void InsertComment(CommentModel comment)
        {
            _commentRepo.InsertComment(comment);
        }

        public void Save()
        {
            _commentRepo.Save();
        }

        public void UpdateComment(CommentModel comment)
        {
            _commentRepo.UpdateComment(comment);
        }
    }
}
