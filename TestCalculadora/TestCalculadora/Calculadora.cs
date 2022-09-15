using System;
using System.Collections.Generic;
using System.Text;

namespace TestCalculadora
{
    public static class Calculadora
    {
        public static int Suma(int item1, int item2)
        {
            return item1 + item2;
        }

        public static int Resta(int item1, int item2)
        {
            return item1 - item2;
        }

        public static int Multipliacion(int item1, int item2)
        {
            return item1 * item2;
        }
        public static double Division(int item1, int item2)
        {
            return item1 / item2;
        }
    }
}
