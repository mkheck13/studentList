using Microsoft.EntityFrameworkCore;
using studentList.Models;

namespace studentList.Context
{
    //This class will act as a bridge from our C# app to our DataBase
    public class DataContext : DbContext
    {
        //DbContextOPtions will configure the database connection and other settings
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        //We are setting a table in our database named students and it is of our StudentModel Type
        public DbSet<StudentModel> Students { get; set; }
    }
}