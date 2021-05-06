using System;

namespace primera_prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Prueba de Console.Write
            Console.Write("Instituto Superior de Profesorado Nº 20! ");
            Console.Write("Hello World!");
            */
            /*Segunda prueba: Construir una calculadora por consola
            que reciba por parámetros 2 números, los sume e imprima 
            resultado.
            if(args.Length>0){
                 Console.WriteLine("Este es el primer parámetro:"+args[0]);
            }
            if(args.Length>1){
                Console.WriteLine("Este es el segundo parámetro:"+args[1]);
            }*/  
            //Tercera prueba: Construir una calculadora que reciba 3 parámetros
            // 2 números y un tercer parámetro que indique la operación a realizar
            // por ejemplo: calculadora 4 por 5    
            decimal resultado;
            if(args.Length==3){
                try {
                    switch (args[1])
                    {
                        case "+":
                            resultado=Convert.ToInt32(args[0])+Convert.ToInt32(args[2]);
                            Console.WriteLine("El resultado de la suma es:"+resultado);
                            break;
                        case "-":
                            resultado=Convert.ToInt32(args[0])-Convert.ToInt32(args[2]);
                            Console.WriteLine("El resultado de la resta es:"+resultado);
                            break;
                        case "*":
                            resultado=Convert.ToInt32(args[0])*Convert.ToInt32(args[2]);
                            Console.WriteLine("El resultado de la multiplicación es:"+resultado);
                            break;
                        case "/":
                            resultado=Convert.ToDecimal(args[0])/Convert.ToDecimal(args[2]);
                            Console.WriteLine("El resultado de la división es:"+Decimal.Round(resultado,2));
                            break;
                        default:
                            Console.WriteLine("el segundo parámetro debe indicar la operación matemática a realizar \nlas palabras habilitadas son \"mas, menos, por, dividido\"");
                            break;

                    }     
                    /*if (args[1]=="mas"){
                        int resultado=Convert.ToInt32(args[0])+Convert.ToInt32(args[2]);
                        Console.WriteLine("El resultado de la suma es:"+resultado);
                    } else if (args[1]=="menos"){
                        int resultado=Convert.ToInt32(args[0])-Convert.ToInt32(args[2]);
                        Console.WriteLine("El resultado de la resta es:"+resultado);
                    } else if (args[1]=="por"){
                        int resultado=Convert.ToInt32(args[0])*Convert.ToInt32(args[2]);
                        Console.WriteLine("El resultado de la multiplicación es:"+resultado);
                    } else if (args[1]=="dividido"){
                        decimal resultado=Convert.ToDecimal(args[0])/Convert.ToDecimal(args[2]);
                        Console.WriteLine("El resultado de la división es:"+Decimal.Round(resultado,2));
                    } else{
                        Console.WriteLine("el segundo parámetro debe indicar la operación matemática a realizar \nlas palabras habilitadas son \"mas, menos, por, dividido\"");
                    }   */ 
                }catch{
                    Console.WriteLine("la operación de conversión de argumentos a números a fallado, controle los argumentos que proporciona ");
                }              
            }else{
                Console.WriteLine("Para el correcto funcionamiento de la calculadora debe suministrar 3 argumentos \nse recibieron "+args.Length+" argumentos");
            }      
           
        }
    }
}
