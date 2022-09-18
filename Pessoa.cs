namespace UC9_encontro_remoto_2.classes
{
    //classe pessoa é a superclasse
    public abstract class Pessoa
    {
        //atributos da classe pessoa
       public string? Nome { get; set; }
       public string? Endereço { get; set; }
       public float Rendimento { get; set; }
    }
}

//metodos acessores
//get : leitura
//set : editar
//por padrão esses metodos acessores vem como publicos, conforme a necessidade colocamos privado
