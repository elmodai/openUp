using static System.Console;

namespace OpenUp.Extensibility
{
    public class VIH : AVirus, ISexualmenteTransmissivel, ITransmissivel
    {
        public int EscalaVirus;


        string ITransmissivel.Transmitir()
        {
            return "A transmitir VIH...";
        }
    }
}