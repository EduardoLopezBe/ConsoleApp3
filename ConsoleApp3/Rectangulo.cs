﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Rectangulo
    {

        private float rBase;
        private float rAltura;

        public Rectangulo(float rBase, float rAltura)
        {
            this.rBase = rBase;
            this.rAltura = rAltura;
        }

        public float AreaRectangulo()
        {
            return rBase * rAltura;
        }
    }
}


