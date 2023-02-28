using desafio;

Produto carne = new Produto();
carne.nome = "Carne";
carne.fabricante = "Sadia";
carne.codigoDeBarra = "X10983L2";
carne.valorUnitario = 3.20;
carne.valorCompra = 19.99;
carne.estoque = 49;

Console.WriteLine("Estoque de carnes: " + carne.estoque);