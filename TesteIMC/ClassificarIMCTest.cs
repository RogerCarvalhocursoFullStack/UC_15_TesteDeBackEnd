using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    [TestClass]
    public class ClassificarIMCTest

    {
        [TestMethod]
       
        public void ClassificarIMC()
        {
            //Arrange - Preparação
            double imc = 28;
            
            //Act - Ação
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //Arrange - Verificação
            Assert.AreEqual("Sobrepeso", classificacaoIMC);

        }
    }
}
