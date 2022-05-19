using static System.Console;

namespace OpenUp.Extensibility
{
    public abstract class Virus
    {
        public string Nome; 

        public HashSet<string> Causas { get; set; } // se eliminamos o virus entao os sintomas tambem vao 

        public HashSet<string> Sintomass { get; set; } //sdfd

        void Transmissao()
        {
            WriteLine($"{Nome}");
        }
    }
}