namespace Encapsulacion;
// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(){
        Circulo circle = new();

        ConversorDolaresPesos cv = new();
        Console.WriteLine(cv.convert(1));

        var Automovil = new Coche(largo: 1.60, ancho: 0.80, climatizador: true, tapiceria: "");
        Console.WriteLine(Automovil.getRuedas());
    }
}