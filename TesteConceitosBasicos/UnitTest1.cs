using ConceitosBasicos;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class CalculadoraIMCTeste
    {
        [TestMethod]
        public void CalcularTeste()
        {
            //cenario
            float peso = 70f;
            float altura = 1.7f;
            CalculadoraIMC calculadora = new CalculadoraIMC();
            
            //ação
            float imc = calculadora.Calcular(peso, altura);
            //separar os metodos calcular imc e obter staus na 
            // classe CalcularImc
            // assistir ao video sobre solid do felipe deschamps
            //verificação
            Assert.AreEqual(25, imc);
        }
        [TestMethod]
        public void ObterClassificacaoTest()
        {
            float imc = 25;
            string status;
            CalculadoraIMC calculadoraIMC = new CalculadoraIMC();   
            status = calculadoraIMC.ObterClassificacao(imc);
            Assert.AreEqual("sobrepeso", status);
        }
    }
}