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
    /// Tmsv1instrumentidentifiersLinks
    /// </summary>
    [DataContract]
    public partial class Tmsv1instrumentidentifiersLinks :  IEquatable<Tmsv1instrumentidentifiersLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmsv1instrumentidentifiersLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="Ancestor">Ancestor.</param>
        /// <param name="Successor">Successor.</param>
        public Tmsv1instrumentidentifiersLinks(Tmsv1instrumentidentifiersLinksSelf Self = default(Tmsv1instrumentidentifiersLinksSelf), Tmsv1instrumentidentifiersLinksSelf Ancestor = default(Tmsv1instrumentidentifiersLinksSelf), Tmsv1instrumentidentifiersLinksSelf Successor = default(Tmsv1instrumentidentifiersLinksSelf))
        {
            this.Self = Self;
            this.Ancestor = Ancestor;
            this.Successor = Successor;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public Tmsv1instrumentidentifiersLinksSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets Ancestor
        /// </summary>
        [DataMember(Name="ancestor", EmitDefaultValue=false)]
        public Tmsv1instrumentidentifiersLinksSelf Ancestor { get; set; }

        /// <summary>
        /// Gets or Sets Successor
        /// </summary>
        [DataMember(Name="successor", EmitDefaultValue=false)]
        public Tmsv1instrumentidentifiersLinksSelf Successor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tmsv1instrumentidentifiersLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Ancestor: ").Append(Ancestor).Append("\n");
            sb.Append("  Successor: ").Append(Successor).Append("\n");
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
            return this.Equals(obj as Tmsv1instrumentidentifiersLinks);
        }

        /// <summary>
        /// Returns true if Tmsv1instrumentidentifiersLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of Tmsv1instrumentidentifiersLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tmsv1instrumentidentifiersLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Ancestor == other.Ancestor ||
                    this.Ancestor != null &&
                    this.Ancestor.Equals(other.Ancestor)
                ) && 
                (
                    this.Successor == other.Successor ||
                    this.Successor != null &&
                    this.Successor.Equals(other.Successor)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.Ancestor != null)
                    hash = hash * 59 + this.Ancestor.GetHashCode();
                if (this.Successor != null)
                    hash = hash * 59 + this.Successor.GetHashCode();
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
