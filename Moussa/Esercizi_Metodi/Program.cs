namespace Esercizi_Metodi
{
  internal class Program
  {
    public static int Somma(int iNum1, int iNum2)
    {
      // Metedo che restituisce la somma di due numeri
      int iResult;
      iResult = iNum1 + iNum2;
      return iResult;
    }//Somma(int, int)
    public static int Somma(List<int> lstNums)
    {
      //Overwriting Somma, Ritorna la somma di tutti i numeri nella lista
      int iResult = 0;
      for (int i = 0; i < lstNums.Count; i++)
      {
        iResult += lstNums[i];
      }
      return iResult;
    }//Soma(list<int>)

    public static int Differenza(int iNum1, int iNum2)
    {
      // Metedo che restituisce la differenza di due numeri
      int iResult;
      iResult = iNum1 - iNum2;
      return iResult;
    }//Differenza

    public static string Salute(string sName)
    {
      // Restituisce una string del tipo Ciao, <nome>!\n
      string sResult;
      sResult = $"Ciao, {sName}!\n";
      return sResult;
    }//Salute(string)

    public static string Salute(List<string> lstNames)
    {
      //  Overwriting! Saluta tutti i nomi nella lista
      string sResult = "";
      foreach (string name in lstNames)
      {
        sResult += Salute(name);
      }
      return sResult;
    }//Salute(List<string>)

    // public static void StampaInMinuscola(this string sTesto)
    // {
    //   System.Console.WriteLine(sTesto.ToLower());
    // }
    // public static void StampaInMinuscolaSenzaThis(string sTesto)
    // {
    //   System.Console.WriteLine(sTesto.ToLower());
    // }



    public static void Main(string[] args)
    {
      System.Console.WriteLine($"Somma(1, 2) = {Somma(1, 2)}");
      System.Console.WriteLine($"Somma([1, 2, 3]) = {Somma([1, 2, 3])}");
      System.Console.WriteLine($"Differenza(1, 2) = {Differenza(1, 2)}");
      System.Console.WriteLine($"\nSalute([\"Leonardo\",\"Gisele\",\"Brad\",\"Angelina\"]):\n{Salute(["Leonardo", "Gisele", "Brad", "Angelina"])}");
      // StampaInMinuscola("COSA!");
      // StampaInMinuscolaSenzaThis("COSA!");

    }//Main
  }//Program
}