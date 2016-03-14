namespace Specifications.Test
{
    public class CursoRepository
    {
        public string ObterPorDescricao(string descricao)
        {
            //simular que encontrou o valor
            return descricao.Contains("Encontrou") ? "sim" : null;
        }
    }
}