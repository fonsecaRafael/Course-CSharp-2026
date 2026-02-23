namespace OOPiniciale.Models;
/// <summary>
/// Modello che definisce la strutura dei dati per gli oggetti
/// </summary>
public class People //
{
  #region Properties
  public string Name { get; private set; }
  public string Surname { get; private set; }
  public int Age { get; private set; }
  public char Gender { get; private set; }
  public string Nationality { get; private set; }
  #endregion

  #region Constructors
  public People(string Name, string Surname, int Age, char Gender, string Nationality)
  {
    this.Name = Name;
    this.Surname = Surname;
    this.Age = Age;
    this.Gender = Gender;
    this.Nationality = Nationality;
  }
  #endregion
}
