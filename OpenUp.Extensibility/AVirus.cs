using static System.Console;

namespace OpenUp.Extensibility
{ 
    public abstract class AVirus
    {
        public string Nome; 

        public AgenteInfeccioso AgenteInfeccioso { get; set; } 

        public HashSet<Sintoma> Sintomas { get; set; } 

        public Tratamento PropriedadeTratamento { get; set; }

    }
}
