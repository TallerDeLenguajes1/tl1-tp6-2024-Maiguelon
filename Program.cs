// See https://aka.ms/new-console-template for more information
/*

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b); 

*/

// --- Ejercicio 1 ---

// Console.WriteLine("Introduzca un number");
// string number = Console.ReadLine();

// if (int.TryParse(number, out int numero))
// {
//     int inverso = 0;
//     while (numero > 0)
//     {
//         int digito = numero % 10;
//         numero /= 10;
//         inverso = inverso * 10 + digito;
//     }

//     Console.WriteLine($"\nNumero invertido: {inverso}\n");

// }
// else
// {
//     Console.WriteLine("Eso no es un numero >:|");
// }

// --- Ejercicio 2 ---

// Bandera para repetir la calculadora
int repetir = 1;

while (repetir == 1)
{
    // Pregunto si quiere usar la primera calculadora o la segunda
    Console.WriteLine("\nDesea realizar operaciones de un numero o de dos?(1 o 2):");
    string tipoCalculadora = Console.ReadLine();
    if (int.TryParse(tipoCalculadora, out int eleccion) && 0 < eleccion && eleccion < 3)
    {
        // -- Calculadora 1 --
        if (eleccion == 2)
        {
            // Pido que introduzcan dos enteros
            Console.WriteLine("\nIntroduzca el primer entero: ");
            string numero1 = Console.ReadLine();
            Console.WriteLine("\nIntroduzca el segundo entero: ");
            string numero2 = Console.ReadLine();

            // Compruebo si lo introducido son enteros, si lo son, creo variables de tipo entero con los datos
            if (int.TryParse(numero1, out int num1) && int.TryParse(numero2, out int num2))
            {
                // Pido que introduzca el tipo de operacion que quiere realizar:
                Console.WriteLine("\nQue operacion desea realizar?\n1-Suma\n2-Resta\n3-Multiplicacion\n4:Division\n");
                string operation = Console.ReadLine();

                // Compruebo que el numero de operacion sea entero
                if (int.TryParse(operation, out int operacion) && 0 < operacion && operacion < 5)
                {

                    // Hago un switch con las operaciones
                    switch (operacion)
                    {
                        case 1:
                            Console.WriteLine($"\nSuma: {num1} + {num2} = {num1 + num2}\n");
                            break;
                        case 2:
                            Console.WriteLine($"\nResta: {num1} - {num2} = {num1 - num2}\n");
                            break;
                        case 3:
                            Console.WriteLine($"\nMultiplicacion: {num1} * {num2} = {(double)num1 * num2}\n");
                            break;
                        case 4:
                            if (num2 == 0)
                            {
                                Console.WriteLine("\nNo se puede dividir por 0\n");
                            }
                            else
                            {
                                Console.WriteLine($"\nDivision: {num1} / {num2} = {num1 / num2}\n");
                            }
                            break;
                    }
                    // Determinar el mayor y el menor de los números
                    Console.WriteLine($"El numero mayor entre {num1} y {num2} es {Math.Max(num1, num2)}");
                    Console.WriteLine($"El numero menor entre {num1} y {num2} es: {Math.Min(num1, num2)}");
                }
                else
                {
                    Console.WriteLine("\n----El dato introducido no es una operacion valida----\n");
                }
            }
            else
            {
                Console.WriteLine("\n----Nao nao, esos no son enteros----\n");
            }

        // -- Calculadora 2--
        } else if (eleccion == 1) {
            // Pido que se introduzca un numero
            Console.WriteLine("\nIntroduzca el numero: ");
            string numeral1 = Console.ReadLine();

            // Compruebo si lo introducido es un entero, si es asi, creo una variable con el dato
            if (float.TryParse(numeral1, out float nume1)) {
                Console.WriteLine("\nQue operacion desea realizar?\n1-Valor absoluto\n2-Cuadrado\n3-Raiz cuadrada\n4-Seno\n5-Coseno\n6-Parte entera de un decimal\nIntroduzca el numero de la operacion deseada: ");
                string determinante = Console.ReadLine();
                if (int.TryParse(determinante, out int opereta) && 0 < opereta && opereta < 7) {

                    // Hago un Switch con las operaciones
                    switch(opereta) {
                    case 1:
                        Console.WriteLine($"\nValor absoluto de {nume1}: {Math.Abs(nume1)}");
                    break;
                    case 2:
                        Console.WriteLine($"\nCuadrado de {nume1}: {Math.Pow(nume1, 2)}");
                    break;
                    case 3:
                        if (nume1 < 0) {
                            Console.WriteLine("\nNo existen raices cuadradas de numeros negativos en los Reales\n");
                        } else {
                            Console.WriteLine($"\nRaiz cuadrada de {nume1}: {Math.Sqrt(nume1)}");
                        }
                    break;
                    case 4:
                        Console.WriteLine($"\nSeno de {nume1}: {Math.Sin(nume1)}");
                    break;
                    case 5:
                        Console.WriteLine($"\nCoseno de {nume1}: {Math.Cos(nume1)}");
                    break;
                    case 6:
                        Console.WriteLine($"\nParte entera de {nume1}: {Math.Truncate(nume1)}");
                    break;
                }
                } else {
                    Console.WriteLine("El dato introducido no corresponde con una operacion disponible");
                }

                            
            } else {
                Console.WriteLine("El dato introducido no es un entero");
            }
        }
    }
    else
    {
        Console.WriteLine("\n---El dato introducido no es valido (1 o 2)---\n");
    }

    // Consulto si desea realizar otra operacion
    Console.WriteLine("Desea realizar otra operacion? (1 = si, 0 = no)\n");
    string answer = Console.ReadLine();
    int.TryParse(answer, out int respuesta);
    repetir = respuesta;
}