namespace OpenUp.Extensibility
{
    public abstract class Virus
    {
        public string Nome { get; set; }

        public HashSet<string> Causas { get; set; } // se as causas sao eliminadas entao o virus nao existe mais

        public HashSet<string> Sintomas { get; set; } //
    }
}