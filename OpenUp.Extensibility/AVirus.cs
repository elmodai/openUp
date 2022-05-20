using static System.Console;

namespace OpenUp.Extensibility
{ 
    public abstract class AVirus
    {
        public string Nome; 

        public AgenteInfeccioso AgenteInfeccioso { get; set; } 

        public HashSet<string> Sintomass { get; set; } 

        public Tratamento Tratamento { get; set; }

    }
}
