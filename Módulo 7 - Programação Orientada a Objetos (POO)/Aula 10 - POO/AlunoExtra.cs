namespace aula10
{
    class AlunoExtra
    {
        public string Nome { get; set; }
        public double Nota { get; set; }

        public void Aprovacao()
        {
            if (Nota >= 7)
            {
                Console.WriteLine($"{Nota} - Aprovado ");
            }
            else
            {
                Console.WriteLine($"{Nota} - Reprovado ");
            }
        }
    }
}
