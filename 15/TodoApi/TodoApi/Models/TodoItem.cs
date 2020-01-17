using System;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models

{

    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }

    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool isComplete { get; set; }
   }
     

}

