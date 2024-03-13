using ConceitosBasicos;
bool prossiga = true;
do
{
    try
    {

        Console.WriteLine("Informe a altura");
        float altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Infor o seu Peso: ");
        float peso = float.Parse (Console.ReadLine());
            CalculadoraIMC calculadoraIMC = new CalculadoraIMC();  
        string resposta= calculadoraIMC.Calcular(altura, peso);
        Console.WriteLine(resposta);
   
        prossiga = false;
    }

    catch (FormatException)
    {
        Console.WriteLine("INFORME APENAS NUMEROS");
    }
} while (true);