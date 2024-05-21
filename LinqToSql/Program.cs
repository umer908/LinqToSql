// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using LinqToSql;
using LinqToSql.Linq;
using Microsoft.EntityFrameworkCore.Migrations.Operations;


LinqSql linqSqldb = new LinqSql();
StudentDb studentDb = new StudentDb(linqSqldb);


studentDb.Add(
    new tbl_student
    {
        FirstName = "Ali",
        LastName = "Butt",
        Gender = "Male",
        DateOfBirth = new DateTime(1991, 4, 14),
        IsActive = true
    });

//studentDb.Update(2);

var student1 = studentDb.GetAll();

foreach (var student in studentDb.GetAll())
{
    Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}, Gender: {student.Gender}, Date of Birth: {student.DateOfBirth.ToShortDateString()}, Active: {student.IsActive}");
}



