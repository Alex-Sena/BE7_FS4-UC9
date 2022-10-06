using BE7_FS4_UC9.Interfaces;

namespace BE7_FS4_UC9.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?name { get; set; }
        public Endereco ?endereco { get; set; }
        public float rendimento { get; set; }

        public abstract float PagarImposto(float reindimento);

        public void verificarPastaArquivo(string caminho)
        {
            string pasta = caminho.Split("/")[0];
            
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            } 

            if(!File.Exists(caminho)){
                File.Create(caminho);
            }
        }
        
    }
}