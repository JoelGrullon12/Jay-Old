﻿using Jay.Core.Application.ViewModels.Post;
using Jay.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jay.Core.Application.ViewModels.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public DateTime Created { get; set; }
        public UserViewModel User { get; set; }
        public PostViewModel Post { get; set; }
    }
}
