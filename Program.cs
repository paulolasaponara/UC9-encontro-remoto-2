using UC9_encontro_remoto_2.classes;

// imprimi no console o hello world
// Console.WriteLine("Hello, World!");

//para instanciar precisa dizer qual tipo e depois o nome do objeto = MetodoConstrutor();
//instanciamos um objeto do tipo pessoa fisica, estamos criando um objeto

PessoaFisica novaPessoaFisica = new PessoaFisica();

//atribuimos um valor para as propriedades

novaPessoaFisica.Nome = "Lorenzo";
novaPessoaFisica.Cpf = "12345678910";
novaPessoaFisica.DataNascimento = new DateTime(2017,10,19);
novaPessoaFisica.Rendimento = 50000.50f;

// Console.WriteLine(novaPessoaFisica.Nome);
// Console.WriteLine(novaPessoaFisica.Cpf);
// Console.WriteLine(novaPessoaFisica.DataNascimento);
// Console.WriteLine(novaPessoaFisica.Rendimento);

//imprimimos no console os valores dos objetos com a concatenaçao

// System.Console.WriteLine("Nome: " + novaPessoaFisica.Nome);
// System.Console.WriteLine("CPF: " + novaPessoaFisica.Cpf);
// System.Console.WriteLine("Data de Nascimento: " + novaPessoaFisica.DataNascimento);
// System.Console.WriteLine("Rendimento: $ " + novaPessoaFisica.Rendimento);

//imprimimos no console os valores dos objetos com a interpolaçao

// System.Console.WriteLine($"Nome: {novaPessoaFisica.Nome}");
// System.Console.WriteLine($"CPF: {novaPessoaFisica.Cpf}");
// System.Console.WriteLine($"Data de Nascimento: {novaPessoaFisica.DataNascimento}");
// System.Console.WriteLine($"Rendimento: $ {novaPessoaFisica.Rendimento}");

//imprimimos no console os valores dos objetos com a interpolaçao com quebra de linhas

Console.WriteLine(@$"
Nome: {novaPessoaFisica.Nome}
CPF: {novaPessoaFisica.Cpf}
Data de Nascimento: {novaPessoaFisica.DataNascimento}
Rendimento: ${novaPessoaFisica.Rendimento}
");


//instancido um objeto do tipo pessoa juridica

PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

novaPessoaJuridica.Nome = "Palmeiras";
novaPessoaJuridica.RazaoSocial = "S.E.Palmeiras";
novaPessoaJuridica.Cnpj = "22658312000177";
novaPessoaJuridica.Rendimento = 250000.99f;

Console.WriteLine(@$"
Nome Fantasia: {novaPessoaJuridica.Nome}
Razão Social: {novaPessoaJuridica.RazaoSocial}
CNPJ: {novaPessoaJuridica.Cnpj}
Rendimento Mensal: ${novaPessoaJuridica.Rendimento}
");

