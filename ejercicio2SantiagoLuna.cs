using System;
namespace ejercicio_2
{
public class Program
{

	public static void Main()
	{
		string cadena="";
		int edad=0;
		double altura=0.0;   
		
		
		Console.WriteLine("¡Bienvenido al parque de atracciones LunaPark!");
		Console.WriteLine("Por favor, ingresa tu edad");
		cadena = Console.ReadLine();
        edad = Convert.ToInt32(cadena);
		
		if(edad >= 21) 
		{
			Console.WriteLine("Disculpa, pero has excedido el lìmite de edad que admite el parque, de coniderarlo un error, por favor dirigirse a oficinas del parque");
		 }	
		else
		{
					
		    Console.WriteLine("Eres bienvenido a nuestras atracciones");
		    Console.WriteLine("Ingresa tu altura y se te dara una lista de atracciones a las que puedes subir");
		    cadena = Console.ReadLine();
            altura = Convert.ToDouble(cadena);
			if(altura<1.50)
		    {
		     Console.WriteLine("Puedes subir a lo carros chocones, la casa de espejos y los trampolines. ¡Que disfrutes!");
		    } 
			else
			{
				Console.WriteLine("Puedes subir a cualquier instalacion del parque. ¡Que disfrutes!");
				
			}
			
			Console.ReadKey();
		}
		 
		}
	}
}			