using System.Security.Cryptography;

public class Veiculo
{
  //0,1,2,3 - vetor
    public enum Cor {Undefined, Amarela, Azul, Branca, Verde, Vermelha, Preta}
    protected string _placa;
    protected Modelo _modelo;
    protected string _descricao;
    protected Cor _corExterna;
    
    public string Placa
    {
        get => _placa;
        set => _placa = value;
    }

    public Modelo Modelo{
        get => _modelo;
        set => _modelo = value; 
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

    public Veiculo(string placa, Modelo modelo, string descricao, Cor corExterna)
    {
        _placa = placa;
        _modelo = modelo; 
        _descricao = descricao;
        _corExterna = corExterna;
    }

    public Veiculo()
    {
        _placa = string.Empty;
        _modelo = null;
        _descricao = string.Empty;
        _corExterna = Cor.Undefined;
    }
    
    public virtual void Mostrar()
    {
        Console.WriteLine("Placa: " + _placa);
        Console.WriteLine("Placa: " + _modelo);
        Console.WriteLine("Descrição: " + _descricao);
        Console.WriteLine("Cor: " + _corExterna);
    }

}