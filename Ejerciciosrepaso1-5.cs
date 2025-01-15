using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

public class Program
{
    public static void Main(string[] args)
    {
        //"A veces pienso en tirar la toalla, pero luego... ¿con qué me seco?"
    }

    public static void Ejercicio1(int segundos)
    {
        int horas = 0, minutos = 0, i = segundos;
        if (segundos >= 3600)
        {
            do
            {
                horas++;
                segundos = segundos - 3600;

            } while (segundos >= 3600);
        }
        if (segundos >= 60)
        {
            do
            {
                minutos++;
                segundos = segundos - 60;

            } while (segundos >= 60);
        }
        Console.WriteLine(horas + " Hora " + minutos + " minutos " + segundos + " segundos ");
    }


    public static bool Ejercicio2TrianguloValido(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    public static double Ejercicio2CalcularArea(double a, double b, double c)
    {
        double x = (a + b + c) / 2;
        //x corresponde al semiperimetro
        double areaPreRaiz = x * (x - a) * (x - b) * (x - c);
        double areaFinal = Math.Sqrt(areaPreRaiz);
        return areaFinal;
    }


    public static double Ejercicio3(double temperatura)
    {
        double fahrenheit = ((temperatura * (9.0 / 5.0)) + 32);
        return fahrenheit;
    }


    public static double Ejercicio4(double temperatura)
    {
        double kelvin = temperatura + 273.15;
        return kelvin;
    }

    public static double Ejercicio5(double temperatura)
    {
        double celsius = temperatura - 273.15;
        double fahrenheit = Ejercicio3(celsius);
        return fahrenheit;
    }
}
