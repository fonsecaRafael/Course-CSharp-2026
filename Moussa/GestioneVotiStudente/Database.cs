using System;

namespace GestioneVotiStudente;

public class Database
{
  public List<Studente> Students { get; private set; }

  public Database(List<Studente> lstStudents)
  {
    Students = lstStudents;
  }

  internal bool CreateStudent(string sName)
  {
    try
    {
      Studente stdStudent = new(sName);
      Students.Add(stdStudent);
      return true;
    }
    catch
    {
      string sErrorMsg = $"{sName} non è acceta come nome per studente.\nStudente non è stato creato!";
      Terminale.Write(sErrorMsg);
      return false;
    }
  }
}
