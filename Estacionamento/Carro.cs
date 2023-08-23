public class Carro : Veiculo
{

    private int _nmroPortas;

    public int NmroPortas
    {
        get => _nmroPortas;
        set => _nmroPortas = value;
    }

    public Carro()
    {
        _nmroPortas = 0;
    }

    public Carro( string placa, string descricao, Cor corExterna, int nmroPortas) : base(placa, descricao, corExterna)
    {
        _nmroPortas = nmroPortas;
    }
  
    public override void Mostrar()
    {
        Console.WriteLine("Placa: " + _placa);
        Console.WriteLine("Descrição: " + _descricao);
        Console.WriteLine("Cor: " + _corExterna);
        Console.WriteLine("Número de Portas: " + _nmroPortas);
    }

}