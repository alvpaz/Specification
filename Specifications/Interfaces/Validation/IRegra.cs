using Specifications.Validation;

namespace Specifications.Interfaces.Validation
{
    public interface IRegra<in TEntity>
    {
        string MensagemErro { get; }
        TipoMensagem TipoMensagem { get; }
        bool Validar(TEntity entity);
    }
}
