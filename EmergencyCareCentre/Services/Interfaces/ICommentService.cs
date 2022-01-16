using EmergencyCareCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Services.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<CommentModel> GetComments();
        CommentModel GetCommentById(int commentId);
        void InsertComment(CommentModel comment);
        void DeleteComment(int commentId);
        void UpdateComment(CommentModel comment);
        void Save();
    }
}
