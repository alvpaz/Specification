using Specifications.Interfaces.Validation;

namespace Specifications.Test.Specifications
{
    public class DescricaoEstaValidaSpec : ISpecification<Curso>
    {
        public bool IsSatisfiedBy(Curso curso)
        {
            if (!string.IsNullOrEmpty(curso.Descricao))
            {
                return curso.Descricao.Length > 5 && curso.Descricao.Length < 50;
            }
            return false;
        }
    }
}
