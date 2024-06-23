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

int repetir = 1;

while (repetir == 1)
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
        if (int.TryParse(operation, out int operacion) && 0 < operacion && operacion < 5) {

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
                if (num2 == 0) {
                    Console.WriteLine("\nNo se puede dividir por 0\n");
                } else {
                Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}\n");
                }
                break;
            }

        } else {
            Console.WriteLine("\n----El dato introducido no es una operacion valida----\n");
        }


    } else {
        Console.WriteLine("\n----Nao nao, esos no son enteros----\n");
    }

    // Consulto si desea realizar otra operacion
    Console.WriteLine("Desea realizar otra operacion? (1 = si, 0 = no)\n");
    string answer = Console.ReadLine();
    int.TryParse(answer, out int respuesta);
    repetir = respuesta;
}