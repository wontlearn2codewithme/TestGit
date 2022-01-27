using System;
using System.Collections.Generic;
using System.Text;

namespace TestGit.Clases
{
    class Circulo
    {
        private float radio;

        public Circulo(float radio)
        {
            this.Radio = radio;
        }

        protected float Radio { get => radio; set => radio = value; }

        public float Area_Circulo (float radio)
        {
            return radio * (float)3.14;
        }


    }
}
