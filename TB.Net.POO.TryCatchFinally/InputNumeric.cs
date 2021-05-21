using System;
using System.Collections.Generic;
using System.Text;

namespace TB.Net.POO.TryCatchFinally
{
    public static class InputNumeric
    {
        public static double Input(string numericValue)
        {
            if (numericValue == null) throw new ArgumentNullException();
            if (numericValue == "") throw new ArgumentException("L'entrée texte est vide");
            double result = 0;
            bool beginDecimal = false;
            for (int i = 0; i < numericValue.Length; i++)
            {
                if (numericValue[i] != '0'
                    && numericValue[i] != '1'
                    && numericValue[i] != '2'
                    && numericValue[i] != '3'
                    && numericValue[i] != '4'
                    && numericValue[i] != '5'
                    && numericValue[i] != '6'
                    && numericValue[i] != '7'
                    && numericValue[i] != '8'
                    && numericValue[i] != '9'
                    && numericValue[i] != '.') throw new FormatException("Un caractère n'est pas valide");
                if(!beginDecimal) result *= 10;
                switch (numericValue[i])
                {
                    case '1': result += (beginDecimal)?1/10:1;  break;
                    case '2': result += (beginDecimal)?2/10:2;  break;
                    case '3': result += (beginDecimal)?3/10:3;  break;
                    case '4': result += (beginDecimal)?4/10:4;  break;
                    case '5': result += (beginDecimal)?5/10:5;  break;
                    case '6': result += (beginDecimal)?6/10:6;  break;
                    case '7': result += (beginDecimal)?7/10:7;  break;
                    case '8': result += (beginDecimal)?8/10:8;  break;
                    case '9': result += (beginDecimal)?9/10:9;  break;
                    case '.': if (beginDecimal) 
                            throw new FormatException("Deux virgules dans votre nombre"); 
                        beginDecimal = true; 
                        break;
                    default:
                        throw new FormatException("Caractère inconnu");
                        break;
                }
            }
            return result;
        }
    }
}
