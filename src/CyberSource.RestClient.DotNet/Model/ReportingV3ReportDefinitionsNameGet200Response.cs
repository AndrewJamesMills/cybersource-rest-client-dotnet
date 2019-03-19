/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyberSource.Model
{
    /// <summary>
    /// ReportingV3ReportDefinitionsNameGet200Response
    /// </summary>
    [DataContract]
    public partial class ReportingV3ReportDefinitionsNameGet200Response :  IEquatable<ReportingV3ReportDefinitionsNameGet200Response>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets SupportedFormats
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SupportedFormatsEnum
        {
            
            /// <summary>
            /// Enum ApplicationXml for "application/xml"
            /// </summary>
            [EnumMember(Value = "application/xml")]
            ApplicationXml,
            
            /// <summary>
            /// Enum TextCsv for "text/csv"
            /// </summary>
            [EnumMember(Value = "text/csv")]
            TextCsv
        }

        /// <summary>
        /// Gets or Sets SupportedFormats
        /// </summary>
        [DataMember(Name="supportedFormats", EmitDefaultValue=false)]
        public List<SupportedFormatsEnum> SupportedFormats { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3ReportDefinitionsNameGet200Response" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="ReportDefinitionId">ReportDefinitionId.</param>
        /// <param name="ReportDefintionName">ReportDefintionName.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="SupportedFormats">SupportedFormats.</param>
        /// <param name="Description">Description.</param>
        public ReportingV3ReportDefinitionsNameGet200Response(string Type = default(string), int? ReportDefinitionId = default(int?), string ReportDefintionName = default(string), List<ReportingV3ReportDefinitionsNameGet200ResponseAttributes> Attributes = default(List<ReportingV3ReportDefinitionsNameGet200ResponseAttributes>), List<SupportedFormatsEnum> SupportedFormats = default(List<SupportedFormatsEnum>), string Description = default(string))
        {
            this.Type = Type;
            this.ReportDefinitionId = ReportDefinitionId;
            this.ReportDefintionName = ReportDefintionName;
            this.Attributes = Attributes;
            this.SupportedFormats = SupportedFormats;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ReportDefinitionId
        /// </summary>
        [DataMember(Name="reportDefinitionId", EmitDefaultValue=false)]
        public int? ReportDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets ReportDefintionName
        /// </summary>
        [DataMember(Name="reportDefintionName", EmitDefaultValue=false)]
        public string ReportDefintionName { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<ReportingV3ReportDefinitionsNameGet200ResponseAttributes> Attributes { get; set; }


        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3ReportDefinitionsNameGet200Response {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReportDefinitionId: ").Append(ReportDefinitionId).Append("\n");
            sb.Append("  ReportDefintionName: ").Append(ReportDefintionName).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  SupportedFormats: ").Append(SupportedFormats).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ReportingV3ReportDefinitionsNameGet200Response);
        }

        /// <summary>
        /// Returns true if ReportingV3ReportDefinitionsNameGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3ReportDefinitionsNameGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3ReportDefinitionsNameGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ReportDefinitionId == other.ReportDefinitionId ||
                    this.ReportDefinitionId != null &&
                    this.ReportDefinitionId.Equals(other.ReportDefinitionId)
                ) && 
                (
                    this.ReportDefintionName == other.ReportDefintionName ||
                    this.ReportDefintionName != null &&
                    this.ReportDefintionName.Equals(other.ReportDefintionName)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) && 
                (
                    this.SupportedFormats == other.SupportedFormats ||
                    this.SupportedFormats != null &&
                    this.SupportedFormats.SequenceEqual(other.SupportedFormats)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.ReportDefinitionId != null)
                    hash = hash * 59 + this.ReportDefinitionId.GetHashCode();
                if (this.ReportDefintionName != null)
                    hash = hash * 59 + this.ReportDefintionName.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.SupportedFormats != null)
                    hash = hash * 59 + this.SupportedFormats.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
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
