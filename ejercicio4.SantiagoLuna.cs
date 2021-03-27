using System;

namespace ejercicio4
{
   public class Program
    {
        public static void Main(string[] args)
        {
             
            string dato = "";
           int edad = 0;
            int ActividadPerro = 0;
            double peso = 0.0;
			int edadperro = 0;
            int tamaño = 0;
			int opcion = 0;
            
            
            
            do{
                
                Console.WriteLine("Sea bienvenido al programa ideal para saber cuanto debe comer su perro");
                
                 Console.WriteLine("¿Tiene un perro adulto o cachorro?");
				 Console.WriteLine("1 - Cachorro");
                Console.WriteLine("2 - Adulto");
                dato = Console.ReadLine();
                edadperro = Convert.ToInt32(dato);
				
			
				switch (edadperro) {
                        case 1:
						         Console.WriteLine("¿De qué tamaño es su perro?:");
						Console.WriteLine("1=Miniatura");
                            Console.WriteLine("2=Pequeño");
                            Console.WriteLine("3=Mediano");
						    Console.WriteLine("4=Grande");
                dato = Console.ReadLine();
                tamaño =Convert.ToInt32(dato);
						
						switch (tamaño) {
                        case 1:
                           Console.WriteLine("¿Cuantos meses tiene su perro (A partir de 2)?");
						    Console.WriteLine("2");
                            Console.WriteLine("3");
                            Console.WriteLine("4");
						    Console.WriteLine("5");
                            Console.WriteLine("6-12");
						    dato = Console.ReadLine();
                           edad =  Convert.ToInt32(dato);
								
								   switch (edad) {
                        case 1:
                            Console.WriteLine("Su cachorro debe comer 50 gramos .");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debe comer  60 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer 60 gramos.");
                            break;
				           case 4:
                            Console.WriteLine("Su cachorro debe comer 60 gramos.");
                            break;
						    case 5:
                            Console.WriteLine("Su cachorro debe comer 55 gramos.");
                            break;
								   }
                        break;
								   
                        case 2:
                           Console.WriteLine("¿Cuantos meses tiene su perro (A partir de 2)?");
						    Console.WriteLine("2");
                            Console.WriteLine("3");
                            Console.WriteLine("4");
						    Console.WriteLine("5");
                            Console.WriteLine("6-12");
						    dato = Console.ReadLine();
                           edad =  Convert.ToInt32(dato);
								
								switch (edad) {
                        case 1:
                            Console.WriteLine("Su cachorro debe comer entre 95 y 155 gramos .");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debe comer entre 110 y 185 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer entre 115 y 195 gramos.");
                            break;
				           case 4:
                            Console.WriteLine("Su cachorro debe comer entre 115 y 190 gramos.");
                            break;
						    case 5:
                            Console.WriteLine("Su cachorro debe comer entre 110 y 185 gramos.");
                            break;
								   }
						
                            break;
                        case 3:
                            Console.WriteLine("¿Cuantos meses tiene su perro (A partir de 2)?");
						    Console.WriteLine("2");
                            Console.WriteLine("3");
                            Console.WriteLine("4");
						    Console.WriteLine("5");
                            Console.WriteLine("6-12");
						    dato = Console.ReadLine();
                           edad =  Convert.ToInt32(dato);
								
										switch (edad) {
                        case 1:
                            Console.WriteLine("Su cachorro debe comer entre 215-355 gramos.");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debe comer entre 265-475 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer entre 285-525 gramos.");
                            break;
				           case 4:
                            Console.WriteLine("Su cachorro debe comer entre 285-530 gramos.");
                            break;
						    case 5:
                            Console.WriteLine("Su cachorro debe comer entre 280-530 gramos.");
                            break;
								   }
						
                            break;
								
						    case 4:
                            Console.WriteLine("¿Cuantos meses tiene su perro (A partir de 2)?");
						    Console.WriteLine("2");
                            Console.WriteLine("3");
                            Console.WriteLine("4");
						    Console.WriteLine("5");
                            Console.WriteLine("6-12");
						    dato = Console.ReadLine();
                           edad =  Convert.ToInt32(dato);
						
								switch (edad) {
                        case 1:
                            Console.WriteLine("Su cachorro debe comer entre 405 - 580 gramos .");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debe comer entre 545 - 670 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debe comer entre 610 - 685 gramos.");
                            break;
				           case 4:
                            Console.WriteLine("Su cachorro debe comer aproximadamente 625 gramos.");
                            break;
						    case 5:
                            Console.WriteLine("Su cachorro debe comer eaproximadamente 650 gramos.");
                            break;
								   }
                            break;
                    }
				
                            
                            break;
                        case 2:
                           Console.WriteLine("¿Cuánto pesa su perro?:");
                dato = Console.ReadLine();
                peso = Convert.ToDouble(dato);
				
                
                Console.WriteLine("¿Es su perro de actividad alta, normal o baja?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                dato = Console.ReadLine();
                ActividadPerro = Convert.ToInt32(dato);
                
                
                //Miniatura
                if(peso <= 5 && peso >= 2) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 60 - 115 gramos.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 55 - 100 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 45 - 85 gramos.");
                            break;
                    }
                    
                }
				
				 //Pequeño
                if(peso <= 10 && peso >= 6) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 115 - 190 gramos.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 100- 170 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 85 - 145 gramos.");
                            break;
                    }
                    
                }
				 //Mediano
                if(peso <= 15 && peso >= 11) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 190 - 255 gramos.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 170 - 225 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 145 y 195 gramos.");
                            break;
                    }
                    
                }
				
				 //Grande1
                if(peso <= 25 && peso >= 16) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 255 - 380 gramos.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 225 - 330 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 195 - 285 gramos.");
                            break;
                    }
                    
                }
                //Grande2
				 if(peso <= 40 && peso >= 26) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 380 - 535 gramos.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 330 - 475 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 285 - 410 gramos.");
                            break;
                    }
                    
                }
                //Grande3
				 if(peso <= 55 && peso >= 41) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 535 - 680 gramos.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 475 - 600 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 410 - 520 gramos.");
                            break;
                    }
                    
                }
				//Grande4
				 if(peso <= 70 && peso >= 56) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 680 - 820 gramos.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 600 - 720 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 520 - 620 gramos.");
                            break;
                    }
                    
                }
				//Grande5
				 if(peso <= 90 && peso >= 71) 
                {
                    
                    switch (ActividadPerro) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 820 - 985 gramos.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 720 - 870 gramos.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 620 - 750 gramos.");
                            break;
                    }
                    
                }
		
                            break;
		     }
               
             Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);
                
                Console.Clear();
                
                
            }while(opcion != 4);
              Console.WriteLine("¡Gracias por utilizar nuestro programa!");          
        
            
            
        }
    }
}