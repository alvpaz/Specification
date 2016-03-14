using Specifications.Interfaces.Validation;

namespace Specifications.Validation
{
    public class Regra<TEntity> : IRegra<TEntity>
    {
        private readonly ISpecification<TEntity> _specificationSpec;
        public string MensagemErro { get; private set; }
        public TipoMensagem TipoMensagem { get; private set; }

        public Regra(ISpecification<TEntity> regra, string mensagemErro, TipoMensagem tipoMensagem = TipoMensagem.ErroGeral)
        {
            this._specificationSpec = regra;
            this.MensagemErro = mensagemErro;
            this.TipoMensagem = tipoMensagem;
        }
    
        public bool Validar(TEntity entity)
        {
            return this._specificationSpec.IsSatisfiedBy(entity);
        }
    }
}