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
    /// Details concerning remaining monthly quotas.
    /// </summary>
    [DataContract(Name = "AccountResponseQuotas")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class AccountResponseQuotas : IEquatable<AccountResponseQuotas>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResponseQuotas" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountResponseQuotas() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResponseQuotas" /> class.
        /// </summary>
        /// <param name="apiSignatureRequestsLeft">API signature requests remaining..</param>
        /// <param name="documentsLeft">Signature requests remaining..</param>
        /// <param name="templatesTotal">Total API templates allowed..</param>
        /// <param name="templatesLeft">API templates remaining..</param>
        /// <param name="smsVerificationsLeft">SMS verifications remaining..</param>
        /// <param name="numFaxPagesLeft">Number of fax pages left.</param>
        public AccountResponseQuotas(int? apiSignatureRequestsLeft = default(int?), int? documentsLeft = default(int?), int? templatesTotal = default(int?), int? templatesLeft = default(int?), int? smsVerificationsLeft = default(int?), int? numFaxPagesLeft = default(int?))
        {

            this.ApiSignatureRequestsLeft = apiSignatureRequestsLeft;
            this.DocumentsLeft = documentsLeft;
            this.TemplatesTotal = templatesTotal;
            this.TemplatesLeft = templatesLeft;
            this.SmsVerificationsLeft = smsVerificationsLeft;
            this.NumFaxPagesLeft = numFaxPagesLeft;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static AccountResponseQuotas Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<AccountResponseQuotas>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of AccountResponseQuotas");
            }

            return obj;
        }

        /// <summary>
        /// API signature requests remaining.
        /// </summary>
        /// <value>API signature requests remaining.</value>
        [DataMember(Name = "api_signature_requests_left", EmitDefaultValue = true)]
        public int? ApiSignatureRequestsLeft { get; set; }

        /// <summary>
        /// Signature requests remaining.
        /// </summary>
        /// <value>Signature requests remaining.</value>
        [DataMember(Name = "documents_left", EmitDefaultValue = true)]
        public int? DocumentsLeft { get; set; }

        /// <summary>
        /// Total API templates allowed.
        /// </summary>
        /// <value>Total API templates allowed.</value>
        [DataMember(Name = "templates_total", EmitDefaultValue = true)]
        public int? TemplatesTotal { get; set; }

        /// <summary>
        /// API templates remaining.
        /// </summary>
        /// <value>API templates remaining.</value>
        [DataMember(Name = "templates_left", EmitDefaultValue = true)]
        public int? TemplatesLeft { get; set; }

        /// <summary>
        /// SMS verifications remaining.
        /// </summary>
        /// <value>SMS verifications remaining.</value>
        [DataMember(Name = "sms_verifications_left", EmitDefaultValue = true)]
        public int? SmsVerificationsLeft { get; set; }

        /// <summary>
        /// Number of fax pages left
        /// </summary>
        /// <value>Number of fax pages left</value>
        [DataMember(Name = "num_fax_pages_left", EmitDefaultValue = true)]
        public int? NumFaxPagesLeft { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountResponseQuotas {\n");
            sb.Append("  ApiSignatureRequestsLeft: ").Append(ApiSignatureRequestsLeft).Append("\n");
            sb.Append("  DocumentsLeft: ").Append(DocumentsLeft).Append("\n");
            sb.Append("  TemplatesTotal: ").Append(TemplatesTotal).Append("\n");
            sb.Append("  TemplatesLeft: ").Append(TemplatesLeft).Append("\n");
            sb.Append("  SmsVerificationsLeft: ").Append(SmsVerificationsLeft).Append("\n");
            sb.Append("  NumFaxPagesLeft: ").Append(NumFaxPagesLeft).Append("\n");
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
            return this.Equals(input as AccountResponseQuotas);
        }

        /// <summary>
        /// Returns true if AccountResponseQuotas instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountResponseQuotas to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountResponseQuotas input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.ApiSignatureRequestsLeft == input.ApiSignatureRequestsLeft ||
                    (this.ApiSignatureRequestsLeft != null &&
                    this.ApiSignatureRequestsLeft.Equals(input.ApiSignatureRequestsLeft))
                ) &&
                (
                    this.DocumentsLeft == input.DocumentsLeft ||
                    (this.DocumentsLeft != null &&
                    this.DocumentsLeft.Equals(input.DocumentsLeft))
                ) &&
                (
                    this.TemplatesTotal == input.TemplatesTotal ||
                    (this.TemplatesTotal != null &&
                    this.TemplatesTotal.Equals(input.TemplatesTotal))
                ) &&
                (
                    this.TemplatesLeft == input.TemplatesLeft ||
                    (this.TemplatesLeft != null &&
                    this.TemplatesLeft.Equals(input.TemplatesLeft))
                ) &&
                (
                    this.SmsVerificationsLeft == input.SmsVerificationsLeft ||
                    (this.SmsVerificationsLeft != null &&
                    this.SmsVerificationsLeft.Equals(input.SmsVerificationsLeft))
                ) &&
                (
                    this.NumFaxPagesLeft == input.NumFaxPagesLeft ||
                    (this.NumFaxPagesLeft != null &&
                    this.NumFaxPagesLeft.Equals(input.NumFaxPagesLeft))
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
                if (this.ApiSignatureRequestsLeft != null)
                {
                    hashCode = (hashCode * 59) + this.ApiSignatureRequestsLeft.GetHashCode();
                }
                if (this.DocumentsLeft != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentsLeft.GetHashCode();
                }
                if (this.TemplatesTotal != null)
                {
                    hashCode = (hashCode * 59) + this.TemplatesTotal.GetHashCode();
                }
                if (this.TemplatesLeft != null)
                {
                    hashCode = (hashCode * 59) + this.TemplatesLeft.GetHashCode();
                }
                if (this.SmsVerificationsLeft != null)
                {
                    hashCode = (hashCode * 59) + this.SmsVerificationsLeft.GetHashCode();
                }
                if (this.NumFaxPagesLeft != null)
                {
                    hashCode = (hashCode * 59) + this.NumFaxPagesLeft.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType()
            {
                Name = "api_signature_requests_left",
                Property = "ApiSignatureRequestsLeft",
                Type = "int?",
                Value = ApiSignatureRequestsLeft,
            });
            types.Add(new OpenApiType()
            {
                Name = "documents_left",
                Property = "DocumentsLeft",
                Type = "int?",
                Value = DocumentsLeft,
            });
            types.Add(new OpenApiType()
            {
                Name = "templates_total",
                Property = "TemplatesTotal",
                Type = "int?",
                Value = TemplatesTotal,
            });
            types.Add(new OpenApiType()
            {
                Name = "templates_left",
                Property = "TemplatesLeft",
                Type = "int?",
                Value = TemplatesLeft,
            });
            types.Add(new OpenApiType()
            {
                Name = "sms_verifications_left",
                Property = "SmsVerificationsLeft",
                Type = "int?",
                Value = SmsVerificationsLeft,
            });
            types.Add(new OpenApiType()
            {
                Name = "num_fax_pages_left",
                Property = "NumFaxPagesLeft",
                Type = "int?",
                Value = NumFaxPagesLeft,
            });

            return types;
        }
    }

}
