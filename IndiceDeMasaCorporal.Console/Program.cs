/*using Imc.Model ;
// Declaración de variables
decimal peso, estatura, imc;
string estado;

// Entrada de datos
Console.WriteLine("Ingresa tu peso en kg: ");
peso = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Ingresa tu estatura en metros: ");
estatura = Convert.ToDecimal(Console.ReadLine());

// Proceso: cálculo del IMC y determinación del estado nutricional
imc = IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(peso, estatura);
estado = IndiceDeMasaCorporalLib.DeterminarEstadoNutricional(imc);

// Salida de resultados
Console.WriteLine($"Tu IMC es: {imc:G6}");
Console.WriteLine("Estado nutricional: " + estado);*/

using Imc.Model;

Console.WriteLine("Aplicación que calcula el indice de masa corporal de una persona\n");

decimal peso =
    ReadDecimal("Proporcion el peso en kilogramos de la persona: ");

decimal estatura =
    ReadDecimal("Proporcion la estatura en metros de la persona: ");

decimal imc = IndiceDeMasaCorporalLib.IndiceDeMasaCorporal(peso, estatura);

Console.WriteLine($"El índice de masa coporal de la persona es: {imc:G6}");
Console.WriteLine($"El estado nutricional de la persona es: {IndiceDeMasaCorporalLib.DeterminarEstadoNutricional(imc)}");

Console.WriteLine();

static decimal ReadDecimal(string indicacion)
{
    Console.Write(indicacion);
    var entradaComoTexto = Console.ReadLine();
    return Convert.ToDecimal(entradaComoTexto);
}