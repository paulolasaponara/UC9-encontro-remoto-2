namespace UC9_encontro_remoto_2.classes
{
    //classe pessoa fisica que herda da superclasse Pessoa
    public class PessoaFisica : Pessoa
    {
        //atributos da classe pessoa fisica
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}