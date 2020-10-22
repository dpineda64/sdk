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
    /// Field represents a HTML Form Field
    /// </summary>
    [DataContract]
    public partial class KratosFormField :  IEquatable<KratosFormField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosFormField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosFormField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosFormField" /> class.
        /// </summary>
        /// <param name="disabled">Disabled is the equivalent of &#x60;&lt;input {{if .Disabled}}disabled{{end}}\&quot;&gt;&#x60;.</param>
        /// <param name="messages">messages.</param>
        /// <param name="name">Name is the equivalent of &#x60;&lt;input name&#x3D;\&quot;{{.Name}}\&quot;&gt;&#x60; (required).</param>
        /// <param name="pattern">Pattern is the equivalent of &#x60;&lt;input pattern&#x3D;\&quot;{{.Pattern}}\&quot;&gt;&#x60;.</param>
        /// <param name="required">Required is the equivalent of &#x60;&lt;input required&#x3D;\&quot;{{.Required}}\&quot;&gt;&#x60;.</param>
        /// <param name="type">Type is the equivalent of &#x60;&lt;input type&#x3D;\&quot;{{.Type}}\&quot;&gt;&#x60; (required).</param>
        /// <param name="value">Value is the equivalent of &#x60;&lt;input value&#x3D;\&quot;{{.Value}}\&quot;&gt;&#x60;.</param>
        public KratosFormField(bool disabled = default(bool), List<KratosMessage> messages = default(List<KratosMessage>), string name = default(string), string pattern = default(string), bool required = default(bool), string type = default(string), Object value = default(Object))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for KratosFormField and cannot be null");
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for KratosFormField and cannot be null");
            this.Disabled = disabled;
            this.Messages = messages;
            this.Pattern = pattern;
            this.Required = required;
            this.Value = value;
        }
        
        /// <summary>
        /// Disabled is the equivalent of &#x60;&lt;input {{if .Disabled}}disabled{{end}}\&quot;&gt;&#x60;
        /// </summary>
        /// <value>Disabled is the equivalent of &#x60;&lt;input {{if .Disabled}}disabled{{end}}\&quot;&gt;&#x60;</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool Disabled { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<KratosMessage> Messages { get; set; }

        /// <summary>
        /// Name is the equivalent of &#x60;&lt;input name&#x3D;\&quot;{{.Name}}\&quot;&gt;&#x60;
        /// </summary>
        /// <value>Name is the equivalent of &#x60;&lt;input name&#x3D;\&quot;{{.Name}}\&quot;&gt;&#x60;</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Pattern is the equivalent of &#x60;&lt;input pattern&#x3D;\&quot;{{.Pattern}}\&quot;&gt;&#x60;
        /// </summary>
        /// <value>Pattern is the equivalent of &#x60;&lt;input pattern&#x3D;\&quot;{{.Pattern}}\&quot;&gt;&#x60;</value>
        [DataMember(Name="pattern", EmitDefaultValue=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// Required is the equivalent of &#x60;&lt;input required&#x3D;\&quot;{{.Required}}\&quot;&gt;&#x60;
        /// </summary>
        /// <value>Required is the equivalent of &#x60;&lt;input required&#x3D;\&quot;{{.Required}}\&quot;&gt;&#x60;</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool Required { get; set; }

        /// <summary>
        /// Type is the equivalent of &#x60;&lt;input type&#x3D;\&quot;{{.Type}}\&quot;&gt;&#x60;
        /// </summary>
        /// <value>Type is the equivalent of &#x60;&lt;input type&#x3D;\&quot;{{.Type}}\&quot;&gt;&#x60;</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Value is the equivalent of &#x60;&lt;input value&#x3D;\&quot;{{.Value}}\&quot;&gt;&#x60;
        /// </summary>
        /// <value>Value is the equivalent of &#x60;&lt;input value&#x3D;\&quot;{{.Value}}\&quot;&gt;&#x60;</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosFormField {\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as KratosFormField);
        }

        /// <summary>
        /// Returns true if KratosFormField instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosFormField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosFormField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Disabled == input.Disabled ||
                    this.Disabled.Equals(input.Disabled)
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Pattern == input.Pattern ||
                    (this.Pattern != null &&
                    this.Pattern.Equals(input.Pattern))
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
