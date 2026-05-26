namespace Aula15
{
    public class Retangulo : IFormaGeometrica
    {
        public double Largura { get; private set; }
        public double Altura { get; private set; }
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public double CalcularArea()
        {
            return Largura * Altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
