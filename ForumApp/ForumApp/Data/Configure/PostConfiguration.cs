using Microsoft.EntityFrameworkCore;
using ForumApp.Data;
using ForumApp.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForumApp.Data.Configure
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            List<Post> posts = GetPosts();
            builder.HasData(posts);
        }

        private List<Post> GetPosts()
        {
            return new List<Post>()
            {
                new Post()
                { 
                    Id=1,
                    Title="My First Post",
                    Content="My first post will be about CRUD operations."
                },
                new Post() 
                {
                    Id=2,
                    Title="My second Post",
                    Content="This is my second post."
                },
                new Post() 
                {
                    Id=3,
                    Title="My third Post",
                    Content="Hello there! I'm getting better and better with the"
                }
            };
        }
    }
}
