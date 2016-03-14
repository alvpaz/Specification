using System;
using Specifications.Test.Validations;
using Specifications.Validation;

namespace Specifications.Test
{
    public class Curso  
    {
        protected Curso() { }

        public Guid CursoId { get; protected set; }
        public string Descricao { get; protected set; }
        public bool Ativo { get; protected set; }
        public DateTime DataCadastro { get; protected set; }
        public DateTime DataAtualizacao { get; protected set; }
        public ResultadoValidacao ResultadoValidacao { get; private set; }

        public bool IsValid
        {
            get { return ResultadoValidacao.IsValid; }
        }

        public Curso(string descricao, bool ativo)
        {
            CursoId = Guid.NewGuid();
            Descricao = descricao;
            Ativo = ativo;
            DataCadastro = DateTime.Now;
            DataAtualizacao = DateTime.Now;

            var fiscal = new CursoEstaAptoParaCadastro();
            ResultadoValidacao = fiscal.Validar(this);
        }

        public Curso(Guid id, string descricao, bool ativo)
        {
            CursoId = id;
            Descricao = descricao;
            Ativo = ativo;
            DataCadastro = DateTime.Now;
            DataAtualizacao = DateTime.Now;

            var fiscal = new CursoEstaAptoParaCadastro();
            ResultadoValidacao = fiscal.Validar(this);
        }

        public void AtualizarCurso(string descricao, bool ativo )
        {
            Descricao = descricao;
            Ativo = ativo;
            DataAtualizacao = DateTime.Now;

            var fiscal = new CursoEstaAptoParaAtualizacao();
            ResultadoValidacao = fiscal.Validar(this);
        }
    }
}
