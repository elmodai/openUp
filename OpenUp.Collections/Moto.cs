namespace OpenUp.Collections
{
    public class Moto : Veiculo, IVeiculoTerrestre
    {
        public string Mover()
        {
            return "Movimento em terra com" + Rodas.Count().ToString() + "rodas." ;
        }
    }
}