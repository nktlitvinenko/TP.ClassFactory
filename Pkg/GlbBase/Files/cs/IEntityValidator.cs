using System;

namespace GlbBase
{
    public interface IEntityValidator
    {
        bool Validate(Guid recordId);
    }
}
