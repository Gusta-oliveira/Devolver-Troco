internal class Program
{
    private static void Main(string[] args)
    {
        int v_conta, v_pago, troco, aux_troco;

        Console.WriteLine("Valor da conta: ");
        v_conta = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor pago: ");
        v_pago = int.Parse(Console.ReadLine());

        troco = v_pago - v_conta;
        Console.WriteLine("O troco a ser dado é: {0}", troco);

        if (troco >= 100)
        {
            Console.WriteLine("Dê 1 nota de CEM");
            troco = troco - 100;
        }
        if (troco >= 50)
        {
            Console.WriteLine("Dê 1 nota de CINQUENTA");
            troco = troco - 50;
        }
        if (troco >= 20)
        {
            aux_troco = troco / 20;
            Console.WriteLine("Dê {0} nota de VINTE", aux_troco);
            troco = troco - aux_troco * 20;
        }
        if (troco >= 10)
        {
            Console.WriteLine("Dê 1 nota de DEZ");
            troco = troco - 10;
        }
        if (troco >= 5)
        {
            Console.WriteLine("Dê 1 nota de CINCO");
            troco = troco - 5;
        }
        if (troco >= 2)
        {

            Console.WriteLine("Dê " + troco / 2 + " nota de DOIS");
            troco = 0;
        }
    }
}