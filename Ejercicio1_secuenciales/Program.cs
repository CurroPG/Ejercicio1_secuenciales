using System;

namespace Ejercicios1_Secuenciales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();
            Ejercicio10();

            Console.ReadKey();
        }

        // 1. Suma, resta, multiplicación, división y módulo de dos números
        static void Ejercicio1()
        {
            Console.WriteLine("\n--- Ejercicio 1 ---");
            Console.WriteLine("Introduce el primer número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La suma es {numero1 + numero2}");
            Console.WriteLine($"La resta es: {numero1} - {numero2} = {numero1 - numero2}");
            Console.WriteLine($"La multiplicación es: {numero1 * numero2}");
            Console.WriteLine($"La división es: {numero1 / numero2}");
            Console.WriteLine($"El módulo es: {numero1 % numero2}");
        }

        // 2. Total a pagar en un bar con precios fijados en constantes
        static void Ejercicio2()
        {
            Console.WriteLine("\n--- Ejercicio 2 ---");
            const double PRECIO_HAMBURGUESA = 4.50;
            const double PRECIO_PAPAS = 1.75;
            const double PRECIO_BEBIDA = 1.50;

            Console.Write("Cantidad de hamburguesas: ");
            int hamburguesas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cantidad de papas: ");
            int papas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cantidad de bebidas: ");
            int bebidas = Convert.ToInt32(Console.ReadLine());

            double total = hamburguesas * PRECIO_HAMBURGUESA
                         + papas * PRECIO_PAPAS
                         + bebidas * PRECIO_BEBIDA;

            Console.WriteLine($"Cantidad a pagar: {total:F2}€");
        }

        // 3. Operaciones de la clase Math sobre un número
        static void Ejercicio3()
        {
            Console.WriteLine("\n--- Ejercicio 3 ---");
            Console.WriteLine("Introduce un número:");
            double numero = Convert.ToDouble(Console.ReadLine());
            double otro = 10;

            Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
            Console.WriteLine($"Potencia al cubo: {Math.Pow(numero, 3)}");
            Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
            Console.WriteLine($"Seno: {Math.Sin(numero)}");
            Console.WriteLine($"Coseno: {Math.Cos(numero)}");
            Console.WriteLine($"Máximo entre {numero} y {otro}: {Math.Max(numero, otro)}");
            Console.WriteLine($"Mínimo entre {numero} y {otro}: {Math.Min(numero, otro)}");
        }

        // 4. Perímetro de un cuadrado
        static void Ejercicio4()
        {
            Console.WriteLine("\n--- Ejercicio 4 ---");
            Console.WriteLine("Introduce el valor del lado del cuadrado:");
            double lado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"El perímetro del cuadrado es: {lado * 4}");
        }

        // 5. Suma de los dos primeros y producto del tercero y el cuarto
        static void Ejercicio5()
        {
            Console.WriteLine("\n--- Ejercicio 5 ---");
            Console.WriteLine("Introduce el primer número:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el cuarto número:");
            int n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"La suma de los dos primeros es: {n1 + n2}");
            Console.WriteLine($"El producto del tercero y el cuarto es: {n3 * n4}");
        }

        // 6. Suma y promedio de cuatro valores
        static void Ejercicio6()
        {
            Console.WriteLine("\n--- Ejercicio 6 ---");
            Console.WriteLine("Introduce el primer valor:");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el segundo valor:");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el tercer valor:");
            double v3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el cuarto valor:");
            double v4 = Convert.ToDouble(Console.ReadLine());

            double suma = v1 + v2 + v3 + v4;
            double promedio = suma / 4;

            Console.WriteLine($"La suma es: {suma}");
            Console.WriteLine($"El promedio es: {promedio:F2}");
        }

        // 7. Coste total a partir del precio y la cantidad
        static void Ejercicio7()
        {
            Console.WriteLine("\n--- Ejercicio 7 ---");
            Console.WriteLine("Introduce el precio del artículo:");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El coste total es: {precio * cantidad:F2}€");
        }

        // 8. Nota final de Desarrollo de Interfaces
        static void Ejercicio8()
        {
            Console.WriteLine("\n--- Ejercicio 8 ---");
            Console.WriteLine("Introduce la nota del primer parcial:");
            double parcial1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la nota del segundo parcial:");
            double parcial2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la nota del examen:");
            double examen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la nota del trabajo final:");
            double trabajo = Convert.ToDouble(Console.ReadLine());

            double promedioParciales = (parcial1 + parcial2) / 2;
            double notaFinal = promedioParciales * 0.5 + examen * 0.3 + trabajo * 0.2;

            Console.WriteLine($"Tu nota final es: {notaFinal:F2}");
        }

        // 9. Porcentaje de participación de cada socio
        static void Ejercicio9()
        {
            Console.WriteLine("\n--- Ejercicio 9 ---");
            Console.WriteLine("Introduce la aportación del socio 1:");
            double socio1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la aportación del socio 2:");
            double socio2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la aportación del socio 3:");
            double socio3 = Convert.ToDouble(Console.ReadLine());

            double total = socio1 + socio2 + socio3;
            double porcentaje1 = socio1 / total * 100;
            double porcentaje2 = socio2 / total * 100;
            double porcentaje3 = socio3 / total * 100;

            Console.WriteLine("El porcentaje del socio 1 es {0:F2}%, del socio 2 es {1:F2}% y del socio 3 es {2:F2}%",
                porcentaje1, porcentaje2, porcentaje3);
        }

        // 10. Comprobar si un texto empieza por "www"
        static void Ejercicio10()
        {
            Console.WriteLine("\n--- Ejercicio 10 ---");
            Console.WriteLine("Introduce una dirección:");
            string texto = Console.ReadLine();

            bool empiezaPorWww = texto.StartsWith("www");
            Console.WriteLine(empiezaPorWww);
        }
    }
}