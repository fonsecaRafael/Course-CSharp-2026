
namespace GestioneVotiStudente
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      //Dichiarazione di Variabile
      string sMenu = "============ MENU ============\n";
      sMenu += "1 - Per inserisci un studente, senza voti\n";
      sMenu += "2 - Per inserisci voti per uno studente\n";
      sMenu += "3 - Per inserisci voti per tutti gli studenti senza voti\n";
      sMenu += "4 - Per inserisci un studente con voti\n";
      sMenu += "0 - Per uscire\n";

      Database Db = new([]);
      Dictionary<string, Func<Database, bool>> DctFunc = new()
      {
        { "1", AddStudent},
        { "2", AddOneStudentGrades},
        { "3", AddAllStudentsGrades},
        { "4", AddFullStudent},
        { "0", Quit},

      };

      bool collegato = true;
      string sInput;
      // Fine dichiarazione di Variabile

      while (collegato)
      {
        Terminale.Write(sMenu);
        sInput = Terminale.AskUserInput();

      }//While (collegato)
    }//Main

    private static bool AddFullStudent(Database db)
    {
      throw new NotImplementedException();
    }

    private static bool Quit(Database db)
    {
      throw new NotImplementedException();
    }

    private static bool AddAllStudentsGrades(Database db)
    {
      throw new NotImplementedException();
    }

    private static bool AddOneStudentGrades(Database db)
    {
      throw new NotImplementedException();
    }

    public static bool AddStudent(Database Db)
    {
      string sName = AskName();
      try
      {
        Db.CreateStudent(sName);
        return true;
      }
      catch (System.Exception)
      {
        return false;
      }

    }

    private static string AskName()
    {
      string sName;
      Terminale.Write("Inserisci il nome del studente: ");
      sName = Terminale.AskUserInput();
      return sName;
    }
  }//Program
}//Namespace



//  Exempo Function Dict
// void GetNumber(){
//   Console.WriteLine("ai");
// }
// var dict = new Dictionary<string, Action>
// {
//   ["1"] = GetNumber,
// };
// dict["numero"]();  // Executa o método