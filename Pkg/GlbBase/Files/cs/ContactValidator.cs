using System;
using Terrasoft.Core.Factories;

namespace GlbBase
{
    [DefaultBinding(typeof(IEntityValidator), Name = "Contact")]
    public class ContactValidator : IEntityValidator
    {
        public virtual bool Validate(Guid recordId)
        {
            return true;
        }
    }
}
