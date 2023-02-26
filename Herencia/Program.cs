using System;
namespace herencia;

class Program
{
    static void Main(String[] args){
        var caballo = new Caballo();
        var Humano = new Humano();
        var Gorila = new Gorila();

        //Principios de sustitucion
        //En el cual podremos crear instancias de clase padre con 
        //objetos de clases hijas 
        Mamiferos persona = new Humano();
        Mamiferos chango = new Gorila();
        Mamiferos llegua = new Caballo();

        //O por referencias
        Mamiferos a = Humano;
        Mamiferos b = caballo;
        Mamiferos c = Gorila;

        //Esto es posible por que las anteriores deriban de Mamifero, 
        //hora bien apesar de que lo estamos creando aparetir de clases hijas 
        //solo podemos usar las propiedades de la clase padre.

        Object carro = new Automovil("mustang"); //-> principio de susticion con clase principal "Object"
        //SOLO PODREMOS USAR LAS PROPIEDADES DE OBJECT 

        //Ejemplo de como almacenar con el principio de sustitucion 
        List<Mamiferos> ListaMamiferos = new List<Mamiferos>();
        ListaMamiferos.Add(persona);
        ListaMamiferos.Add(chango);
        ListaMamiferos.Add(llegua);

        //Console.WriteLine(ListaMamiferos[1].ToString);

        var surut = new Automovil("Surut");
   }
    
}

class Mamiferos
{
    public void respirar()
    {
        Console.WriteLine("Respirar...");
    }
}

class Caballo : Mamiferos // Sintaxis de herencia
{
    public void Galopar()
    {
        Console.WriteLine("galopa..");
    }
}

class Humano : Mamiferos
{
    public void pensar()
    {
        Console.WriteLine("piensa..");
    }
}

class Gorila : Mamiferos
{
    public void Trepar()
    {
        Console.WriteLine("Trepa...");
    }
}


//Herencia con contructores personalisados
class Vehiculo 
{
    private string tipoVehiculo;

    public Vehiculo(string tipoVehiculo)
    {
        this.tipoVehiculo = tipoVehiculo;
    }
}

//clase hijo 
class Automovil : Vehiculo 
{

    public Automovil(string tipoVehiculo):base(tipoVehiculo){
        Console.WriteLine("Inicializando un Automovil");
    }
    //los argumentos de la clase base de deben pasar por el contructor de la clase hija
    //despues con ":base()" pasamos los argumentos que las clase padre requiera 
}