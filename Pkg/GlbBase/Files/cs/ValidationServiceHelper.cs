using System;
using Terrasoft.Core;
using Terrasoft.Core.Factories;

namespace GlbBase
{
    public class ValidationServiceHelper
    {
        private UserConnection _userConnection;

        public ValidationServiceHelper(UserConnection userConnection)
        {
            _userConnection = userConnection;
        }

        public virtual bool Validate(string entitySchemaName, Guid recordId)
        {
            var instance = ClassFactory.Get<IEntityValidator>(entitySchemaName);
            return instance.Validate(recordId);
        }
    }
}
