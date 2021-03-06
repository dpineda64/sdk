/* 
 * Ory Kratos
 *
 * Welcome to the ORY Kratos HTTP API documentation!
 *
 * The version of the OpenAPI document: v0.5.4-alpha.1
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
    /// KratosRevokeSession
    /// </summary>
    [DataContract]
    public partial class KratosRevokeSession :  IEquatable<KratosRevokeSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosRevokeSession" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosRevokeSession() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosRevokeSession" /> class.
        /// </summary>
        /// <param name="sessionToken">The Session Token  Invalidate this session token. (required).</param>
        public KratosRevokeSession(string sessionToken = default(string))
        {
            // to ensure "sessionToken" is required (not null)
            this.SessionToken = sessionToken ?? throw new ArgumentNullException("sessionToken is a required property for KratosRevokeSession and cannot be null");
        }
        
        /// <summary>
        /// The Session Token  Invalidate this session token.
        /// </summary>
        /// <value>The Session Token  Invalidate this session token.</value>
        [DataMember(Name="session_token", EmitDefaultValue=false)]
        public string SessionToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosRevokeSession {\n");
            sb.Append("  SessionToken: ").Append(SessionToken).Append("\n");
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
            return this.Equals(input as KratosRevokeSession);
        }

        /// <summary>
        /// Returns true if KratosRevokeSession instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosRevokeSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosRevokeSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionToken == input.SessionToken ||
                    (this.SessionToken != null &&
                    this.SessionToken.Equals(input.SessionToken))
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
                if (this.SessionToken != null)
                    hashCode = hashCode * 59 + this.SessionToken.GetHashCode();
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
