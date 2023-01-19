/*
 * Dropbox Sign API
 *
 * Dropbox Sign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dropbox.Sign.Client.OpenAPIDateConverter;

namespace Dropbox.Sign.Model
{
    /// <summary>
    /// Contains template id
    /// </summary>
    [DataContract(Name = "TemplateUpdateFilesResponseTemplate")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateUpdateFilesResponseTemplate : IOpenApiTyped, IEquatable<TemplateUpdateFilesResponseTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdateFilesResponseTemplate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateUpdateFilesResponseTemplate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdateFilesResponseTemplate" /> class.
        /// </summary>
        /// <param name="templateId">The id of the Template..</param>
        /// <param name="warnings">A list of warnings..</param>
        public TemplateUpdateFilesResponseTemplate(string templateId = default(string), List<WarningResponse> warnings = default(List<WarningResponse>))
        {
            
            this.TemplateId = templateId;
            this.Warnings = warnings;
        }

        /// <summary>
        /// The id of the Template.
        /// </summary>
        /// <value>The id of the Template.</value>
        [DataMember(Name = "template_id", EmitDefaultValue = true)]
        public string TemplateId { get; set; }

        /// <summary>
        /// A list of warnings.
        /// </summary>
        /// <value>A list of warnings.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = true)]
        public List<WarningResponse> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateUpdateFilesResponseTemplate {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateUpdateFilesResponseTemplate);
        }

        /// <summary>
        /// Returns true if TemplateUpdateFilesResponseTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateUpdateFilesResponseTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateUpdateFilesResponseTemplate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "template_id",
                Property = "TemplateId",
                Type = "string",
                Value = TemplateId,
            });
            types.Add(new OpenApiType(){
                Name = "warnings",
                Property = "Warnings",
                Type = "List<WarningResponse>",
                Value = Warnings,
            });

            return types;
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}