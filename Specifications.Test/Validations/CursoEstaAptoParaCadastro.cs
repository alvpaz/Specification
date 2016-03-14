using Specifications.Test.Specifications;
using Specifications.Validation;

namespace Specifications.Test.Validations
{
    public class CursoEstaAptoParaCadastro : Validador<Curso>
    {
        public CursoEstaAptoParaCadastro()
        {
            //Especificações de Curso
            var cursoDescricao = new DescricaoEstaValidaSpec();
            var cursoAtivo = new CursoEstaAtivoValidaSpec();
            base.AdicionarRegra("DescricaoInvalida", new Regra<Curso>(cursoDescricao, "A descrição deve conter entre 5 e 50 caracteres"));
            base.AdicionarRegra("SomenteCursoAtivo", new Regra<Curso>(cursoAtivo, "O Curso não está ativo"));
        }
    }
}
