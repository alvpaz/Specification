using Specifications.Test.Specifications;
using Specifications.Validation;

namespace Specifications.Test.Validations
{
    public class CursoEstaAptoParaAtualizacao : Validador<Curso>
    {
        public CursoEstaAptoParaAtualizacao()
        {
            var cursoDescricao = new DescricaoEstaValidaSpec();
            base.AdicionarRegra("DescricaoInvalida", new Regra<Curso>(cursoDescricao, "A descrição deve conter entre 5 e 50 caracteres"));
        }
    }
}
  
 