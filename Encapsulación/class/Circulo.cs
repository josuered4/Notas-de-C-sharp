namespace Encapsulacion;

class Circulo
{
    private const double pi = 3.1416;
    //por defecto las propiedades de clases son private,
    //pero es mejor declarlas con el private, para legivilidad 

    //Las constates publicas solo sirven para leerse. 

    public double CalculoArea(int Radio)
    {
        return pi * (Radio * Radio);
    }

}

class ConversorDolaresPesos
{
    private double dolar = 18.60;
    //Dado a que el dolar cambia, seria buena idea poner 
    //el valor en public para cambiar el valor cuando se 
    //requiere, pero no tendremos control sobre los cambios 
    //asi que no seria combeniente, por ende lo encapsulamos.


    //Cuando encapsulamos una propiedad, debemos crear metodos
    //para poder modificarlos desde adontro de la clase, estas 
    //funciones se les conoce como metodos de acceso y son publicas 
    //estos metodos son utiles para agregar restricciones al valor de 
    //las propiedades y tambien de preferencia no retornan nada 
    public void ChangeDolar(double value) 
    {
        //no es un metodo de acceso, pero hace la misma funcion, como ejemplo 
        this.dolar = value;
    }

    public double convert(double cantidad)
    {
        return cantidad * dolar;
;
    } 
}