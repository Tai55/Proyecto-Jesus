using   System;
public class MiPrimeraClase
    {
        public string variable1 { get; set; }
        
        public void Ejecutar() //si es public se puede ver desde la clase superior, si es privada no.
        {
            Console.WriteLine ("Escriba la primera variable"); //console.writeline(this.mensajedesalida)
            String variable1;
            variable1 = Console.ReadLine();
            Console.WriteLine ("El texto introducido es:" + this.variable1);// se puede utilizar el this, pero no es obligatorio

            Console.WriteLine ("Escriba la segunda variable");
            String variable2;
            variable2 = Console.ReadLine();
            Console.WriteLine ("El texto introducido es:" + variable2);
    

            string.Equals(variable1,variable2); 
            //bool resultado = mensajeDesalida1.equals(mensajeDeSalida);

            
            bool resultado = string.Equals(variable1,variable2); 
            Console.WriteLine(resultado.ToString()); //no hace falta poner el ToString porque coge bool
           // Console.WriteLine(string.Equals(variable1,variable2));
           Console.ReadLine();

           //Console.WriteLine(this.)
        }
            
    }//fin método