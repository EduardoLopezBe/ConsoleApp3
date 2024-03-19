using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    internal class Circulo
    {
        private float radio;
        private float pi;

        public Circulo(float radio, float pi)
        {
            this.radio = radio;
            this.pi = pi;
        }

        public float AreaCirculo()
        {
            return pi * (radio * 2);
        }
    }
}