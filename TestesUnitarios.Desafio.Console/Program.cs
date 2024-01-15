


using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista vLista = new ValidacoesLista();

var lista = new List<int> { 2, 4, 6, -2, -5 };
var listaSemNegativos = vLista.RemoverNumerosNegativos(lista);

var contemNumero = vLista.ListaContemDeterminadoNumero(lista,6);

var multiplica = vLista.MultiplicarNumerosLista(lista, 2);

var retornaMaior = vLista.RetornarMaiorNumeroLista(lista);
var retornaMenor = vLista.RetornarMenorNumeroLista(lista);

Console.WriteLine($"Essa é a Lsita original {string.Join(", ", lista)}");
Console.WriteLine($"Essa é a lista retirando os negativos {string.Join(",",listaSemNegativos)}");
Console.WriteLine($"Contém número procurado? -{contemNumero}");
Console.WriteLine($"Multiplicar número lista -{string.Join(",",multiplica)}");
Console.WriteLine($"Retorna Maior -{string.Join(",",retornaMaior)}");
Console.WriteLine($"Retorna Menor -{string.Join(",",retornaMenor)}");