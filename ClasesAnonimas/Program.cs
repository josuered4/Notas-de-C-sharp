namespace ClaseAnonimas;

class Program
{
    static void Main(string[] args)
    {
        //Declaracion de clases anonimas 
        var miClaseAnonima = new {Nombre = "Josue", Edad = 19 };
        var miSegundaClaseAnonima = new {Nombre = "Isaac", Edad = 19 };
        var miSegundaClaseAnonima = new {Nombre = "Isaac", Edad = "19", Peso = 2 };

        //son como los objetos en js
        //El compilador sabe que tipo de clase es 
        //Si dos instancias tienen la mismo tipo, cantida y orden de campos, el compilador
        //  los asignara del mismo tipo.
        //Si son del mismo tipo puede reasignarse entre si.
        //miClaseAnonima = miSegundaClaseAnonima

        //Restrecciones.
        //Solo puede tener campos publico 
        //Todos los campos deben ser inicializados 
        //Sin campos staticos
        //Sin metodos 

        Console.WriteLine("HOla");
    }
}