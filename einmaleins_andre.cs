using System;

namespace Einmaleins
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hier werden generell die Zahlen definierts
            int one = 1;
            int two = 2;
            int three = 3;
            int four = 4;
            int five = 5;
            int six = 6;
            int seven = 7;
            int eight = 8;
            int nine = 9;
            int ten = 10;

            //Es wird eine Headline ausgegeben.
            Console.WriteLine("      " + one + " | " + two + " | " + three + " | " + four + " | " + five + " | " + six + " | " + seven + " | " + eight + " | " + nine + " | " + ten);
            //In der Schleife werden die jeweiligen Zeilen der Tafel definiert, dabei wird i bei 1 gestartet und immer höher gerechnet. In der privaten methode duplizieren, werden dann beide Werte dupliziert.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "er:  " + Duplizieren(one, i) + " | " + Duplizieren(two, i) + " | " + Duplizieren(three, i) + " | " + Duplizieren(four, i) + " | " + Duplizieren(five, i) + " | " + Duplizieren(six, i) + " | " + Duplizieren(seven, i) + " | " + Duplizieren(eight, i) + " | " + Duplizieren(nine, i) + " | " + Duplizieren(ten, i));
            }
        }


        private static int Duplizieren(int ersterWert, int zweiterWert)
        {
            return ersterWert * zweiterWert;
        }
    }
}
