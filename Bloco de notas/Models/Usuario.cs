namespace Bloco_de_notas.Models {
    public class Usuario : EntidadeDominio{
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
