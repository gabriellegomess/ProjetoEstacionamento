class Program
{
    static void Main(string[] args)
    {
        Veiculo veiculo = new(
            corExterna: Veiculo.Cor.Branca,
            descricao: "Veiculo X",
            placa: "ERF123",
            modelo: new(new("Fiat"), ("Argo")));

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");
        Console.WriteLine();

        Marca ma = new("FIAT");
        Modelo mo = new(ma, "Argo");

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");
        Console.WriteLine();

        Veiculo v1 = new("ABC1478", mo, "Veiculo X", Veiculo.Cor.Branca);

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");
        Console.WriteLine();
        
        Carro carro = new("ABC-123", new(new("FIAT"), "ARGO"), "Carro X", Veiculo.Cor.Amarela, 5);
        carro.Mostrar();

        Console.WriteLine();
        Console.WriteLine("━━━━━━◇◆◇━━━━━━");
        Console.WriteLine();

        Moto moto = new("BCD-321", new(new("HONDA"), "SEI LA"), "Kawasaki Ninja", Veiculo.Cor.Verde, false);
        moto.Mostrar();

    }
}
