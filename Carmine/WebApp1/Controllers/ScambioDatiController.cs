using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
//using WebApi1.Models.Conversione;
using Newtonsoft.Json;
using WebApi1.ModelliJson;

namespace WebApi1.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ScambioDatiController : ControllerBase
  {
    //[Route("Input")]
    [HttpGet("Input")] //implicimente implementaa laa rotta di sopra
    public string TrasformaJson(string Json)
    {
      string risultato = "";
      string sInfoCode = "";
      //prendo la stringa json, che è in formato json!!!,
      //e la DESERIALIZZO
      RispostaPRA objInfo = new RispostaPRA();
      try
      {
        objInfo = JsonConvert.DeserializeObject<RispostaPRA>(Json);
      }
      catch (Exception ex) { return "Errore nel formato json"; }
      magazzino objMagazzino = new magazzino();
      objMagazzino = JsonConvert.DeserializeObject<magazzino>(Json);




      string sTarga = objInfo.valori.infoDomus.Targa;
      foreach (Allestimenti elemento in objInfo.valori.infoDomus.Allestimenti)
      {
        if (elemento.anno == 2026)
        {
          sInfoCode = elemento.InfocarCode;
          break;
        }
      }//foreach

      //string sInfoCode = objInfo.infoDomus_valori.allestimenti_elenco[1].InfocarCode;
      risultato = sTarga + "-->" + "2026" + "|" + sInfoCode + objInfo.valori.otp;
      return risultato;
    }//trasforma json

    [HttpPost("CheckInput")] //implicimente implementaa laa rotta di sopra
    public string CheckInput([FromBody] RispostaPRA Json)
    {
      string risultato = "";
      string sInfoCode = "";
      if (DataCorretta(Json.valori.dataoraincidente))
      {

      }
      return "OK";
    }//Lettura
  }//controller
}
