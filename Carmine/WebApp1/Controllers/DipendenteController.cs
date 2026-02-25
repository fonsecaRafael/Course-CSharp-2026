using Microsoft.AspNetCore.Mvc;
using WebApi1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi1.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DipendenteController : ControllerBase
  {
    // metodo per inserire un nuovo dipendente
    [Route("CreaDipendente")]
    [HttpPost]
    public string Nuovo_dipendente(datiDipendente dip) {
      string Risultato ="";
      Risultato = "Metodo chiamato ";
      Risultato += "Nome --> " + dip.Nome+"\n";
      Risultato += "Cognome --> " + dip.Cognome + "\n";
      Risultato += "Eta' --> " + dip.Eta + "\n";
      Risultato += "Reparto --> " + dip.Reparto + "\n";

      //inserire i dati nel database
      return Risultato;
    }//CreaDipendente

    //metodo per leggere le info di dettaagli di un documento
    
    [HttpGet("Dettaglio/{matricola}")]
    public string Dettaglio_Dipendente(string matricola, string Cognome) {
      string risultato = "";
      risultato = "prelevo le info del dipendente con matricola " + matricola;
      return risultato;
    }//DettaaglioDipendente


    // GET: api/<DipendenteController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/<DipendenteController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<DipendenteController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<DipendenteController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<DipendenteController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
