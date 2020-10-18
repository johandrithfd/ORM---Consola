using System;
using Microsoft.EntityFrameworkCore;

namespace EFCOMENZANDO
{
    public class BlogsContext : DbContext
    {
        public DbSet<Blog> Blogs {get; set;}
        public DbSet<Post> Posts {get; set;}
        protected override void OnConfiguring (DbContextOptionsBuilder opciones)
        =>opciones.UseSqlite("Data Source=Blogs.db");
    }
}
