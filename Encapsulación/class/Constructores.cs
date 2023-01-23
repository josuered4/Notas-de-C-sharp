namespace Encapsulacion;

class Coche
{
    //Creamos las propiedades de la clase y las encapsulamos 
    private int ruedas;
    private double largo;
    private double ancho;
    private bool climatizador;
    private string tapiceria;

    //Creamos el contructor 
    //Es un metodo especial que tiene el mismo nombre de la clase 
    //NO RETORNA NADA Y TAMPOCO ES VOID.
    //Dede se ser publica 
    public Coche(double largo, double ancho, bool climatizador, string tapiceria)
    {
        this.ruedas = 4;
        this.largo = largo;
        this.ancho = ancho;
        this.climatizador = climatizador;
        this.tapiceria = tapiceria;
        //this hace referencia al objeto instaciado, 
        //tambien es utilizados para acceder al valor
        //de las propiedades y difereneciarlas a los 
        //argumentos de funciones 
    }

    //Metodos de acceso 

    //Metodo Get:
        // Metodo publico que retorna el valor de una propiedad y solo deberia
        // servir para eso, debe comenzar con getNamePropiety y de preferencia 
        // sin parametros 
    public int getRuedas(){
        return this.ruedas;
    }
        // se invoca => object.getRuedas()


    //este es un tipo de get pero personalizado 
    public string getData()
    { 
        return "Informacion de la instancia ";
        //podriamos meter toda la data 
    }

}