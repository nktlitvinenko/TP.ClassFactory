using System;
using Terrasoft.Core;
using Terrasoft.Core.Factories;

namespace GlbBase
{
    //[Override]
    public class OverridedValidationServiceHelper : ValidationServiceHelper
    {
        public OverridedValidationServiceHelper(UserConnection userConnection) : base(userConnection) { }

        public override bool Validate(string entitySchemaName, Guid recordId)
        {
            return false;
        }
    }
}
