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
    /// TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf
    /// </summary>
    [DataContract]
    public partial class TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf :  IEquatable<TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf" /> class.
        /// </summary>
        /// <param name="Href">A link to the current requested collection..</param>
        public TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf(string Href = default(string))
        {
            this.Href = Href;
        }
        
        /// <summary>
        /// A link to the current requested collection.
        /// </summary>
        /// <value>A link to the current requested collection.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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
            return this.Equals(obj as TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf);
        }

        /// <summary>
        /// Returns true if TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksSelf other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
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
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
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
