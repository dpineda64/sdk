/* 
 * Ory Kratos
 *
 * Welcome to the ORY Kratos HTTP API documentation!
 *
 * The version of the OpenAPI document: v0.5.2-alpha.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// Used to verify an out-of-band communication channel such as an email address or a phone number.  For more information head over to: https://www.ory.sh/docs/kratos/selfservice/flows/verify-email-account-activation
    /// </summary>
    [DataContract]
    public partial class KratosVerificationFlow :  IEquatable<KratosVerificationFlow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosVerificationFlow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosVerificationFlow() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosVerificationFlow" /> class.
        /// </summary>
        /// <param name="active">Active, if set, contains the registration method that is being used. It is initially not set..</param>
        /// <param name="expiresAt">ExpiresAt is the time (UTC) when the request expires. If the user still wishes to verify the address, a new request has to be initiated..</param>
        /// <param name="id">id.</param>
        /// <param name="issuedAt">IssuedAt is the time (UTC) when the request occurred..</param>
        /// <param name="messages">messages.</param>
        /// <param name="methods">Methods contains context for all account verification methods. If a registration request has been processed, but for example the password is incorrect, this will contain error messages. (required).</param>
        /// <param name="requestUrl">RequestURL is the initial URL that was requested from ORY Kratos. It can be used to forward information contained in the URL&#39;s path or query for example..</param>
        /// <param name="state">state (required).</param>
        /// <param name="type">The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;..</param>
        public KratosVerificationFlow(string active = default(string), DateTime expiresAt = default(DateTime), string id = default(string), DateTime issuedAt = default(DateTime), List<KratosMessage> messages = default(List<KratosMessage>), Dictionary<string, KratosVerificationFlowMethod> methods = default(Dictionary<string, KratosVerificationFlowMethod>), string requestUrl = default(string), string state = default(string), string type = default(string))
        {
            // to ensure "methods" is required (not null)
            this.Methods = methods ?? throw new ArgumentNullException("methods is a required property for KratosVerificationFlow and cannot be null");
            // to ensure "state" is required (not null)
            this.State = state ?? throw new ArgumentNullException("state is a required property for KratosVerificationFlow and cannot be null");
            this.Active = active;
            this.ExpiresAt = expiresAt;
            this.Id = id;
            this.IssuedAt = issuedAt;
            this.Messages = messages;
            this.RequestUrl = requestUrl;
            this.Type = type;
        }
        
        /// <summary>
        /// Active, if set, contains the registration method that is being used. It is initially not set.
        /// </summary>
        /// <value>Active, if set, contains the registration method that is being used. It is initially not set.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public string Active { get; set; }

        /// <summary>
        /// ExpiresAt is the time (UTC) when the request expires. If the user still wishes to verify the address, a new request has to be initiated.
        /// </summary>
        /// <value>ExpiresAt is the time (UTC) when the request expires. If the user still wishes to verify the address, a new request has to be initiated.</value>
        [DataMember(Name="expires_at", EmitDefaultValue=false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// IssuedAt is the time (UTC) when the request occurred.
        /// </summary>
        /// <value>IssuedAt is the time (UTC) when the request occurred.</value>
        [DataMember(Name="issued_at", EmitDefaultValue=false)]
        public DateTime IssuedAt { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<KratosMessage> Messages { get; set; }

        /// <summary>
        /// Methods contains context for all account verification methods. If a registration request has been processed, but for example the password is incorrect, this will contain error messages.
        /// </summary>
        /// <value>Methods contains context for all account verification methods. If a registration request has been processed, but for example the password is incorrect, this will contain error messages.</value>
        [DataMember(Name="methods", EmitDefaultValue=false)]
        public Dictionary<string, KratosVerificationFlowMethod> Methods { get; set; }

        /// <summary>
        /// RequestURL is the initial URL that was requested from ORY Kratos. It can be used to forward information contained in the URL&#39;s path or query for example.
        /// </summary>
        /// <value>RequestURL is the initial URL that was requested from ORY Kratos. It can be used to forward information contained in the URL&#39;s path or query for example.</value>
        [DataMember(Name="request_url", EmitDefaultValue=false)]
        public string RequestUrl { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.
        /// </summary>
        /// <value>The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosVerificationFlow {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Methods: ").Append(Methods).Append("\n");
            sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosVerificationFlow);
        }

        /// <summary>
        /// Returns true if KratosVerificationFlow instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosVerificationFlow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosVerificationFlow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IssuedAt == input.IssuedAt ||
                    (this.IssuedAt != null &&
                    this.IssuedAt.Equals(input.IssuedAt))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Methods == input.Methods ||
                    this.Methods != null &&
                    input.Methods != null &&
                    this.Methods.SequenceEqual(input.Methods)
                ) && 
                (
                    this.RequestUrl == input.RequestUrl ||
                    (this.RequestUrl != null &&
                    this.RequestUrl.Equals(input.RequestUrl))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IssuedAt != null)
                    hashCode = hashCode * 59 + this.IssuedAt.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Methods != null)
                    hashCode = hashCode * 59 + this.Methods.GetHashCode();
                if (this.RequestUrl != null)
                    hashCode = hashCode * 59 + this.RequestUrl.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
