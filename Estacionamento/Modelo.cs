public class Modelo
{

    private Marca _marca;
    private string _descricaoModelo;

    public Marca Marca{
        get => _marca;
        set => _marca = value;
    }

    public string DescricaoModelo 
    {
        get => _descricaoModelo;
        set => _descricaoModelo = value;
    }

    public Modelo()
    {
        _marca = null;
        _descricaoModelo = string.Empty;
    }

    public Modelo(Marca marca, string descricaoModelo)
    {
        _marca = marca;
        _descricaoModelo = descricaoModelo;
    }

    public override string ToString()
    {
       return _marca.Nome + " | " + _descricaoModelo;
    }

}