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
    /// KratosLoginFlowMethod
    /// </summary>
    [DataContract]
    public partial class KratosLoginFlowMethod :  IEquatable<KratosLoginFlowMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosLoginFlowMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosLoginFlowMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosLoginFlowMethod" /> class.
        /// </summary>
        /// <param name="config">config (required).</param>
        /// <param name="method">and so on. (required).</param>
        public KratosLoginFlowMethod(KratosLoginFlowMethodConfig config = default(KratosLoginFlowMethodConfig), string method = default(string))
        {
            // to ensure "config" is required (not null)
            this.Config = config ?? throw new ArgumentNullException("config is a required property for KratosLoginFlowMethod and cannot be null");
            // to ensure "method" is required (not null)
            this.Method = method ?? throw new ArgumentNullException("method is a required property for KratosLoginFlowMethod and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public KratosLoginFlowMethodConfig Config { get; set; }

        /// <summary>
        /// and so on.
        /// </summary>
        /// <value>and so on.</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosLoginFlowMethod {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as KratosLoginFlowMethod);
        }

        /// <summary>
        /// Returns true if KratosLoginFlowMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosLoginFlowMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosLoginFlowMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
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
