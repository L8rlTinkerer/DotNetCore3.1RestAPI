using DotNetCore3._1RestAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore3._1RestAPI.Services
{
    public interface IPostService
    {
        List<Post> GetPosts();

        Post GetPostById(Guid postId);

        bool UpdatePost(Post postToUpdate);
    }
}
