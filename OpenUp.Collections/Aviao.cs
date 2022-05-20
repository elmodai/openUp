namespace OpenUp.Collections
{
    public class Aviao : Veiculo, IVeiculoAereo
    {
        public string Mover()
        {
            return "Movimento no ar com" + Rodas.Count().ToString()  + "rodas." ;
        }
    }
}