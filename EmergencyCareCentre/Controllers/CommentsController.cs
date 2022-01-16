using EmergencyCareCentre.Models;
using EmergencyCareCentre.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergencyCareCentre.Controllers.Interfaces
{
    //[Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class CommentsController : ControllerBase, ICommentsController
    {
        ICommentService _commentsService;
        public CommentsController(ICommentService commentService)
        {
            _commentsService = commentService;
        }

        [HttpDelete]
        public void DeleteComment(int commentId)
        {
            _commentsService.DeleteComment(commentId);
        }

        [HttpGet]
        public CommentModel GetCommentById(int commentId)
        {
            return _commentsService.GetCommentById(commentId);
        }

        [HttpGet]
        public IEnumerable<CommentModel> GetComments()
        {
            return _commentsService.GetComments();
        }

        [HttpPut]
        public void InsertComment(CommentModel comment)
        {
            _commentsService.InsertComment(comment);
        }

        [HttpPatch]
        public void UpdateComment(CommentModel comment)
        {
            _commentsService.UpdateComment(comment);
        }
    }
}
