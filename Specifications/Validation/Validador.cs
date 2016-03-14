using System.Collections.Generic;
using Specifications.Interfaces.Validation;


namespace Specifications.Validation
{
    public abstract class Validador<TEntity> : IValidador<TEntity> where TEntity : class
    {
        private readonly Dictionary<string, IRegra<TEntity>> _validations = new Dictionary<string, IRegra<TEntity>>();

        public virtual ResultadoValidacao Validar(TEntity entity)
        {
            ResultadoValidacao validationResult = new ResultadoValidacao();
            foreach (string index in this._validations.Keys)
            {
                IRegra<TEntity> rule = this._validations[index];
                if (!rule.Validar(entity))
                    validationResult.AdicionarErro(new ErroValidacao(rule.MensagemErro,rule.TipoMensagem));
            }
            return validationResult;
        }

        protected virtual void AdicionarRegra(string name, IRegra<TEntity> rule)
        {
            this._validations.Add(name, rule);
        }

        protected virtual void RemoverRegra(string name)
        {
            this._validations.Remove(name);
        }

        protected IRegra<TEntity> ObterRegra(string name)
        {
            IRegra<TEntity> rule;
            this._validations.TryGetValue(name, out rule);
            return rule;
        }
    }
}