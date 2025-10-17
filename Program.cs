Console.Clear();

string senhaDigitada;
string senhaCorreta = "Senha123";

Console.Write("Digite a senha: ");
senhaDigitada = Console.ReadLine()!;
bool acessoPermitido = senhaDigitada == senhaCorreta;
if (acessoPermitido)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Acesso Permitido");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Acesso Negado");
}

Console.ResetColor();
