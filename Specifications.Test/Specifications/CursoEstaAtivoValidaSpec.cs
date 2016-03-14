using Specifications.Interfaces.Validation;

namespace Specifications.Test.Specifications
{
    public class CursoEstaAtivoValidaSpec : ISpecification<Curso>
    {
        public bool IsSatisfiedBy(Curso curso)
        {
            return curso.Ativo;
        }
    }
}
