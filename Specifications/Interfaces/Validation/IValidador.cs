using Specifications.Validation;

namespace Specifications.Interfaces.Validation
{
    public interface IValidador<in TEntity>
    {
        ResultadoValidacao Validar(TEntity entity);
    }
}
