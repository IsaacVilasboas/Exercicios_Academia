namespace Atv12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Carlos", "20", "15478");
            aluno.Apresentar();
            Professor professor = new Professor("João Cleber", "35", "C#");
            professor.Apresentar();
        }
    }
}