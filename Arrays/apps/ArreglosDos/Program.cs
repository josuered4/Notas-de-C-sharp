class ArreglosDos
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ProcesarDatos(new int[]{0,1,2,3,4,5});
        foreach(var i in CreateArray())
        {
            Console.WriteLine($"Elemento: {i}");
        }
    }

    static void ProcesarDatos(int[] datos)
    {
        foreach (var item in datos)
        {
            Console.WriteLine(item);
        }
    }
 
    static int[] CreateArray()
    {
        Console.WriteLine("Cuantos elementos tendra el array");
        int Num = int.Parse(Console.ReadLine());
        int[] Array = new int[Num];
        for(int i=0; i< Num; i++)
        {
            Console.WriteLine($"Introduce el datos de la posicion {i}");
            Array[i] = int.Parse(Console.ReadLine());
        }

        return Array;
    }
}
