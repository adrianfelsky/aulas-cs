namespace aula11
{
    class Aluno
    {
        public string Nome;
        public int Idade;
        public float Nota;
        public void VerificarSituacao()
        {
            Console.Write($"{Nome} - {Idade}: {Nota} -> ");
            if (Nota >= 7) Console.WriteLine("Aprovado.");
            else Console.WriteLine("Reprovado.");
        }
    }
}
