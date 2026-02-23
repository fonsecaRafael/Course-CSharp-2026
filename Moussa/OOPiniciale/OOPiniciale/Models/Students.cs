namespace OOPiniciale.Models;

public class Students : People
{
  // public ItalianFiscalCode? CodFiscale { get; private set; }
  // public Address? Address { get; private set; }

  #region Constructors
  public Students(string Name, string Surname, int Age, char Gender, string Nationality) : base(Name, Surname, Age, Gender, Nationality)
  {
  }
  #endregion

  #region Methods
  public override string ToString()
  {
    return $"Nome completo: {Name} {Surname}\nGender: {Gender} Età: {Age} anni";
  }
  #endregion
}
