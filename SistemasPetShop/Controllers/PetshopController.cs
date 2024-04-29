using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemasPetShop.Controllers
{
    [Route("api/petshop")]
    [ApiController]
    public class PetshopController : ControllerBase
    {
        [HttpPost]
        public ActionResult CalcularMelhorPetshop([FromBody] DadosDoPedido dados)
        {
            if (dados == null)
            {
                return BadRequest("Dados do pedido não fornecidos.");
            }

            bool finalDeSemana = VerificarFinalDeSemana(dados.Data);

            double precoMeuCaninoFeliz = CalcularPrecoMeuCaninoFeliz(finalDeSemana, dados.QtdPequenos, dados.QtdGrandes);
            double precoVaiRex = CalcularPrecoVaiRex(finalDeSemana, dados.QtdPequenos, dados.QtdGrandes);
            double precoChowChawgas = CalcularPrecoChowChawgas(dados.QtdPequenos, dados.QtdGrandes);

            string melhorPetshop;
            double menorPreco;

            if (precoMeuCaninoFeliz <= precoVaiRex && precoMeuCaninoFeliz <= precoChowChawgas)
            {
                melhorPetshop = "Meu Canino Feliz";
                menorPreco = precoMeuCaninoFeliz;
            }
            else if (precoVaiRex <= precoChowChawgas)
            {
                melhorPetshop = "Vai Rex";
                menorPreco = precoVaiRex;
            }
            else
            {
                melhorPetshop = "ChowChawgas";
                menorPreco = precoChowChawgas;
            }

            return Ok(new { MelhorPetshop = melhorPetshop, PrecoTotal = menorPreco });
        }

        private static double CalcularPrecoMeuCaninoFeliz(bool finalDeSemana, int qtdPequenos, int qtdGrandes)
        {
            double precoPequenos = finalDeSemana ? qtdPequenos * 24.00 : qtdPequenos * 20.00;
            double precoGrandes = finalDeSemana ? qtdGrandes * 48.00 : qtdGrandes * 40.00;
            return precoPequenos + precoGrandes;
        }

        private static double CalcularPrecoVaiRex(bool finalDeSemana, int qtdPequenos, int qtdGrandes)
        {
            double precoPequenos = finalDeSemana ? qtdPequenos * 20.00 : qtdPequenos * 15.00;
            double precoGrandes = finalDeSemana ? qtdGrandes * 55.00 : qtdGrandes * 50.00;
            return precoPequenos + precoGrandes;
        }

        private static double CalcularPrecoChowChawgas(int qtdPequenos, int qtdGrandes)
        {
            return qtdPequenos * 30.00 + qtdGrandes * 45.00;
        }

        private static bool VerificarFinalDeSemana( DateTime data)
        {
            
           if(data.DayOfWeek == DayOfWeek.Sunday || data.DayOfWeek == DayOfWeek.Saturday) { 
                return true;
            
           }
           else 
                return false;

            
        }
    }

    public class DadosDoPedido
    {
        public DateTime Data { get; set; }
        public int QtdPequenos { get; set; }
        public int QtdGrandes { get; set; }
    }
}
    

