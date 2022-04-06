using System;
using Assignment8.Models;
using Microsoft.EntityFrameworkCore;
namespace Assignment8.data{
    public class ApplicationDbContext:DbContext{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){}
        public DbSet<Student> Student{get;set;}
       public DbSet<Subject> Subject{get;set;}
    }
}