namespace WebApi1.ModelliJson
{

  /// <summary>
  /// //
  /// </summary>
  public class Allestimenti
  {
    public int anno { get; set; }
    public string InfocarCode { get; set; }
  }

  public class InfoDomus
  {
    public string Targa { get; set; }
    public int TipoVeicolo { get; set; }
    public State state { get; set; }
    public List<Allestimenti> Allestimenti { get; set; }
  }

  public class RispostaPRA
  {
    //public Valori valori { get; set; }
    public Valori valori { get; set; } = new Valori(); 
  }

  public class State
  {
    public int Code { get; set; }
    public string Description { get; set; }
  }

  public class Valori
  {
    public string msg { get; set; }
    public string otp { get; set; }=string.Empty;
    public string dataproduzione { get; set; }
    //public DateTime dataproduzione { get; set; }
    public string dataoraincidente { get; set; }
    public InfoDomus infoDomus { get; set; }
  }
}
