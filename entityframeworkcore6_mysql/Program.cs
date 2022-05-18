using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using MySql.EntityFrameworkCore.Extensions;


//main method 
Console.WriteLine("start");
EnsureCreateDatabase();
AddAuthor();
GetAuthor();
Console.WriteLine("end");


void EnsureCreateDatabase()
{
    using (DatabaseContext context  =  new DatabaseContext())
    {
        context.Database.EnsureCreated();
    }
}

 void AddAuthor()
{
    using (DatabaseContext context = new DatabaseContext())
    {
        Author author = new Author();
        author.FirstName = "mohammed";
        author.LastName = "ali";
        context.Authors.Add(author);
        context.SaveChanges();
    }
}

void GetAuthor()
{
    using (DatabaseContext context = new DatabaseContext())
    {
        var author = context.Authors.FirstOrDefault(a =>  EF.Functions.Like(a.FirstName,"m%"));
        Console.WriteLine("authorId: " + author.AuthorId + " FirstName " + author.FirstName + " LastName " + author.LastName);
    }
}