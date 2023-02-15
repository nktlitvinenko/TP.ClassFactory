using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Terrasoft.Core.Factories;
using Terrasoft.Web.Common;

namespace GlbBase
{
    #region Class: ValidationService

    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class ValidationService : BaseService
    {
        #region Methods: Public

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public ValidationServiceResponse Validate(ValidationServiceRequest request)
        {
            #region ClassFactory.Bind
            //ClassFactory.Bind<IEntityValidator, ContactValidator>("Contact");
            //ClassFactory.Bind<IEntityValidator, AccountValidator>("Account");
            #endregion

            #region ClassFactory.ReBind
            //ClassFactory.ReBind<IEntityValidator, AccountValidator>("Contact");
            #endregion

            var response = new ValidationServiceResponse();

            var instance = ClassFactory.Get<ValidationServiceHelper>(
                new ConstructorArgument("userConnection", UserConnection));
            response.IsSuccess = instance.Validate(request.EntitySchemaName, request.RecordId);

            return response;
        }

        #endregion
    }

    #endregion

    #region Class: ValidationServiceRequest

    [DataContract]
    public class ValidationServiceRequest
    {
        [DataMember(Name = "recordId")]
        public Guid RecordId { get; set; }

        [DataMember(Name = "entitySchemaName")]
        public string EntitySchemaName { get; set; }
    }

    #endregion

    #region Class: ValidationServiceResponse

    [DataContract]
    public class ValidationServiceResponse
    {
        [DataMember(Name = "isSuccess")]
        public bool IsSuccess { get; set; }
    }

    #endregion
}
