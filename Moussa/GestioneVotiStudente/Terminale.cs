using System;

namespace GestioneVotiStudente;

public static class Terminale
{
  public static void Write(string sText)
  {
    Console.WriteLine(sText);
  }//Write

  public static void Wait()
  {
    Console.Write("\nPremere un tasto qualsiasi per continuare...");
    Console.ReadKey(true);
  }//Wait

  public static void Clear()
  {
    Console.Clear();
  }//Clear

  public static void WaitAndClear()
  {
    Wait();
    Clear();
  }//Wait And Clear

  public static string AskUserInput()
  {
    string? sInput;
    sInput = Console.ReadLine();
    return string.IsNullOrEmpty(sInput) ? "" : sInput;
  }//Ask User Input
}
