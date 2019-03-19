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
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PayoutsPost201ResponseMerchantInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PayoutsPost201ResponseMerchantInformation :  IEquatable<PtsV2PayoutsPost201ResponseMerchantInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PayoutsPost201ResponseMerchantInformation" /> class.
        /// </summary>
        /// <param name="MerchantDescriptor">MerchantDescriptor.</param>
        public PtsV2PayoutsPost201ResponseMerchantInformation(PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor MerchantDescriptor = default(PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor))
        {
            this.MerchantDescriptor = MerchantDescriptor;
        }
        
        /// <summary>
        /// Gets or Sets MerchantDescriptor
        /// </summary>
        [DataMember(Name="merchantDescriptor", EmitDefaultValue=false)]
        public PtsV2PayoutsPost201ResponseMerchantInformationMerchantDescriptor MerchantDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PayoutsPost201ResponseMerchantInformation {\n");
            sb.Append("  MerchantDescriptor: ").Append(MerchantDescriptor).Append("\n");
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
            return this.Equals(obj as PtsV2PayoutsPost201ResponseMerchantInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PayoutsPost201ResponseMerchantInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PayoutsPost201ResponseMerchantInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PayoutsPost201ResponseMerchantInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantDescriptor == other.MerchantDescriptor ||
                    this.MerchantDescriptor != null &&
                    this.MerchantDescriptor.Equals(other.MerchantDescriptor)
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
                if (this.MerchantDescriptor != null)
                    hash = hash * 59 + this.MerchantDescriptor.GetHashCode();
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
