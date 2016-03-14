namespace Specifications.Validation
{
    public class ErroValidacao
    {
        public TipoMensagem TipoMensagem { get; set; }
        public string Mensagem { get; set; }

        public ErroValidacao(string mensagem, TipoMensagem tipoMensagem = TipoMensagem.ErroGeral)
        {
            this.Mensagem = mensagem;
            this.TipoMensagem = tipoMensagem;
        }
    }

    public enum TipoMensagem : int
    {
        Sucesso = 0,
        NaoExiste = 1,
        ErroNegocio = 2,
        ErroSistema = 4,
        ErroBenner = 8,
        ErroSharePoint = 16,
        ErroGeral = 32,
        Informacao = 64,
    }
}