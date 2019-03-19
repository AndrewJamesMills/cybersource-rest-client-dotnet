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

namespace CyberSource.Model
{
    /// <summary>
    /// V1FileDetailsGet200ResponseLinks
    /// </summary>
    [DataContract]
    public partial class V1FileDetailsGet200ResponseLinks :  IEquatable<V1FileDetailsGet200ResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1FileDetailsGet200ResponseLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="Files">Files.</param>
        public V1FileDetailsGet200ResponseLinks(V1FileDetailsGet200ResponseLinksSelf Self = default(V1FileDetailsGet200ResponseLinksSelf), List<V1FileDetailsGet200ResponseLinksFiles> Files = default(List<V1FileDetailsGet200ResponseLinksFiles>))
        {
            this.Self = Self;
            this.Files = Files;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public V1FileDetailsGet200ResponseLinksSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<V1FileDetailsGet200ResponseLinksFiles> Files { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1FileDetailsGet200ResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
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
            return this.Equals(obj as V1FileDetailsGet200ResponseLinks);
        }

        /// <summary>
        /// Returns true if V1FileDetailsGet200ResponseLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of V1FileDetailsGet200ResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1FileDetailsGet200ResponseLinks other)
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
                    this.Files == other.Files ||
                    this.Files != null &&
                    this.Files.SequenceEqual(other.Files)
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
                if (this.Files != null)
                    hash = hash * 59 + this.Files.GetHashCode();
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
