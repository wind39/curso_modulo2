using System;

namespace Lista1Exercicio04
{
    public class Ponto3D
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Ponto3D()
        {
        }

        public Ponto3D(int p_x, int p_y, int p_z)
        {
            this.x = p_x;
            this.y = p_y;
            this.z = p_z;
        }

        public void Mostrar()
        {
            Console.WriteLine("({0},{1},{2})", this.x, this.y, this.z);
        }

        public void MoverPara(int p_x, int p_y, int p_z)
        {
            this.x = p_x;
            this.y = p_y;
            this.z = p_z;
        }

        public double Distancia(Ponto3D p2)
        {
            return Math.Sqrt(((p2.x - this.x) * (p2.x - this.x)) + ((p2.y - this.y) * (p2.y - this.y)) + ((p2.z - this.z) * (p2.z - this.z)));
        }
    }
}

