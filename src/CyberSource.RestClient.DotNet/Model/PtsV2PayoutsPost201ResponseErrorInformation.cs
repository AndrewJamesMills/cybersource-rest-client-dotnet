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
    /// PtsV2PayoutsPost201ResponseErrorInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PayoutsPost201ResponseErrorInformation :  IEquatable<PtsV2PayoutsPost201ResponseErrorInformation>, IValidatableObject
    {
        /// <summary>
        /// The reason of the status. 
        /// </summary>
        /// <value>The reason of the status. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum EXPIREDCARD for "EXPIRED_CARD"
            /// </summary>
            [EnumMember(Value = "EXPIRED_CARD")]
            EXPIREDCARD,
            
            /// <summary>
            /// Enum PROCESSORDECLINED for "PROCESSOR_DECLINED"
            /// </summary>
            [EnumMember(Value = "PROCESSOR_DECLINED")]
            PROCESSORDECLINED,
            
            /// <summary>
            /// Enum STOLENLOSTCARD for "STOLEN_LOST_CARD"
            /// </summary>
            [EnumMember(Value = "STOLEN_LOST_CARD")]
            STOLENLOSTCARD,
            
            /// <summary>
            /// Enum UNAUTHORIZEDCARD for "UNAUTHORIZED_CARD"
            /// </summary>
            [EnumMember(Value = "UNAUTHORIZED_CARD")]
            UNAUTHORIZEDCARD,
            
            /// <summary>
            /// Enum CVNNOTMATCH for "CVN_NOT_MATCH"
            /// </summary>
            [EnumMember(Value = "CVN_NOT_MATCH")]
            CVNNOTMATCH,
            
            /// <summary>
            /// Enum INVALIDCVN for "INVALID_CVN"
            /// </summary>
            [EnumMember(Value = "INVALID_CVN")]
            INVALIDCVN,
            
            /// <summary>
            /// Enum BLACKLISTEDCUSTOMER for "BLACKLISTED_CUSTOMER"
            /// </summary>
            [EnumMember(Value = "BLACKLISTED_CUSTOMER")]
            BLACKLISTEDCUSTOMER,
            
            /// <summary>
            /// Enum INVALIDACCOUNT for "INVALID_ACCOUNT"
            /// </summary>
            [EnumMember(Value = "INVALID_ACCOUNT")]
            INVALIDACCOUNT,
            
            /// <summary>
            /// Enum GENERALDECLINE for "GENERAL_DECLINE"
            /// </summary>
            [EnumMember(Value = "GENERAL_DECLINE")]
            GENERALDECLINE,
            
            /// <summary>
            /// Enum RISKCONTROLDECLINE for "RISK_CONTROL_DECLINE"
            /// </summary>
            [EnumMember(Value = "RISK_CONTROL_DECLINE")]
            RISKCONTROLDECLINE,
            
            /// <summary>
            /// Enum PROCESSORRISKCONTROLDECLINE for "PROCESSOR_RISK_CONTROL_DECLINE"
            /// </summary>
            [EnumMember(Value = "PROCESSOR_RISK_CONTROL_DECLINE")]
            PROCESSORRISKCONTROLDECLINE
        }

        /// <summary>
        /// The reason of the status. 
        /// </summary>
        /// <value>The reason of the status. </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PayoutsPost201ResponseErrorInformation" /> class.
        /// </summary>
        /// <param name="Reason">The reason of the status. .</param>
        /// <param name="Message">The detail message related to the status and reason listed above..</param>
        /// <param name="Details">Details.</param>
        public PtsV2PayoutsPost201ResponseErrorInformation(ReasonEnum? Reason = default(ReasonEnum?), string Message = default(string), List<PtsV2PayoutsPost201ResponseErrorInformationDetails> Details = default(List<PtsV2PayoutsPost201ResponseErrorInformationDetails>))
        {
            this.Reason = Reason;
            this.Message = Message;
            this.Details = Details;
        }
        

        /// <summary>
        /// The detail message related to the status and reason listed above.
        /// </summary>
        /// <value>The detail message related to the status and reason listed above.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<PtsV2PayoutsPost201ResponseErrorInformationDetails> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PayoutsPost201ResponseErrorInformation {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as PtsV2PayoutsPost201ResponseErrorInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PayoutsPost201ResponseErrorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PayoutsPost201ResponseErrorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PayoutsPost201ResponseErrorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
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
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
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
