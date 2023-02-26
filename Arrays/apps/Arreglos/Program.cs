namespace Arreglos;

class Arreglos
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int[] my_array = {0,1,2,3,4};
        //my_array[5] = 5; => Marcara un error 


        //Arreglo de Objetos.
            Car[] Arreglo_Cars = new Car[5];

            //Agregar un objeto existente
            Car car = new Car(Name:"Hola", Color: "ROJO");
            Arreglo_Cars[0] = car; 

            //Crear un objeto dentro del array 
            Arreglo_Cars[1] = new Car("Bocho", "aZUL");


        //Arreglos de Clases Anonimas
        //deben de ser del mismo tipo de datos
        var carros = new[]
        {
            new{Nombre="JOsue", edad=23},
            new{Nombre="Isaac", edad=22}
        };

    }
}


class Car
{
    string Name;
    string Color;
    
    public Car(string Name, string Color)
    {
        this.Color = Color;
        this.Name = Name;
    }
}