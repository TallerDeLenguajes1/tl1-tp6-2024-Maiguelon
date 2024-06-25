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
// int repetir = 1;

// while (repetir == 1)
// {
//     // Pregunto si quiere usar la primera calculadora o la segunda
//     Console.WriteLine("\nDesea realizar operaciones de un numero o de dos?(1 o 2):");
//     string tipoCalculadora = Console.ReadLine();
//     if (int.TryParse(tipoCalculadora, out int eleccion) && 0 < eleccion && eleccion < 3)
//     {
//         // -- Calculadora 1 --
//         if (eleccion == 2)
//         {
//             // Pido que introduzcan dos enteros
//             Console.WriteLine("\nIntroduzca el primer entero: ");
//             string numero1 = Console.ReadLine();
//             Console.WriteLine("\nIntroduzca el segundo entero: ");
//             string numero2 = Console.ReadLine();

//             // Compruebo si lo introducido son enteros, si lo son, creo variables de tipo entero con los datos
//             if (int.TryParse(numero1, out int num1) && int.TryParse(numero2, out int num2))
//             {
//                 // Pido que introduzca el tipo de operacion que quiere realizar:
//                 Console.WriteLine("\nQue operacion desea realizar?\n1-Suma\n2-Resta\n3-Multiplicacion\n4:Division\n");
//                 string operation = Console.ReadLine();

//                 // Compruebo que el numero de operacion sea entero
//                 if (int.TryParse(operation, out int operacion) && 0 < operacion && operacion < 5)
//                 {

//                     // Hago un switch con las operaciones
//                     switch (operacion)
//                     {
//                         case 1:
//                             Console.WriteLine($"\nSuma: {num1} + {num2} = {num1 + num2}\n");
//                             break;
//                         case 2:
//                             Console.WriteLine($"\nResta: {num1} - {num2} = {num1 - num2}\n");
//                             break;
//                         case 3:
//                             Console.WriteLine($"\nMultiplicacion: {num1} * {num2} = {(double)num1 * num2}\n");
//                             break;
//                         case 4:
//                             if (num2 == 0)
//                             {
//                                 Console.WriteLine("\nNo se puede dividir por 0\n");
//                             }
//                             else
//                             {
//                                 Console.WriteLine($"\nDivision: {num1} / {num2} = {num1 / num2}\n");
//                             }
//                             break;
//                     }
//                     // Determinar el mayor y el menor de los números
//                     Console.WriteLine($"El numero mayor entre {num1} y {num2} es {Math.Max(num1, num2)}");
//                     Console.WriteLine($"El numero menor entre {num1} y {num2} es: {Math.Min(num1, num2)}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("\n----El dato introducido no es una operacion valida----\n");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("\n----Nao nao, esos no son enteros----\n");
//             }

//         // -- Calculadora 2--
//         } else if (eleccion == 1) {
//             // Pido que se introduzca un numero
//             Console.WriteLine("\nIntroduzca el numero: ");
//             string numeral1 = Console.ReadLine();

//             // Compruebo si lo introducido es un entero, si es asi, creo una variable con el dato
//             if (float.TryParse(numeral1, out float nume1)) {
//                 Console.WriteLine("\nQue operacion desea realizar?\n1-Valor absoluto\n2-Cuadrado\n3-Raiz cuadrada\n4-Seno\n5-Coseno\n6-Parte entera de un decimal\nIntroduzca el numero de la operacion deseada: ");
//                 string determinante = Console.ReadLine();
//                 if (int.TryParse(determinante, out int opereta) && 0 < opereta && opereta < 7) {

//                     // Hago un Switch con las operaciones
//                     switch(opereta) {
//                     case 1:
//                         Console.WriteLine($"\nValor absoluto de {nume1}: {Math.Abs(nume1)}");
//                     break;
//                     case 2:
//                         Console.WriteLine($"\nCuadrado de {nume1}: {Math.Pow(nume1, 2)}");
//                     break;
//                     case 3:
//                         if (nume1 < 0) {
//                             Console.WriteLine("\nNo existen raices cuadradas de numeros negativos en los Reales\n");
//                         } else {
//                             Console.WriteLine($"\nRaiz cuadrada de {nume1}: {Math.Sqrt(nume1)}");
//                         }
//                     break;
//                     case 4:
//                         Console.WriteLine($"\nSeno de {nume1}: {Math.Sin(nume1)}");
//                     break;
//                     case 5:
//                         Console.WriteLine($"\nCoseno de {nume1}: {Math.Cos(nume1)}");
//                     break;
//                     case 6:
//                         Console.WriteLine($"\nParte entera de {nume1}: {Math.Truncate(nume1)}");
//                     break;
//                 }
//                 } else {
//                     Console.WriteLine("El dato introducido no corresponde con una operacion disponible");
//                 }


//             } else {
//                 Console.WriteLine("El dato introducido no es un entero");
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine("\n---El dato introducido no es valido (1 o 2)---\n");
//     }

//     // Consulto si desea realizar otra operacion
//     Console.WriteLine("Desea realizar otra operacion? (1 = si, 0 = no)\n");
//     string answer = Console.ReadLine();
//     int.TryParse(answer, out int respuesta);
//     repetir = respuesta;
// }

// --- Ejercicio 4 ---

// Pido que ingrese una oracion, le asigno variable y determino longitud
using System.Diagnostics.Contracts;

Console.WriteLine("\n---Ingrese una oracion---\n");
string oracion1 = Console.ReadLine();

int largo = oracion1.Length;
Console.WriteLine($"\nLongitud de la frase ingresada: {largo}\n");

// Solicito segunda cadena y concateno a la primera

Console.WriteLine("\n---Ingrese otra oracion---\n");
string oracion2 = Console.ReadLine();

string concatenada = string.Concat(oracion1, " ", oracion2);
Console.WriteLine($"\nLa nueva frase concatenada es:\n ---{concatenada}---\n");

// Saco una sub-cadena y la escribo

string subfrase = concatenada.Substring(0, 3); // escribe desde la posición 0 a la 3
Console.WriteLine($"\n\tSub frase: {subfrase}\n");

// --- Calculadora ---

// int repetir = 1;

// while (repetir == 1)
// {
//     // Pido que introduzcan dos enteros
//     Console.WriteLine("\nIntroduzca el primer entero: ");
//     string numero1 = Console.ReadLine();
//     Console.WriteLine("\nIntroduzca el segundo entero: ");
//     string numero2 = Console.ReadLine();

//     // Compruebo si lo introducido son enteros, si lo son, creo variables de tipo entero con los datos
//     if (int.TryParse(numero1, out int num1) && int.TryParse(numero2, out int num2))
//     {
//         // Pido que introduzca el tipo de operacion que quiere realizar:
//         Console.WriteLine("\nQue operacion desea realizar?\n1-Suma\n2-Resta\n3-Multiplicacion\n4-Division\n");
//         string operation = Console.ReadLine();

//         // Compruebo que el numero de operacion sea entero
//         if (int.TryParse(operation, out int operacion) && 0 < operacion && operacion < 5)
//         {
//             // Hago un switch con las operaciones
//             switch (operacion)
//             {
//                 case 1:
//                     int suma = num1 + num2;
//                     Console.WriteLine($"\nLa suma de {num1.ToString()} y de {num2.ToString()} es igual a: {suma.ToString()}\n");
//                     break;
//                 case 2:
//                     int resta = num1 - num2;
//                     Console.WriteLine($"\nLa resta de {num1.ToString()} y de {num2.ToString()} es igual a: {resta.ToString()}\n");
//                     break;
//                 case 3:
//                     double multiplicacion = (double)num1 * num2;
//                     Console.WriteLine($"\nLa multiplicación de {num1.ToString()} y de {num2.ToString()} es igual a: {multiplicacion.ToString()}\n");
//                     break;
//                 case 4:
//                     if (num2 == 0)
//                     {
//                         Console.WriteLine("\nNo se puede dividir por 0\n");
//                     }
//                     else
//                     {
//                         double division = (double)num1 / num2;
//                         Console.WriteLine($"\nLa división de {num1.ToString()} y de {num2.ToString()} es igual a: {division.ToString()}\n");
//                     }
//                     break;
//             }
//             // Determinar el mayor y el menor de los números
//             Console.WriteLine($"El numero mayor entre {num1} y {num2} es {Math.Max(num1, num2).ToString()}");
//             Console.WriteLine($"El numero menor entre {num1} y {num2} es {Math.Min(num1, num2).ToString()}");
//         }
//         else
//         {
//             Console.WriteLine("\n----El dato introducido no es una operacion valida----\n");
//         }
//     }
//     else
//     {
//         Console.WriteLine("\n----Nao nao, esos no son enteros----\n");
//     }

//     // Consulto si desea realizar otra operacion
//     Console.WriteLine("Desea realizar otra operacion? (1 = si, 0 = no)\n");
//     string answer = Console.ReadLine();
//     int.TryParse(answer, out int respuesta);
//     repetir = respuesta;
// }

// Volviendo a la cadena, la imprimo caracter por caracter

// Console.WriteLine($"\n\t-Cadena caracter por caracter-\n");
// foreach (char caracter in concatenada)
// {
//     Console.WriteLine($"{caracter}");
// }

// Pido que el usuario ingrese una cadena y chequeo si está dentro

Console.WriteLine($"\nIngrese una palabra que quiera checkear dentro de la cadena\n");
string palabraAverificar = Console.ReadLine();

if (concatenada.Contains(palabraAverificar))
{
    Console.WriteLine("\n--La palabra ingresada esta dentro de la frase--\n");
}
else
{
    Console.WriteLine("\n--La palabra ingresada NO esta dentro de la frase--\n");
}

// Convierto la cadena a mayúsculas y luego a minúsculas

string mayusculas = concatenada.ToUpper();
Console.WriteLine($"\n---Cadena en Mayusculas---\n{mayusculas}\n");

string minusculas = concatenada.ToLower();
Console.WriteLine($"\n---Cadena en minúsculas---\n{minusculas}");

// Pido al usuario que ingrese una cadena y un separador

Console.WriteLine("\nIngrese una frase:\n");
string cadena = Console.ReadLine();

Console.WriteLine("\nIngrese un carácter separador: ");
string separador = Console.ReadLine();

// Verificar que el usuario haya ingresado un único carácter como separador
if (separador.Length == 1)
{
    char caracterSeparador = separador[0];

    // Dividir la cadena usando el carácter separador
    string[] partes = cadena.Split(caracterSeparador);

    // Mostrar los resultados por pantalla
    Console.WriteLine("\nLa cadena dividida es:");
    foreach (string parte in partes)
    {
        Console.WriteLine(parte);
    }
}
else
{
    Console.WriteLine("\n!!Un caracter separador nada mas!!");
}

// Operacion simple ingresando solo texto

Console.WriteLine("\n--Ingrese una operacion simple(+,-,*,/)--\nEj:(24+12)\n");
string operacion = Console.ReadLine();

// Extraigo el operador

string[] numeros = operacion.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);

// Determino el operador

string operador = new string(operacion.Except(numeros[0]).Except(numeros[1]).ToArray()).Trim();

// realizo los controles de numero y realizo la operacion

if (int.TryParse(numeros[0], out int numeral1))
{
    if (int.TryParse(numeros[1], out int numeral2))
    {
        switch (operador)
        {
            case "+":
                Console.WriteLine($"\n{numeral1} + {numeral2} = {numeral1 + numeral2}");
                break;
            case "-":
                Console.WriteLine($"\n{numeral1} - {numeral2} = {numeral1 - numeral2}");
                break;
            case "*":
                Console.WriteLine($"\n{numeral1} * {numeral2} = {numeral1 * numeral2}");
                break;
            case "/":
                if (numeral2 != 0)
                {
                    Console.WriteLine($"\n{numeral1} / {numeral2} = {numeral1 / numeral2}");
                }
                else
                {
                    Console.WriteLine("\nNo se puede dividir por cero.");
                }
                break;

        }
    }
    else
    {
        Console.WriteLine("\nIngresaste un no entero");
    }
}
else
{
    Console.WriteLine("\nIngresaste un no entero");
}