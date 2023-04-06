namespace Triangulo.ConsoleApp
{
    class Triangulo
    {
        public int LadoA;
        public int LadoB;
        public int LadoC;

        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            this.LadoA = ladoA;
            this.LadoB = ladoB;
            this.LadoC = ladoC;
        }

        public string VerificarTriangulo()
        {
            if (LadoA < LadoB + LadoC && LadoB < LadoA + LadoC && LadoC < LadoA + LadoB)
            {
                if (LadoA == LadoB && LadoB == LadoC)
                {
                    return "Equilátero";
                }
                else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
                {
                    return "Isósceles";
                }
                else
                {
                    return "Escaleno";
                }
            }
            else
            {
                return "Não é um triângulo";
            }
        }
    }
}