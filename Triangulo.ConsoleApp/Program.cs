namespace Triangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA = 7;
            int ladoB = 7;
            int ladoC = 7;

            Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);
            string resultado = triangulo.VerificarTriangulo();

            Console.WriteLine($"\nO triângulo é: {resultado}");

            Console.ReadKey();
        }
    }
}