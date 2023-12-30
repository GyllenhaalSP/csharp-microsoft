string[] pedidos = new string[] { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string pedido in pedidos)
{
    if (pedido.StartsWith("B"))
    {
        Console.WriteLine(pedido);
    }
}