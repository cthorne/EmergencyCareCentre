using EmergencyCareCentre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Repositories.Interfaces
{
    interface ICommentRepository
    {
        IEnumerable<CommentModel> GetComments();
        CommentModel GetCommentById(int commentId);
        void InsertComment(CommentModel comment);
        void DeleteComment(int commentId);
        void UpdateComment(CommentModel comment);
        void Save();
    }
}
