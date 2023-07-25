using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {

        }


    }

    //ejercicio para encontrar u obtener mensajes, codigos de errores, usando indexOf, substring
    public static class stringExpresion
    {
        /*
         * 
         //var log = "[INFO]: File Deleted.";

            //Console.WriteLine(log.SubstringAfter(": "));

            var log2 = "SOMETHING\", \"FIND >>> SOMETHING <===< HERE";

            Console.WriteLine(log2.SubstringBetween(">>> ", " <===<")); // => returns "INFO"

            //var log3 = "[ERROR]: Missing ; on line 20.";
            //Console.WriteLine(log3.Message()); // => returns "Missing ; on line 20."
            //var log4 = "[ERROR]: Missing ; on line 20.";
            //Console.WriteLine(log4.LogLevel()); // => returns "ERROR"
            //Console.ReadLine();
         */

        public static string SubstringAfter(this string result, string delimiter)
        {

            return result.Substring(result.IndexOf(delimiter) + delimiter.Length);

        }
        public static string SubstringBetween(this string result, string delimiter, string delimiter2)
        {

            string ar1 = result.SubstringAfter(delimiter);

            result = ar1.Substring(0, ar1.IndexOf(delimiter2));
            return result;
        }

        public static string Message(this string result)
        {
            return result.SubstringAfter(": ");

        }

        public static string LogLevel(this string result)
        {
            return result.SubstringBetween("[", "]");

        }
    }

    //ejercicio tuplas
    public static class PhoneNumber
    {
        /*instrucciones       
        En este ejercicio tienes que analizar números de teléfono.
        Se le pide que implemente 2 funciones.
        Se garantiza que los números de teléfono pasados a las rutinas  
        tienen la forma NNN-NNN-NNNN, por ejemplo 212-515-9876 y no son nulos.
        --------------
        Indicación de si el número tiene un prefijo de Nueva York, es decir, 212 en las 3 primeras cifras.
        Indicación de si el número es falso y tiene el prefijo 555 en las posiciones 5 a 7 (numeración a partir del 1).
        Las 4 últimas cifras del número.
         */
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {

            Console.WriteLine(PhoneNumber.Analyze("631-555-1234"));
            // => (false, true, "1234")

            Console.WriteLine(PhoneNumber.IsFake(PhoneNumber.Analyze("631-555-1234")));
            // => true



            bool IsNewYork = false, IsFake = false;
            string[] listaElementos = phoneNumber.Split('-');
            if (phoneNumber.Length == 12 && !string.IsNullOrWhiteSpace(phoneNumber))
            {
                IsNewYork = listaElementos.First() == "212";
                IsFake = listaElementos[listaElementos.Length / 2] == "555";
                phoneNumber = listaElementos.Last();
            }
            return (IsNewYork, IsFake, phoneNumber);

        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            bool IsFake = phoneNumberInfo.IsFake;
            return IsFake;
        }

    }
}
