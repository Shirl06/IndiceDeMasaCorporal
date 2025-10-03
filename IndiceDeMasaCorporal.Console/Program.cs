// Declaración de variables
double peso, estatura, imc;
string estado;

// Entrada de datos
Console.WriteLine("Ingresa tu peso en kg: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresa tu estatura en metros: ");
estatura = Convert.ToDouble(Console.ReadLine());

// Proceso: cálculo del IMC y determinación del estado nutricional
imc = CalcularIMC(peso, estatura);
estado = EstadoNut(imc);

// Salida de resultados
Console.WriteLine("Tu IMC es: " + imc);
Console.WriteLine("Estado nutricional: " + estado);

// Método que calcula el IMC con la fórmula: peso / (estatura * estatura)
static double CalcularIMC(double peso, double estatura)
{
    return peso / (estatura * estatura);
}

// Método que determina el estado nutricional según los rangos de la OMS
static string EstadoNut(double imc)
{
    if (imc < 18.5)
    {
        return "Peso bajo";
    }
    else if (imc < 25.0)
    {
        return "Peso normal";
    }
    else if (imc < 30.0)
    {
        return "Sobrepeso";
    }
    else if (imc < 40.0)
    {
        return "Obesidad";
    }
    else
    {
        return "Obesidad extrema";
    }
}