using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect: MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)  //Attribute lara tipleri böyle atıyoruz.
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))  //Eğer kullanıcının verdiği validatorType bir IValidator degilse ona bu uyarıyı ver.
            {
                throw new System.Exception("Bu bir dogrulama sinifi degil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
