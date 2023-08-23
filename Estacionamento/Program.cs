class Program
{
    static void Main(string[] args)
    {

        Carro carro= new();
        
        /*
        carro.Placa = "ABC-1234";
        carro.Descricao = "FIAT Argo";
        carro.CorExterna = Carro.Cor.Branca;
        carro.Mostrar(); */


        carro.Placa = "ABC-1234";
        carro.Descricao = "FIAT Argo";
        carro.CorExterna = Carro.Cor.Branca;
        carro.NmroPortas = 5;
        carro.Mostrar();

    }
}
