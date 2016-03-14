using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Specifications.Test.Validations;
using Specifications.Validation;

namespace Specifications.Test
{
    [TestClass]
    public class TesteCurso
    {
        [TestMethod]
        public void Curso_Esta_Valido_Para_Cadastro()
        {
            Curso curso = new Curso(new Guid(), "123456", true);
            Assert.IsTrue(curso.IsValid);
        }

        [TestMethod]
        public void Curso_Nao_Esta_Valido_Para_Cadastro()
        {
            Curso curso = new Curso(new Guid(), "1234", true);
            Assert.IsFalse(curso.IsValid);
        }

        [TestMethod]
        public void Curso_Esta_Consistente()
        {
            ResultadoValidacao resultadoConsistencia = new ResultadoValidacao();
            var _cursoRepository = new CursoRepository();
            Curso curso = new Curso(new Guid(), "123456", true);
            if (curso.IsValid)
            {
                resultadoConsistencia = new CursoEstaConsistente(_cursoRepository).Validar(curso);
                Assert.IsTrue(resultadoConsistencia.IsValid);
                return;
            }
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void Curso_Nao_Esta_Consistente()
        {
            ResultadoValidacao resultadoConsistencia = new ResultadoValidacao();
            var _cursoRepository = new CursoRepository();
            Curso curso = new Curso(new Guid(), "Encontrou", true);
            if (curso.IsValid)
            {
                resultadoConsistencia = new CursoEstaConsistente(_cursoRepository).Validar(curso);
                Assert.IsFalse(resultadoConsistencia.IsValid);
                return;
            }
            Assert.IsTrue(true);
        }

    }
}
