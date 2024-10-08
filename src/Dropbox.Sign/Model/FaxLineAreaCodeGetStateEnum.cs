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
    /// Defines FaxLineAreaCodeGetStateEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FaxLineAreaCodeGetStateEnum
    {
        /// <summary>
        /// Enum AK for value: AK
        /// </summary>
        [EnumMember(Value = "AK")]
        AK = 1,

        /// <summary>
        /// Enum AL for value: AL
        /// </summary>
        [EnumMember(Value = "AL")]
        AL = 2,

        /// <summary>
        /// Enum AR for value: AR
        /// </summary>
        [EnumMember(Value = "AR")]
        AR = 3,

        /// <summary>
        /// Enum AZ for value: AZ
        /// </summary>
        [EnumMember(Value = "AZ")]
        AZ = 4,

        /// <summary>
        /// Enum CA for value: CA
        /// </summary>
        [EnumMember(Value = "CA")]
        CA = 5,

        /// <summary>
        /// Enum CO for value: CO
        /// </summary>
        [EnumMember(Value = "CO")]
        CO = 6,

        /// <summary>
        /// Enum CT for value: CT
        /// </summary>
        [EnumMember(Value = "CT")]
        CT = 7,

        /// <summary>
        /// Enum DC for value: DC
        /// </summary>
        [EnumMember(Value = "DC")]
        DC = 8,

        /// <summary>
        /// Enum DE for value: DE
        /// </summary>
        [EnumMember(Value = "DE")]
        DE = 9,

        /// <summary>
        /// Enum FL for value: FL
        /// </summary>
        [EnumMember(Value = "FL")]
        FL = 10,

        /// <summary>
        /// Enum GA for value: GA
        /// </summary>
        [EnumMember(Value = "GA")]
        GA = 11,

        /// <summary>
        /// Enum HI for value: HI
        /// </summary>
        [EnumMember(Value = "HI")]
        HI = 12,

        /// <summary>
        /// Enum IA for value: IA
        /// </summary>
        [EnumMember(Value = "IA")]
        IA = 13,

        /// <summary>
        /// Enum ID for value: ID
        /// </summary>
        [EnumMember(Value = "ID")]
        ID = 14,

        /// <summary>
        /// Enum IL for value: IL
        /// </summary>
        [EnumMember(Value = "IL")]
        IL = 15,

        /// <summary>
        /// Enum IN for value: IN
        /// </summary>
        [EnumMember(Value = "IN")]
        IN = 16,

        /// <summary>
        /// Enum KS for value: KS
        /// </summary>
        [EnumMember(Value = "KS")]
        KS = 17,

        /// <summary>
        /// Enum KY for value: KY
        /// </summary>
        [EnumMember(Value = "KY")]
        KY = 18,

        /// <summary>
        /// Enum LA for value: LA
        /// </summary>
        [EnumMember(Value = "LA")]
        LA = 19,

        /// <summary>
        /// Enum MA for value: MA
        /// </summary>
        [EnumMember(Value = "MA")]
        MA = 20,

        /// <summary>
        /// Enum MD for value: MD
        /// </summary>
        [EnumMember(Value = "MD")]
        MD = 21,

        /// <summary>
        /// Enum ME for value: ME
        /// </summary>
        [EnumMember(Value = "ME")]
        ME = 22,

        /// <summary>
        /// Enum MI for value: MI
        /// </summary>
        [EnumMember(Value = "MI")]
        MI = 23,

        /// <summary>
        /// Enum MN for value: MN
        /// </summary>
        [EnumMember(Value = "MN")]
        MN = 24,

        /// <summary>
        /// Enum MO for value: MO
        /// </summary>
        [EnumMember(Value = "MO")]
        MO = 25,

        /// <summary>
        /// Enum MS for value: MS
        /// </summary>
        [EnumMember(Value = "MS")]
        MS = 26,

        /// <summary>
        /// Enum MT for value: MT
        /// </summary>
        [EnumMember(Value = "MT")]
        MT = 27,

        /// <summary>
        /// Enum NC for value: NC
        /// </summary>
        [EnumMember(Value = "NC")]
        NC = 28,

        /// <summary>
        /// Enum ND for value: ND
        /// </summary>
        [EnumMember(Value = "ND")]
        ND = 29,

        /// <summary>
        /// Enum NE for value: NE
        /// </summary>
        [EnumMember(Value = "NE")]
        NE = 30,

        /// <summary>
        /// Enum NH for value: NH
        /// </summary>
        [EnumMember(Value = "NH")]
        NH = 31,

        /// <summary>
        /// Enum NJ for value: NJ
        /// </summary>
        [EnumMember(Value = "NJ")]
        NJ = 32,

        /// <summary>
        /// Enum NM for value: NM
        /// </summary>
        [EnumMember(Value = "NM")]
        NM = 33,

        /// <summary>
        /// Enum NV for value: NV
        /// </summary>
        [EnumMember(Value = "NV")]
        NV = 34,

        /// <summary>
        /// Enum NY for value: NY
        /// </summary>
        [EnumMember(Value = "NY")]
        NY = 35,

        /// <summary>
        /// Enum OH for value: OH
        /// </summary>
        [EnumMember(Value = "OH")]
        OH = 36,

        /// <summary>
        /// Enum OK for value: OK
        /// </summary>
        [EnumMember(Value = "OK")]
        OK = 37,

        /// <summary>
        /// Enum OR for value: OR
        /// </summary>
        [EnumMember(Value = "OR")]
        OR = 38,

        /// <summary>
        /// Enum PA for value: PA
        /// </summary>
        [EnumMember(Value = "PA")]
        PA = 39,

        /// <summary>
        /// Enum RI for value: RI
        /// </summary>
        [EnumMember(Value = "RI")]
        RI = 40,

        /// <summary>
        /// Enum SC for value: SC
        /// </summary>
        [EnumMember(Value = "SC")]
        SC = 41,

        /// <summary>
        /// Enum SD for value: SD
        /// </summary>
        [EnumMember(Value = "SD")]
        SD = 42,

        /// <summary>
        /// Enum TN for value: TN
        /// </summary>
        [EnumMember(Value = "TN")]
        TN = 43,

        /// <summary>
        /// Enum TX for value: TX
        /// </summary>
        [EnumMember(Value = "TX")]
        TX = 44,

        /// <summary>
        /// Enum UT for value: UT
        /// </summary>
        [EnumMember(Value = "UT")]
        UT = 45,

        /// <summary>
        /// Enum VA for value: VA
        /// </summary>
        [EnumMember(Value = "VA")]
        VA = 46,

        /// <summary>
        /// Enum VT for value: VT
        /// </summary>
        [EnumMember(Value = "VT")]
        VT = 47,

        /// <summary>
        /// Enum WA for value: WA
        /// </summary>
        [EnumMember(Value = "WA")]
        WA = 48,

        /// <summary>
        /// Enum WI for value: WI
        /// </summary>
        [EnumMember(Value = "WI")]
        WI = 49,

        /// <summary>
        /// Enum WV for value: WV
        /// </summary>
        [EnumMember(Value = "WV")]
        WV = 50,

        /// <summary>
        /// Enum WY for value: WY
        /// </summary>
        [EnumMember(Value = "WY")]
        WY = 51
    }

}
