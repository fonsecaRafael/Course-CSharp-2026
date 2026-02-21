using System;
namespace Esercizio_02_C
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      //TODO: 11010 base 2 => 110 doveva ritornare => 1A
      //TODO: Deletare funzione Write, cambiare tutti per Console.Write
      //TODO: Implementare testi unitari estensivi

      //Dichiarazione di variabile
      List<string> lstResult = new();
      SortedDictionary<char, int> dctDecimalValues = GetHexdecimalToDecimalValues();
      //Fine dichiarazione di variabile

      while (true)
      {
        Console.Clear();
        int iStartBase = GetValidBase(WriteStartBaseQuestion, 2, 16);
        string sStartNumber = GetValidString(WriteNumberQuestion, iStartBase, dctDecimalValues);
        int iDesiredBase = GetValidBase(WriteEndBaseQuestion, 2, 16);

        string sEndNumber = "";
        if (iStartBase == iDesiredBase)
        {
          sEndNumber = sStartNumber;
        }
        else if (iStartBase == 10)
        {
          lstResult = SuccessiveDivisions(int.Parse(sStartNumber), iDesiredBase);
        }
        else if (iDesiredBase == 10)
        {
          sEndNumber = $"{ConvertBase10(sStartNumber, iStartBase, dctDecimalValues)}";
        }
        else
        {
          int iStartNumber = ConvertBase10(sStartNumber, iStartBase, dctDecimalValues);
          lstResult = SuccessiveDivisions(iStartNumber, iDesiredBase);
        }

        if (string.IsNullOrEmpty(sEndNumber))
        {
          Write(GetEndMessage(sStartNumber, iStartBase, lstResult, iDesiredBase));
        }
        else
        {
          Write(GetEndMessage(sStartNumber, iStartBase, sEndNumber, iDesiredBase));
        }
        CheckContinue();
      }
    }//Main
    private static void CheckContinue()
    {
      Write("\nVuole continuare? (N per uscire)");
      string sUpperInput = AskInput().ToUpper();
      if (sUpperInput.Equals("N"))
      {
        Environment.Exit(0);
      }
    }//CheckContinue
    private static string GetValidString(Action WriteQuestion, int iBase, SortedDictionary<char, int> dctDecimalValues)
    {
      string sResult;
      WriteQuestion();
      sResult = AskInput();
      while (InvalidString(sResult, iBase, dctDecimalValues))
      {
        sResult = AskValidNumber(WriteQuestion);
      }
      return sResult;
    }//GetValidString
    private static int GetValidBase(Action WriteQuestion, int iMinAllowed, int iMaxValue)
    {
      string sResult;
      WriteQuestion();
      sResult = AskInput();
      while (InvalidOrNotAllowed(sResult, iMinAllowed, iMaxValue))
      {
        sResult = AskValidNumber(WriteQuestion);
      }
      return int.Parse(sResult);
    }//GetValidBase
    private static string AskValidNumber(Action WriteQuestion)
    {
      string sResult;
      WriteQuestion();
      sResult = AskInput();
      return sResult;
    }//AskValidNumber
    private static void WriteInvalidValue(char cDigit, int iBase)
    {
      Write($"\nIl valore {cDigit} non è valido per la base: {iBase}");
    }//WriteInvalidValue
    private static bool InvalidString(string sValue, int iBase, SortedDictionary<char, int> dctDecimalValues)
    {
      Dictionary<char, int> dctAlphabet = dctDecimalValues.Take(iBase).ToDictionary(x => x.Key, x => x.Value);
      foreach (char caracter in sValue)
      {
        if (!dctAlphabet.ContainsKey(caracter))
        {
          WriteInvalidValue(caracter, iBase);
          return true;
        }
      }
      return false;
    }//InvalidString
    private static bool InvalidOrNotAllowed(string sValue, int iMinAllowed, int iMaxAllowed)
    {
      bool bResult, bInvalid, bNotAllowed;
      bInvalid = !int.TryParse(sValue, out int iNumber);
      bNotAllowed = !(iNumber > (iMinAllowed - 1) && iNumber < (iMaxAllowed + 1));
      if (bInvalid)
        Write($"\n{sValue} non è um numero intero.");
      if (bNotAllowed)
        Write($"Il numero deve essere fra {iMinAllowed} e {iMaxAllowed}");
      bResult = bInvalid || bNotAllowed;
      return bResult;
    }//InvalidOrNotAllowed
    private static void WriteNumberQuestion()
    {
      Write("Inserisci un numero:");
    }//WriteNumberQuestion
    private static void WriteStartBaseQuestion()
    {
      Write("Qual è la base del numero iniziale? (Fra 2 e 16)");
    }//WriteStartBaseQuestion
    private static void WriteEndBaseQuestion()
    {
      Write("In quale base vuole convertire? (Fra 2 e 16)");
    }//WriteEndBaseQuestion
    private static string GetEndMessage(string sStartNumber, int iStartBase, List<string> lstEndNumber, int iDesiredBase)
    {
      string sEndNumber = string.Concat(lstEndNumber);
      string sResult = $"\nIl numero    : {sStartNumber}\t Nella base: {iStartBase}";
      sResult += $"\nSi diventa in: {sEndNumber}\t Nella base: {iDesiredBase}";
      return sResult;
    }//GetEndMessage(string, int, List<string>, int)

    private static string GetEndMessage(string sStartNumber, int iStartBase, string sEndNumber, int iDesiredBase)
    {
      string sResult = $"\nIl numero    : {sStartNumber}\t Nella base: {iStartBase}";
      sResult += $"\nSi diventa in: {sEndNumber}\t Nella base: {iDesiredBase}";
      return sResult;
    }//GetEndMessage(string, int, STRING, int) -- POLIMORF
    public static void Write(string sTesto)
    {
      Console.WriteLine(sTesto);
    }//Write
    public static string AskInput()
    {
      string? sInput;
      sInput = Console.ReadLine();
      return sInput.ToUpper();
    }//AskInput
    public static bool ValidBase(string sBase)
    {
      bool bResult;
      try
      {
        bResult = int.Parse(sBase) < 17;
      }
      catch (Exception)
      {
        Write("Valore massimo per la base: 16");
        return false;
      }
      return bResult;
    }//ValidBase
    public static int ConvertBase10(string sStartNumber, int iStartBase, SortedDictionary<char, int> dctDecimalValues)
    {
      int iInBase10 = 0;
      int iPositionValue;
      for (int i = 0; i < sStartNumber.Length; i++)
      {
        iPositionValue = (int)Math.Round(Math.Pow(iStartBase, sStartNumber.Length - (i + 1)));
        iInBase10 += dctDecimalValues[sStartNumber[i]] * iPositionValue;
      }
      return iInBase10;
    }//ForBase10
    public static List<string> SuccessiveDivisions(int iInBase10, int iBaseDesired)
    {
      List<string> lstResult = [];
      int iResto;
      while (iInBase10 > 0)
      {
        iResto = iInBase10 % iBaseDesired;
        iInBase10 /= iBaseDesired;
        lstResult.Add(iResto.ToString());
      }
      lstResult.Reverse();
      return lstResult;
    }//SuccessiveDivisions
    private static SortedDictionary<char, int> GetHexdecimalToDecimalValues()
    {
      SortedDictionary<char, int> dctResult = new()
      {
        {'0', 00},
        {'1', 01},
        {'2', 02},
        {'3', 03},
        {'4', 04},
        {'5', 05},
        {'6', 06},
        {'7', 07},
        {'8', 08},
        {'9', 09},
        {'A', 10},
        {'B', 11},
        {'C', 12},
        {'D', 13},
        {'E', 14},
        {'F', 15},
      };
      return dctResult;
    }//GetHexdecimalToDecimalValues
  }//Program
}//Namespace

