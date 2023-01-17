using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CCodeFirst
{
    public class Cource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
    }
    public class Author
    {
        public string Name { get; set; }
        public string Desc { get; set; }
    }

    public class TagCource
    {
        public string TabName { get; set; }
        public string TabDesc { get; set; }
    }

    }
    public class DbBlogContext : DbContext
    {
        public DbSet<Post> posts { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
