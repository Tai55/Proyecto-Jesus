using System;

namespace PROYECTO_CONSOLA
{
    class Program
    {
        static void Main(string[] args) //void main es el comienzo - método
        {
            //public string mensajedesalida (ger; set;)
            MiPrimeraClase objetoMiPrimeraClase = new MiPrimeraClase(); //creamos la instancia 
            objetoMiPrimeraClase.variable1 = Console.ReadLine();//.mensajedesalida = "hola mora"
            objetoMiPrimeraClase.Ejecutar(); //al estar en public podemos utilizar el ejecutar
            //ES LA ACCION
        
        }
    }
}
