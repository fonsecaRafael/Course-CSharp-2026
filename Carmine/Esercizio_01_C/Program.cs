using System;
using System.Collections.Generic;

namespace Esercizio_01_C;

public class Program
{
  public static void Write(string sText)
  {
    System.Console.WriteLine(sText);
  }//Write
  public static void WaitConfirmationToAdvance()
  {
    Console.Write("\nPremere un tasto qualsiasi per continuare...");
    Console.ReadKey(true);
  }//WaitConfirmationToAdvance
  public static void ClearScreen()
  {
    Console.Clear();
  }//ClearScreen
  public static void WaitAndClear()
  {
    WaitConfirmationToAdvance();
    ClearScreen();
  }//WaitAndClear
  public static string? AskInput()
  {
    return Console.ReadLine();
  }//AskInput

  public static int GetLength(string sWord)
  {
    int iResult;
    iResult = sWord.Length;
    return iResult;
  }//GetLength

  public static string Captalize(string sWord)
  {
    string sResult;
    sResult = char.ToUpper(sWord[0]) + sWord.Substring(1).ToLower();
    return sResult;
  }//Captalize

  public static bool CheckInvalidConfirmation(string sCandidate, List<string> lstValidOptions)
  {
    bool bResult;
    bResult = !lstValidOptions.Contains(sCandidate);
    return bResult;
  }//CheckInvalidConfirmation
  public static bool Equal(string sCandidate, string sSuccess)
  {
    bool bResult;
    bResult = sCandidate.Equals(sSuccess);
    return bResult;
  }//Equal

  public static string[] ConvertToArray(string sText, char delimiter = ' ')
  {
    string[] arrResult;
    arrResult = sText.Split(delimiter);
    return arrResult;
  }//ConvertToArray

  public static string[] ExtractCsvData(string sCsv, char delimiter = ',')
  {
    string[] arrResult;
    arrResult = sCsv.Split(delimiter);
    if (arrResult.Length != 4)
    {
      return [];
    }
    else
    {
      return [arrResult[0], arrResult[3], arrResult[1], arrResult[2]];
    }
  }//ExtractData

  public static string ExtractedToString(string[] sLabel, string[] sValue)
  {
    string sResult = "";
    if (sLabel.Length == sValue.Length)
    {
      for (int i = 0; i < sLabel.Length; i++)
      {
        sResult += $"{sLabel[i]}:\t{sValue[i]}\n";
      }
    }
    return sResult;
  }//ExtractedToString

  public static Dictionary<string, int> GetEachWordAmount(string[] arrText)
  {
    Dictionary<string, int> dictResult = new();
    for (int i = 0; i < arrText.Length; i++)
    {
      if (dictResult.ContainsKey(arrText[i]))
      {
        dictResult[arrText[i]] += 1;
      }
      else
      {
        dictResult.Add(arrText[i], 1);
      }
    }
    return dictResult;
  }//GetEachWordAmount
  static void Main(string[] args)
  {
    // Dichiarazione di Variabile
    string sMenu = "==== MENU ====";
    sMenu += "\n1 - Per inserire un messagio e scoprire la sua lunghezza";
    sMenu += "\n2 - Per capitalizzare una parola.";
    sMenu += "\n3 - Per vedere un messagio essere stampado comè un array.";
    sMenu += "\n4 - Per informare un messagio separato por \";\" e ricevere i dati tratati.";
    sMenu += "\n5 - Uscire dal programma.";
    sMenu += "\n6 - Per contare la quantità di parole ripetita in un messagio.";
    sMenu += "\nScegli:";
    string? sOption, sInput;
    // Fine Dichiarazione di Variabile
    while (true)
    {
      sInput = "";
      Write(sMenu);
      sOption = AskInput();
      switch (sOption)
      {
        case "1":
          ClearScreen();
          Write("\nInserice un testo per controlare la sua lunghezza:");
          sInput = AskInput();
          int iLength = GetLength(sInput);
          Write($"\nLunghezza: {iLength}");
          WaitAndClear();
          break;

        case "2":
          ClearScreen();
          Write("\nInserisci una parola e sarà capitalizada:");
          sInput = AskInput();
          string sCapitalized = Captalize(sInput);
          Write($"\nCapitalizzato: {sCapitalized}");
          WaitAndClear();
          break;

        case "3":
          ClearScreen();
          Write("\nInserice un messagio e sarà stampado una parola per riga:");
          sInput = AskInput();
          string[] arrInput = ConvertToArray(sInput);
          Write("");
          foreach (string parole in arrInput)
          {
            Write(parole);
          }
          WaitAndClear();
          break;

        case "4":
          ClearScreen();
          Write("\nInserice un messagio delimitato da \";\"");
          sInput = AskInput();
          // carmine Caroppoli;caroppoli@gmail.com;3421220947;crpcmn71d06c933b
          string[] sLabels = ["Nominativo", "Codice Fiscale", "E-mail", "Telefono"];
          int iExpectedSize = sLabels.Length;
          string[] sExtractedData = ExtractCsvData(sInput, ';');
          if (sExtractedData.Length == sLabels.Length)
          {
            string sExtractedDataToString = ExtractedToString(sLabels, sExtractedData);
            Write("\n" + sExtractedDataToString);
          }
          else
          {
            Write($"Errore! Il messagio deve avere {iExpectedSize} parole delimitata per {iExpectedSize - 1} ;");
          }
          WaitAndClear();
          break;

        case "5":
          bool bInvalidConfirmation = true;
          List<string> arrValidOptions = ["S", "N"];
          while (bInvalidConfirmation)
          {
            ClearScreen();
            Write("\nConferma que vuole uscire? (S/N)");
            string sUpperInput = AskInput().ToUpper();
            bInvalidConfirmation = CheckInvalidConfirmation(sUpperInput, arrValidOptions);
            if (!bInvalidConfirmation)
            {
              if (Equal(sUpperInput, arrValidOptions[0]))
              {
                Environment.Exit(0);
              }
              else
              {
                Write("\nRitorno al menu principale...");
              }
            }
            else
            {
              Write("\nOpzione non è valida!\n");
              WaitConfirmationToAdvance();
            }

          }
          WaitAndClear();
          break;

        case "6":
          ClearScreen();
          Write("\nInserice un messagio e verrà visualizzato il numero di volte in cui viene ripetuta ogni parola:");
          sInput = AskInput();// uno due due tre tre tre quatro quatro quatro quatro
          string[] arrWords = ConvertToArray(sInput);
          Dictionary<string, int> dictWordAmount = GetEachWordAmount(arrWords);

          Write("");
          foreach (var (sKey, iValue) in dictWordAmount)
          {
            Write($"Parola: {sKey} \tRipetuta: {iValue}");
          }
          WaitAndClear();
          break;

        default:
          Write("\nOpzione non è valida!\n");
          WaitAndClear();
          break;
      }//Switch
    }//While
  }//Main
}//Program