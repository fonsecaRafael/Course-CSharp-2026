using System;

namespace GestioneVotiStudente;

public class Studente
{
  //Dichiarazione di variabile
  public string Nome { get; private set; }
  private List<double> _voto;
  public List<double> Voto
  {
    get
    {
      return _voto;
    }// get Voto
    private set
    {
      foreach (double dVoto in value)
      {
        if (!ValidVoto(dVoto))
        {
          throw new InvalidVotoException();
        }
      }
      _voto = value;
    }// Private set Voto
  }

  private static bool ValidVoto(double dVoto)
  {
    if (dVoto < 0 || dVoto > 10)
    {
      return false;
    }
    return true;
  }//Valid Voto

  public double Media { get; private set; }
  //Fine Dichiarazione di variabile

  public Studente(string sNome)
  {
    Nome = sNome;
    Voto = [];
    Media = 0;
  }//Studente(string)

  public Studente(string sNome, List<double> dVoto)
  {
    Nome = sNome;
    Voto = dVoto;
    Media = CalcolaMedia();
  }//Studente(string, List<double)

  public double GetMedia()
  {
    if (Voto.Count > 0)
    {
      Media = CalcolaMedia();
    }
    return Media;
  }//GetMedia

  private double CalcolaMedia()
  {
    double dMedia = 0;
    foreach (double voto in Voto)
    {
      dMedia += voto;
    }
    dMedia /= Voto.Count;
    return dMedia;
  }//CalcolaMedia

  public override string ToString()
  {
    return $"Nome: {Nome}\nMedia: {Media}";
  }//ToString

  [Serializable()]
  public class InvalidVotoException : Exception
  {
    public InvalidVotoException() : base() { }
    public InvalidVotoException(string message) : base(message) { }
    public InvalidVotoException(string message, Exception inner) : base(message, inner) { }
  }
}//Namespace
