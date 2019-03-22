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
    /// Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions
    /// </summary>
    [DataContract]
    public partial class Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions :  IEquatable<Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions" /> class.
        /// </summary>
        /// <param name="Initiator">Initiator.</param>
        public Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions(Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptionsInitiator Initiator = default(Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptionsInitiator))
        {
            this.Initiator = Initiator;
        }
        
        /// <summary>
        /// Gets or Sets Initiator
        /// </summary>
        [DataMember(Name="initiator", EmitDefaultValue=false)]
        public Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptionsInitiator Initiator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions {\n");
            sb.Append("  Initiator: ").Append(Initiator).Append("\n");
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
            return this.Equals(obj as Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions);
        }

        /// <summary>
        /// Returns true if Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tmsv1instrumentidentifiersProcessingInformationAuthorizationOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Initiator == other.Initiator ||
                    this.Initiator != null &&
                    this.Initiator.Equals(other.Initiator)
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
                if (this.Initiator != null)
                    hash = hash * 59 + this.Initiator.GetHashCode();
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
