using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class CalculadoraBien
{
    
    
    public static void Suma (int num1, int num2)
    {
        int result;
        result = num1 + num2;
        Console.Write ("El resultado es: "+ result);
        
    }
    
    public static void Resta (int num1, int num2)
    {
        int result;
        result = num1 - num2;
        Console.WriteLine ("El resultado es: " +result);
        
    }
    
    public static void Multiplicación (int num1, int num2)
    {
        int result;
        result = num1 * num2;
        Console.WriteLine ("El resultado es: "+result); 
        
    }
    public static void Division (int num1, int num2)
    {
        int result;
        result = num1/ num2;
        Console.WriteLine("El resultado es: "+ result);
        
    }
}
