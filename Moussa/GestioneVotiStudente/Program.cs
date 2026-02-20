namespace GestioneVotiStudente
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      //Dichiarazione di Variabile
      string sMenu = "============ MENU ============\n";
      sMenu += "1 - Per inserisci un studente";
      sMenu += "2 - Per inserisci voti per uno studente";
      sMenu += "3 - Per inserisci voti per tutti gli studenti";
      sMenu += "0 - Per uscire";


      //  Exempo Function Dict
      // void GetNumber(){
      //   Console.WriteLine("ai");
      // }
      // var dict = new Dictionary<string, Action>
      // {
      //   ["1"] = GetNumber,
      // };
      // dict["numero"]();  // Executa o método

      bool collegato = true;
      string sInput;
      // Fine dichiarazione di Variabile

      while (collegato)
      {
        Terminale.Write(sMenu);
        sInput = Terminale.AskUserInput();

      }//While (collegato)
    }
  }//Program
}//Namespace