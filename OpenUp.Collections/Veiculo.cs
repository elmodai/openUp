using System.Collections.ObjectModel;

namespace OpenUp.Collections;

public abstract class Veiculo
{
    public string Nome { get; set; }

    public IEnumerable<Roda> Rodas { get; set; }
}
