
using CalculadoraIMC.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraIMC.Pages
{
    public class IndexModel : PageModel

       
    {
        public Methods methods = new Methods();
        public double resultado;

     

        public IndexModel(Methods metodos)
        {
          
            methods = metodos;
        }




        public void OnPost()
        {
           resultado = methods.calcularIMC(new IMC()
           {
               peso = Convert.ToDouble(Request.Form["peso"]),
               estatura = Convert.ToDouble(Request.Form["estatura"])
           });
        }
        public void OnGet()
        {
            
        }
    }
}