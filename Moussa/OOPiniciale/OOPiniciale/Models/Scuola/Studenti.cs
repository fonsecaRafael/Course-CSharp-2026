namespace OOPiniciale.Models.Scuola;

/// <summary>
///  Modello che definisce la struttura dei dati per uno studente, 
///  con proprietà per nome, cognome e età 🎉🎉🎉🎉🎉🎉🎉🎉
/// </summary>
public class Studenti
{
  #region Proprietà
  public string nome { get; set; }
  public string cognome { get; set; }
  public int eta { get; set; }
  #endregion

  #region Costruttori 
  public Studenti()
  {
    // Heu sono vuoto, ma posso essere usato per creare un oggetto senza inizializzare le proprietà
  }

  /// <summary>
  /// Costruttore che accetta nome e cognome
  /// </summary>
  /// <param name="nome"></param>
  /// <param name="cognome"></param>
  public Studenti(string nome, string cognome)
  {
    this.nome = nome;
    this.cognome = cognome;
  }

  /// <summary>
  /// Costruttore che accetta nome completo (nome + cognome) e lo divide in nome e cognome
  /// </summary>
  /// <param name="nomeCompleto"></param>
  public Studenti(string nomeCompleto)
  {
    nomeCompleto = this.nome + " " + this.cognome;
  }

  /// <summary>
  /// Costruttore che accetta nome e età
  /// </summary>
  /// <param name="nome"></param>
  /// <param name="eta"></param>
  public Studenti(string nome, int eta)
  {
    this.nome = nome;
    this.eta = eta;
  }
  #endregion
}
