using System;
using System.Collections.Generic;
using System.Text;

namespace TestGit.Clases
{
    class Triangulo
    {
        private int base_figura;
        private int altura;

        protected int Base_figura { get => base_figura; set => base_figura = value; }
        protected int Altura { get => altura; set => altura = value; }

        public Triangulo(int base_figura, int altura)
        {
            this.Base_figura = base_figura;
            this.Altura = altura;
        }

       
    }
}
