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
    /// Defines SubFormFieldsPerDocumentTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubFormFieldsPerDocumentTypeEnum
    {
        /// <summary>
        /// Enum Checkbox for value: checkbox
        /// </summary>
        [EnumMember(Value = "checkbox")]
        Checkbox = 1,

        /// <summary>
        /// Enum CheckboxMerge for value: checkbox-merge
        /// </summary>
        [EnumMember(Value = "checkbox-merge")]
        CheckboxMerge = 2,

        /// <summary>
        /// Enum DateSigned for value: date_signed
        /// </summary>
        [EnumMember(Value = "date_signed")]
        DateSigned = 3,

        /// <summary>
        /// Enum Dropdown for value: dropdown
        /// </summary>
        [EnumMember(Value = "dropdown")]
        Dropdown = 4,

        /// <summary>
        /// Enum Hyperlink for value: hyperlink
        /// </summary>
        [EnumMember(Value = "hyperlink")]
        Hyperlink = 5,

        /// <summary>
        /// Enum Initials for value: initials
        /// </summary>
        [EnumMember(Value = "initials")]
        Initials = 6,

        /// <summary>
        /// Enum Signature for value: signature
        /// </summary>
        [EnumMember(Value = "signature")]
        Signature = 7,

        /// <summary>
        /// Enum Radio for value: radio
        /// </summary>
        [EnumMember(Value = "radio")]
        Radio = 8,

        /// <summary>
        /// Enum Text for value: text
        /// </summary>
        [EnumMember(Value = "text")]
        Text = 9,

        /// <summary>
        /// Enum TextMerge for value: text-merge
        /// </summary>
        [EnumMember(Value = "text-merge")]
        TextMerge = 10
    }

}
