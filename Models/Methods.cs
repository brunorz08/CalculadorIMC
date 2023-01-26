using System.Reflection.PortableExecutable;

namespace CalculadoraIMC.Models
{
    public class Methods
    {

        public double calcularIMC(IMC imc)
        {

            return Math.Round((imc.peso / (imc.estatura * imc.estatura)) * 10000,2);
        }
    }
}
