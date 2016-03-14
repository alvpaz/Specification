using Specifications.Test.Specifications;
using Specifications.Validation;

namespace Specifications.Test.Validations
{
    public class CursoEstaConsistente : Validador<Curso>
    {
        public CursoEstaConsistente(CursoRepository cursoRepository)
        {
            var cursoDescricaoUnica = new DescricaoDeveSerUnicaSpec(cursoRepository);

            base.AdicionarRegra("DescricaoJaCadastrada",new Regra<Curso>(cursoDescricaoUnica, "Este curso já foi cadastrado na base de dados",TipoMensagem.ErroNegocio));
        }
    }
}
