public class Veiculo
{
  //0,1,2,3 - vetor
    public enum Cor {Undefined, Amarela, Azul, Branca, Verde, Vermelha, Preta}
    protected string _placa;
    protected string _descricao;
    protected Cor _corExterna;
    
    public string Placa
    {
        get => _placa;
        set => _placa = value;
    }

    public string Descricao
    {
        get => _descricao;
        set => _descricao = value;
    }

    public Cor CorExterna
    {
        get => _corExterna;
        set => _corExterna = value; 
    }

    public virtual void Mostrar()
    {
        Console.WriteLine("Placa: " + _placa);
        Console.WriteLine("Descrição: " + _descricao);
        Console.WriteLine("Cor: " + _corExterna);
    }

}