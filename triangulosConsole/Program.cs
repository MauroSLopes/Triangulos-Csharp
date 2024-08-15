using triangulosConsole;

int trianguloOpcao = 5;

Triangulos tri = new Triangulos();

Console.Clear();

do
{
    Console.WriteLine("Digite a opção desejada:\n" +
        "1 - Triangulo lateral de largura t e altura 2t-1.\n" +
        "2 - Triangulo altura t e largura 2t-1.\n" +
        "3 - Triangulo Retangulo.");
    trianguloOpcao = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    switch (trianguloOpcao)
    {
        case 1:
            tri.calcularEqui();
            break;
        case 2:
            tri.calcularDiferente();
            break;
        case 3:
            tri.calcularRet();
            break;
        default:
            Console.WriteLine("Até breve");
            trianguloOpcao = 0;
            break;
    }
    Console.ReadLine();
} while (trianguloOpcao != 0);