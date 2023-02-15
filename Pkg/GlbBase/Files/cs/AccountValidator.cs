using System;
using Terrasoft.Core.Factories;

namespace GlbBase
{
    [DefaultBinding(typeof(IEntityValidator), Name = "Account")]
    public class AccountValidator : IEntityValidator
    {
        public virtual bool Validate(Guid recordId)
        {
            return true;
        }
    }
}
