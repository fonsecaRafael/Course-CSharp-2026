using OOPiniciale.Models;
namespace Stampa.ViewModels;

public class MV_Studenti
{
  public MV_Studenti()
  {

    People person = new("Person", "Rossi", 20, 'M', "Italiano");
    Students student = new("Student", "Silva", 30, 'F', "Brasiliana");

    Console.WriteLine($"\nPerson = {person}");
    Console.WriteLine($"\nStudent = {student}");

    List<Students> Students = new();
    for (int i = 1; i < 12; i++)
    {
      char cGender = i % 2 == 0 ? 'M' : 'F';
      Students sStudent = new($"Nome_{i}", $"Cognome_{i}", i, cGender, $"Nationalita_{i}");
      Students.Add(sStudent);
    }

    foreach (var _ in Students)
    {
      Console.WriteLine(_);
    }
  }
}