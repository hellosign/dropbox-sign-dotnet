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
    /// TemplateCreateRequest
    /// </summary>
    [DataContract(Name = "TemplateCreateRequest")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateCreateRequest : IOpenApiTyped, IEquatable<TemplateCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateCreateRequest" /> class.
        /// </summary>
        /// <param name="files">Use &#x60;files[]&#x60; to indicate the uploaded file(s) to send for signature.  This endpoint requires either **files** or **file_urls[]**, but not both..</param>
        /// <param name="fileUrls">Use &#x60;file_urls[]&#x60; to have Dropbox Sign download the file(s) to send for signature.  This endpoint requires either **files** or **file_urls[]**, but not both..</param>
        /// <param name="allowReassign">Allows signers to reassign their signature requests to other signers if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.  **Note**: Only available for Premium plan and higher. (default to false).</param>
        /// <param name="attachments">A list describing the attachments.</param>
        /// <param name="ccRoles">The CC roles that must be assigned when using the template to send a signature request.</param>
        /// <param name="clientId">Client id of the app you&#39;re using to create this draft. Used to apply the branding and callback url defined for the app..</param>
        /// <param name="fieldOptions">fieldOptions.</param>
        /// <param name="formFieldGroups">Group information for fields defined in &#x60;form_fields_per_document&#x60;. String-indexed JSON array with &#x60;group_label&#x60; and &#x60;requirement&#x60; keys. &#x60;form_fields_per_document&#x60; must contain fields referencing a group defined in &#x60;form_field_groups&#x60;..</param>
        /// <param name="formFieldRules">Conditional Logic rules for fields defined in &#x60;form_fields_per_document&#x60;..</param>
        /// <param name="formFieldsPerDocument">The fields that should appear on the document, expressed as an array of objects. (For more details you can read about it here: [Using Form Fields per Document](/docs/openapi/form-fields-per-document).)  **NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.  * Text Field use &#x60;SubFormFieldsPerDocumentText&#x60; * Dropdown Field use &#x60;SubFormFieldsPerDocumentDropdown&#x60; * Hyperlink Field use &#x60;SubFormFieldsPerDocumentHyperlink&#x60; * Checkbox Field use &#x60;SubFormFieldsPerDocumentCheckbox&#x60; * Radio Field use &#x60;SubFormFieldsPerDocumentRadio&#x60; * Signature Field use &#x60;SubFormFieldsPerDocumentSignature&#x60; * Date Signed Field use &#x60;SubFormFieldsPerDocumentDateSigned&#x60; * Initials Field use &#x60;SubFormFieldsPerDocumentInitials&#x60; * Text Merge Field use &#x60;SubFormFieldsPerDocumentTextMerge&#x60; * Checkbox Merge Field use &#x60;SubFormFieldsPerDocumentCheckboxMerge&#x60; (required).</param>
        /// <param name="mergeFields">Add merge fields to the template. Merge fields are placed by the user creating the template and used to pre-fill data by passing values into signature requests with the &#x60;custom_fields&#x60; parameter. If the signature request using that template *does not* pass a value into a merge field, then an empty field remains in the document..</param>
        /// <param name="message">The default template email message..</param>
        /// <param name="metadata">Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.  Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long..</param>
        /// <param name="signerRoles">An array of the designated signer roles that must be specified when sending a SignatureRequest using this Template. (required).</param>
        /// <param name="subject">The template title (alias)..</param>
        /// <param name="testMode">Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. (default to false).</param>
        /// <param name="title">The title you want to assign to the SignatureRequest..</param>
        /// <param name="usePreexistingFields">Enable the detection of predefined PDF fields by setting the &#x60;use_preexisting_fields&#x60; to &#x60;true&#x60; (defaults to disabled, or &#x60;false&#x60;). (default to false).</param>
        public TemplateCreateRequest(List<System.IO.Stream> files = default(List<System.IO.Stream>), List<string> fileUrls = default(List<string>), bool allowReassign = false, List<SubAttachment> attachments = default(List<SubAttachment>), List<string> ccRoles = default(List<string>), string clientId = default(string), SubFieldOptions fieldOptions = default(SubFieldOptions), List<SubFormFieldGroup> formFieldGroups = default(List<SubFormFieldGroup>), List<SubFormFieldRule> formFieldRules = default(List<SubFormFieldRule>), List<SubFormFieldsPerDocumentBase> formFieldsPerDocument = default(List<SubFormFieldsPerDocumentBase>), List<SubMergeField> mergeFields = default(List<SubMergeField>), string message = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), List<SubTemplateRole> signerRoles = default(List<SubTemplateRole>), string subject = default(string), bool testMode = false, string title = default(string), bool usePreexistingFields = false)
        {
            
            // to ensure "formFieldsPerDocument" is required (not null)
            if (formFieldsPerDocument == null)
            {
                throw new ArgumentNullException("formFieldsPerDocument is a required property for TemplateCreateRequest and cannot be null");
            }
            this.FormFieldsPerDocument = formFieldsPerDocument;
            // to ensure "signerRoles" is required (not null)
            if (signerRoles == null)
            {
                throw new ArgumentNullException("signerRoles is a required property for TemplateCreateRequest and cannot be null");
            }
            this.SignerRoles = signerRoles;
            this.Files = files;
            this.FileUrls = fileUrls;
            this.AllowReassign = allowReassign;
            this.Attachments = attachments;
            this.CcRoles = ccRoles;
            this.ClientId = clientId;
            this.FieldOptions = fieldOptions;
            this.FormFieldGroups = formFieldGroups;
            this.FormFieldRules = formFieldRules;
            this.MergeFields = mergeFields;
            this.Message = message;
            this.Metadata = metadata;
            this.Subject = subject;
            this.TestMode = testMode;
            this.Title = title;
            this.UsePreexistingFields = usePreexistingFields;
        }

        /// <summary>
        /// Attempt to instantiate and hydrate a new instance of this class
        /// </summary>
        /// <param name="jsonData">String of JSON data representing target object</param>
        public static TemplateCreateRequest Init(string jsonData)
        {
            var obj = JsonConvert.DeserializeObject<TemplateCreateRequest>(jsonData);

            if (obj == null)
            {
                throw new Exception("Unable to deserialize JSON to instance of TemplateCreateRequest");
            }

            return obj;
        }

        /// <summary>
        /// The fields that should appear on the document, expressed as an array of objects. (For more details you can read about it here: [Using Form Fields per Document](/docs/openapi/form-fields-per-document).)  **NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.  * Text Field use &#x60;SubFormFieldsPerDocumentText&#x60; * Dropdown Field use &#x60;SubFormFieldsPerDocumentDropdown&#x60; * Hyperlink Field use &#x60;SubFormFieldsPerDocumentHyperlink&#x60; * Checkbox Field use &#x60;SubFormFieldsPerDocumentCheckbox&#x60; * Radio Field use &#x60;SubFormFieldsPerDocumentRadio&#x60; * Signature Field use &#x60;SubFormFieldsPerDocumentSignature&#x60; * Date Signed Field use &#x60;SubFormFieldsPerDocumentDateSigned&#x60; * Initials Field use &#x60;SubFormFieldsPerDocumentInitials&#x60; * Text Merge Field use &#x60;SubFormFieldsPerDocumentTextMerge&#x60; * Checkbox Merge Field use &#x60;SubFormFieldsPerDocumentCheckboxMerge&#x60;
        /// </summary>
        /// <value>The fields that should appear on the document, expressed as an array of objects. (For more details you can read about it here: [Using Form Fields per Document](/docs/openapi/form-fields-per-document).)  **NOTE**: Fields like **text**, **dropdown**, **checkbox**, **radio**, and **hyperlink** have additional required and optional parameters. Check out the list of [additional parameters](/api/reference/constants/#form-fields-per-document) for these field types.  * Text Field use &#x60;SubFormFieldsPerDocumentText&#x60; * Dropdown Field use &#x60;SubFormFieldsPerDocumentDropdown&#x60; * Hyperlink Field use &#x60;SubFormFieldsPerDocumentHyperlink&#x60; * Checkbox Field use &#x60;SubFormFieldsPerDocumentCheckbox&#x60; * Radio Field use &#x60;SubFormFieldsPerDocumentRadio&#x60; * Signature Field use &#x60;SubFormFieldsPerDocumentSignature&#x60; * Date Signed Field use &#x60;SubFormFieldsPerDocumentDateSigned&#x60; * Initials Field use &#x60;SubFormFieldsPerDocumentInitials&#x60; * Text Merge Field use &#x60;SubFormFieldsPerDocumentTextMerge&#x60; * Checkbox Merge Field use &#x60;SubFormFieldsPerDocumentCheckboxMerge&#x60;</value>
        [DataMember(Name = "form_fields_per_document", IsRequired = true, EmitDefaultValue = true)]
        public List<SubFormFieldsPerDocumentBase> FormFieldsPerDocument { get; set; }

        /// <summary>
        /// An array of the designated signer roles that must be specified when sending a SignatureRequest using this Template.
        /// </summary>
        /// <value>An array of the designated signer roles that must be specified when sending a SignatureRequest using this Template.</value>
        [DataMember(Name = "signer_roles", IsRequired = true, EmitDefaultValue = true)]
        public List<SubTemplateRole> SignerRoles { get; set; }

        /// <summary>
        /// Use &#x60;files[]&#x60; to indicate the uploaded file(s) to send for signature.  This endpoint requires either **files** or **file_urls[]**, but not both.
        /// </summary>
        /// <value>Use &#x60;files[]&#x60; to indicate the uploaded file(s) to send for signature.  This endpoint requires either **files** or **file_urls[]**, but not both.</value>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<System.IO.Stream> Files { get; set; }

        /// <summary>
        /// Use &#x60;file_urls[]&#x60; to have Dropbox Sign download the file(s) to send for signature.  This endpoint requires either **files** or **file_urls[]**, but not both.
        /// </summary>
        /// <value>Use &#x60;file_urls[]&#x60; to have Dropbox Sign download the file(s) to send for signature.  This endpoint requires either **files** or **file_urls[]**, but not both.</value>
        [DataMember(Name = "file_urls", EmitDefaultValue = true)]
        public List<string> FileUrls { get; set; }

        /// <summary>
        /// Allows signers to reassign their signature requests to other signers if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.  **Note**: Only available for Premium plan and higher.
        /// </summary>
        /// <value>Allows signers to reassign their signature requests to other signers if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.  **Note**: Only available for Premium plan and higher.</value>
        [DataMember(Name = "allow_reassign", EmitDefaultValue = true)]
        public bool AllowReassign { get; set; }

        /// <summary>
        /// A list describing the attachments
        /// </summary>
        /// <value>A list describing the attachments</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<SubAttachment> Attachments { get; set; }

        /// <summary>
        /// The CC roles that must be assigned when using the template to send a signature request
        /// </summary>
        /// <value>The CC roles that must be assigned when using the template to send a signature request</value>
        [DataMember(Name = "cc_roles", EmitDefaultValue = true)]
        public List<string> CcRoles { get; set; }

        /// <summary>
        /// Client id of the app you&#39;re using to create this draft. Used to apply the branding and callback url defined for the app.
        /// </summary>
        /// <value>Client id of the app you&#39;re using to create this draft. Used to apply the branding and callback url defined for the app.</value>
        [DataMember(Name = "client_id", EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets FieldOptions
        /// </summary>
        [DataMember(Name = "field_options", EmitDefaultValue = true)]
        public SubFieldOptions FieldOptions { get; set; }

        /// <summary>
        /// Group information for fields defined in &#x60;form_fields_per_document&#x60;. String-indexed JSON array with &#x60;group_label&#x60; and &#x60;requirement&#x60; keys. &#x60;form_fields_per_document&#x60; must contain fields referencing a group defined in &#x60;form_field_groups&#x60;.
        /// </summary>
        /// <value>Group information for fields defined in &#x60;form_fields_per_document&#x60;. String-indexed JSON array with &#x60;group_label&#x60; and &#x60;requirement&#x60; keys. &#x60;form_fields_per_document&#x60; must contain fields referencing a group defined in &#x60;form_field_groups&#x60;.</value>
        [DataMember(Name = "form_field_groups", EmitDefaultValue = true)]
        public List<SubFormFieldGroup> FormFieldGroups { get; set; }

        /// <summary>
        /// Conditional Logic rules for fields defined in &#x60;form_fields_per_document&#x60;.
        /// </summary>
        /// <value>Conditional Logic rules for fields defined in &#x60;form_fields_per_document&#x60;.</value>
        [DataMember(Name = "form_field_rules", EmitDefaultValue = true)]
        public List<SubFormFieldRule> FormFieldRules { get; set; }

        /// <summary>
        /// Add merge fields to the template. Merge fields are placed by the user creating the template and used to pre-fill data by passing values into signature requests with the &#x60;custom_fields&#x60; parameter. If the signature request using that template *does not* pass a value into a merge field, then an empty field remains in the document.
        /// </summary>
        /// <value>Add merge fields to the template. Merge fields are placed by the user creating the template and used to pre-fill data by passing values into signature requests with the &#x60;custom_fields&#x60; parameter. If the signature request using that template *does not* pass a value into a merge field, then an empty field remains in the document.</value>
        [DataMember(Name = "merge_fields", EmitDefaultValue = true)]
        public List<SubMergeField> MergeFields { get; set; }

        /// <summary>
        /// The default template email message.
        /// </summary>
        /// <value>The default template email message.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.  Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long.
        /// </summary>
        /// <value>Key-value data that should be attached to the signature request. This metadata is included in all API responses and events involving the signature request. For example, use the metadata field to store a signer&#39;s order number for look up when receiving events for the signature request.  Each request can include up to 10 metadata keys (or 50 nested metadata keys), with key names up to 40 characters long and values up to 1000 characters long.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// The template title (alias).
        /// </summary>
        /// <value>The template title (alias).</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "test_mode", EmitDefaultValue = true)]
        public bool TestMode { get; set; }

        /// <summary>
        /// The title you want to assign to the SignatureRequest.
        /// </summary>
        /// <value>The title you want to assign to the SignatureRequest.</value>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Enable the detection of predefined PDF fields by setting the &#x60;use_preexisting_fields&#x60; to &#x60;true&#x60; (defaults to disabled, or &#x60;false&#x60;).
        /// </summary>
        /// <value>Enable the detection of predefined PDF fields by setting the &#x60;use_preexisting_fields&#x60; to &#x60;true&#x60; (defaults to disabled, or &#x60;false&#x60;).</value>
        [DataMember(Name = "use_preexisting_fields", EmitDefaultValue = true)]
        public bool UsePreexistingFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateCreateRequest {\n");
            sb.Append("  FormFieldsPerDocument: ").Append(FormFieldsPerDocument).Append("\n");
            sb.Append("  SignerRoles: ").Append(SignerRoles).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  FileUrls: ").Append(FileUrls).Append("\n");
            sb.Append("  AllowReassign: ").Append(AllowReassign).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  CcRoles: ").Append(CcRoles).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  FieldOptions: ").Append(FieldOptions).Append("\n");
            sb.Append("  FormFieldGroups: ").Append(FormFieldGroups).Append("\n");
            sb.Append("  FormFieldRules: ").Append(FormFieldRules).Append("\n");
            sb.Append("  MergeFields: ").Append(MergeFields).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UsePreexistingFields: ").Append(UsePreexistingFields).Append("\n");
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
            return this.Equals(input as TemplateCreateRequest);
        }

        /// <summary>
        /// Returns true if TemplateCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateCreateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FormFieldsPerDocument == input.FormFieldsPerDocument ||
                    this.FormFieldsPerDocument != null &&
                    input.FormFieldsPerDocument != null &&
                    this.FormFieldsPerDocument.SequenceEqual(input.FormFieldsPerDocument)
                ) && 
                (
                    this.SignerRoles == input.SignerRoles ||
                    this.SignerRoles != null &&
                    input.SignerRoles != null &&
                    this.SignerRoles.SequenceEqual(input.SignerRoles)
                ) && 
                (
                    this.Files == input.Files ||
                    this.Files != null &&
                    input.Files != null &&
                    this.Files.SequenceEqual(input.Files)
                ) && 
                (
                    this.FileUrls == input.FileUrls ||
                    this.FileUrls != null &&
                    input.FileUrls != null &&
                    this.FileUrls.SequenceEqual(input.FileUrls)
                ) && 
                (
                    this.AllowReassign == input.AllowReassign ||
                    this.AllowReassign.Equals(input.AllowReassign)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.CcRoles == input.CcRoles ||
                    this.CcRoles != null &&
                    input.CcRoles != null &&
                    this.CcRoles.SequenceEqual(input.CcRoles)
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.FieldOptions == input.FieldOptions ||
                    (this.FieldOptions != null &&
                    this.FieldOptions.Equals(input.FieldOptions))
                ) && 
                (
                    this.FormFieldGroups == input.FormFieldGroups ||
                    this.FormFieldGroups != null &&
                    input.FormFieldGroups != null &&
                    this.FormFieldGroups.SequenceEqual(input.FormFieldGroups)
                ) && 
                (
                    this.FormFieldRules == input.FormFieldRules ||
                    this.FormFieldRules != null &&
                    input.FormFieldRules != null &&
                    this.FormFieldRules.SequenceEqual(input.FormFieldRules)
                ) && 
                (
                    this.MergeFields == input.MergeFields ||
                    this.MergeFields != null &&
                    input.MergeFields != null &&
                    this.MergeFields.SequenceEqual(input.MergeFields)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TestMode == input.TestMode ||
                    this.TestMode.Equals(input.TestMode)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.UsePreexistingFields == input.UsePreexistingFields ||
                    this.UsePreexistingFields.Equals(input.UsePreexistingFields)
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
                if (this.FormFieldsPerDocument != null)
                {
                    hashCode = (hashCode * 59) + this.FormFieldsPerDocument.GetHashCode();
                }
                if (this.SignerRoles != null)
                {
                    hashCode = (hashCode * 59) + this.SignerRoles.GetHashCode();
                }
                if (this.Files != null)
                {
                    hashCode = (hashCode * 59) + this.Files.GetHashCode();
                }
                if (this.FileUrls != null)
                {
                    hashCode = (hashCode * 59) + this.FileUrls.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowReassign.GetHashCode();
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.CcRoles != null)
                {
                    hashCode = (hashCode * 59) + this.CcRoles.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.FieldOptions != null)
                {
                    hashCode = (hashCode * 59) + this.FieldOptions.GetHashCode();
                }
                if (this.FormFieldGroups != null)
                {
                    hashCode = (hashCode * 59) + this.FormFieldGroups.GetHashCode();
                }
                if (this.FormFieldRules != null)
                {
                    hashCode = (hashCode * 59) + this.FormFieldRules.GetHashCode();
                }
                if (this.MergeFields != null)
                {
                    hashCode = (hashCode * 59) + this.MergeFields.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TestMode.GetHashCode();
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UsePreexistingFields.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "form_fields_per_document",
                Property = "FormFieldsPerDocument",
                Type = "List<SubFormFieldsPerDocumentBase>",
                Value = FormFieldsPerDocument,
            });
            types.Add(new OpenApiType(){
                Name = "signer_roles",
                Property = "SignerRoles",
                Type = "List<SubTemplateRole>",
                Value = SignerRoles,
            });
            types.Add(new OpenApiType(){
                Name = "files",
                Property = "Files",
                Type = "List<System.IO.Stream>",
                Value = Files,
            });
            types.Add(new OpenApiType(){
                Name = "file_urls",
                Property = "FileUrls",
                Type = "List<string>",
                Value = FileUrls,
            });
            types.Add(new OpenApiType(){
                Name = "allow_reassign",
                Property = "AllowReassign",
                Type = "bool",
                Value = AllowReassign,
            });
            types.Add(new OpenApiType(){
                Name = "attachments",
                Property = "Attachments",
                Type = "List<SubAttachment>",
                Value = Attachments,
            });
            types.Add(new OpenApiType(){
                Name = "cc_roles",
                Property = "CcRoles",
                Type = "List<string>",
                Value = CcRoles,
            });
            types.Add(new OpenApiType(){
                Name = "client_id",
                Property = "ClientId",
                Type = "string",
                Value = ClientId,
            });
            types.Add(new OpenApiType(){
                Name = "field_options",
                Property = "FieldOptions",
                Type = "SubFieldOptions",
                Value = FieldOptions,
            });
            types.Add(new OpenApiType(){
                Name = "form_field_groups",
                Property = "FormFieldGroups",
                Type = "List<SubFormFieldGroup>",
                Value = FormFieldGroups,
            });
            types.Add(new OpenApiType(){
                Name = "form_field_rules",
                Property = "FormFieldRules",
                Type = "List<SubFormFieldRule>",
                Value = FormFieldRules,
            });
            types.Add(new OpenApiType(){
                Name = "merge_fields",
                Property = "MergeFields",
                Type = "List<SubMergeField>",
                Value = MergeFields,
            });
            types.Add(new OpenApiType(){
                Name = "message",
                Property = "Message",
                Type = "string",
                Value = Message,
            });
            types.Add(new OpenApiType(){
                Name = "metadata",
                Property = "Metadata",
                Type = "Dictionary<string, Object>",
                Value = Metadata,
            });
            types.Add(new OpenApiType(){
                Name = "subject",
                Property = "Subject",
                Type = "string",
                Value = Subject,
            });
            types.Add(new OpenApiType(){
                Name = "test_mode",
                Property = "TestMode",
                Type = "bool",
                Value = TestMode,
            });
            types.Add(new OpenApiType(){
                Name = "title",
                Property = "Title",
                Type = "string",
                Value = Title,
            });
            types.Add(new OpenApiType(){
                Name = "use_preexisting_fields",
                Property = "UsePreexistingFields",
                Type = "bool",
                Value = UsePreexistingFields,
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
            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 5000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 5000.", new [] { "Message" });
            }

            // Subject (string) maxLength
            if (this.Subject != null && this.Subject.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Subject, length must be less than 200.", new [] { "Subject" });
            }

            yield break;
        }
    }

}