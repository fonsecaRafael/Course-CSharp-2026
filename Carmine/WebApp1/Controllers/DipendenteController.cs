using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DipendenteController : ControllerBase
    {
        // metodo per inserire un nuovo dipendente
        [HttpPost("CreaDipendente")]
        public string Nuovo_dipendente(DatiDipendente dip)
        {
            string Risultato = "";
            Risultato = "Metodo chiamato";
            Risultato += "Nome --> " + dip.Nome + "\n";
            Risultato += "Cognome --> " + dip.Cognome + "\n";
            Risultato += "Eta --> " + dip.Eta + "\n";
            Risultato += "Reparto --> " + dip.Reparto + "\n";

            //Inserisci i dati nel database
            return Risultato;
        }//CreaDipendente

        //metodo per leggere le info di dettaagli di un documento
        [HttpGet("Dettaglio/{matricola}")]
        public string Dettaglio_Dipendente(string matricola)
        {
            string risultato = "";
            risultato = "prelevo le info del dipendente con matricola" + matricola;
            return risultato;
        }//DettaaglioDipendente
    }
}

