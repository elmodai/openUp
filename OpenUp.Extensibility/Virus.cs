namespace OpenUp.Extensibility
{
    public abstract class Virus
    {
        public string Nome { get; set; }

        public HashSet<string> Causas { get; set; }

        public HashSet<string> Sintomas { get; set; }
    }
}