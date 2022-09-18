namespace UC9_encontro_remoto_2.classes
{
    //classe pessoa juridica herda da superclasse
    public class PessoaJuridica : Pessoa
    {
        //atributos da classe pessoa juridica
        public string? RazaoSocial { get; set; }
        public string? Cnpj { get; set; }
    }
}