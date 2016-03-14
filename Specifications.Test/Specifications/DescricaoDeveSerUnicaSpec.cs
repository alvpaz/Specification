using Specifications.Interfaces.Validation;

namespace Specifications.Test.Specifications
{
    public class DescricaoDeveSerUnicaSpec : ISpecification<Curso>
    {
        //simulando IOC
        private readonly CursoRepository _cursoRepository;

        public DescricaoDeveSerUnicaSpec(CursoRepository cursoRepository)
        {
            this._cursoRepository = cursoRepository;
        }

        public bool IsSatisfiedBy(Curso curso)
        {
            return _cursoRepository.ObterPorDescricao(curso.Descricao) == null;
        }
    }
}
