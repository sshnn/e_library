﻿using Library.Entities.Concreate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Library.DataAccess.Concreate.EntityFrameworkCore.Mapping;

namespace Library.DataAccess.Concreate.EntityFrameworkCore.Context
{
    public class ApplicationDbContext : IdentityDbContext<Member, Role, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =DESKTOP-DL4SL8P; database = LibrarySystemProject; integrated security = true;");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AuthorMap());
            builder.ApplyConfiguration(new MemberMap());
            builder.ApplyConfiguration(new BookMap());
            builder.ApplyConfiguration(new MemberBookMap());
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new SubCategoryMap());
            builder.ApplyConfiguration(new RequestMap());


            base.OnModelCreating(builder);
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<MemberBook> MemberBook { get; set; }



    }
}
