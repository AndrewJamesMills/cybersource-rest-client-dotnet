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
using Newtonsoft.Json.Converters;

namespace CyberSource.Model
{
    /// <summary>
    /// Body2
    /// </summary>
    [DataContract]
    public partial class Body2 :  IEquatable<Body2>, IValidatableObject
    {
        /// <summary>
        /// Describes type of token. For example: customer, paymentInstrument or instrumentIdentifier.
        /// </summary>
        /// <value>Describes type of token. For example: customer, paymentInstrument or instrumentIdentifier.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            
            /// <summary>
            /// Enum PaymentInstrument for "paymentInstrument"
            /// </summary>
            [EnumMember(Value = "paymentInstrument")]
            PaymentInstrument
        }

        /// <summary>
        /// Current state of the token.
        /// </summary>
        /// <value>Current state of the token.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum ACTIVE for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE,
            
            /// <summary>
            /// Enum CLOSED for "CLOSED"
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED
        }

        /// <summary>
        /// Describes type of token. For example: customer, paymentInstrument or instrumentIdentifier.
        /// </summary>
        /// <value>Describes type of token. For example: customer, paymentInstrument or instrumentIdentifier.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum? _Object { get; set; }
        /// <summary>
        /// Current state of the token.
        /// </summary>
        /// <value>Current state of the token.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Body2" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="BankAccount">BankAccount.</param>
        /// <param name="Card">Card.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="BillTo">BillTo.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="MerchantInformation">MerchantInformation.</param>
        /// <param name="MetaData">MetaData.</param>
        /// <param name="InstrumentIdentifier">InstrumentIdentifier.</param>
        public Body2(Tmsv1instrumentidentifiersLinks Links = default(Tmsv1instrumentidentifiersLinks), Tmsv1paymentinstrumentsBankAccount BankAccount = default(Tmsv1paymentinstrumentsBankAccount), Tmsv1paymentinstrumentsCard Card = default(Tmsv1paymentinstrumentsCard), Tmsv1paymentinstrumentsBuyerInformation BuyerInformation = default(Tmsv1paymentinstrumentsBuyerInformation), Tmsv1paymentinstrumentsBillTo BillTo = default(Tmsv1paymentinstrumentsBillTo), Tmsv1paymentinstrumentsProcessingInformation ProcessingInformation = default(Tmsv1paymentinstrumentsProcessingInformation), Tmsv1paymentinstrumentsMerchantInformation MerchantInformation = default(Tmsv1paymentinstrumentsMerchantInformation), Tmsv1instrumentidentifiersMetadata MetaData = default(Tmsv1instrumentidentifiersMetadata), Tmsv1paymentinstrumentsInstrumentIdentifier InstrumentIdentifier = default(Tmsv1paymentinstrumentsInstrumentIdentifier))
        {
            this.Links = Links;
            this.BankAccount = BankAccount;
            this.Card = Card;
            this.BuyerInformation = BuyerInformation;
            this.BillTo = BillTo;
            this.ProcessingInformation = ProcessingInformation;
            this.MerchantInformation = MerchantInformation;
            this.MetaData = MetaData;
            this.InstrumentIdentifier = InstrumentIdentifier;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public Tmsv1instrumentidentifiersLinks Links { get; set; }

        /// <summary>
        /// Unique identification number assigned by CyberSource to the submitted request.
        /// </summary>
        /// <value>Unique identification number assigned by CyberSource to the submitted request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bankAccount", EmitDefaultValue=false)]
        public Tmsv1paymentinstrumentsBankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public Tmsv1paymentinstrumentsCard Card { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public Tmsv1paymentinstrumentsBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="billTo", EmitDefaultValue=false)]
        public Tmsv1paymentinstrumentsBillTo BillTo { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public Tmsv1paymentinstrumentsProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInformation
        /// </summary>
        [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
        public Tmsv1paymentinstrumentsMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public Tmsv1instrumentidentifiersMetadata MetaData { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentIdentifier
        /// </summary>
        [DataMember(Name="instrumentIdentifier", EmitDefaultValue=false)]
        public Tmsv1paymentinstrumentsInstrumentIdentifier InstrumentIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body2 {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  InstrumentIdentifier: ").Append(InstrumentIdentifier).Append("\n");
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
            return this.Equals(obj as Body2);
        }

        /// <summary>
        /// Returns true if Body2 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body2 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.BankAccount == other.BankAccount ||
                    this.BankAccount != null &&
                    this.BankAccount.Equals(other.BankAccount)
                ) && 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.BillTo == other.BillTo ||
                    this.BillTo != null &&
                    this.BillTo.Equals(other.BillTo)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.MerchantInformation == other.MerchantInformation ||
                    this.MerchantInformation != null &&
                    this.MerchantInformation.Equals(other.MerchantInformation)
                ) && 
                (
                    this.MetaData == other.MetaData ||
                    this.MetaData != null &&
                    this.MetaData.Equals(other.MetaData)
                ) && 
                (
                    this.InstrumentIdentifier == other.InstrumentIdentifier ||
                    this.InstrumentIdentifier != null &&
                    this.InstrumentIdentifier.Equals(other.InstrumentIdentifier)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.BankAccount != null)
                    hash = hash * 59 + this.BankAccount.GetHashCode();
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.BillTo != null)
                    hash = hash * 59 + this.BillTo.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.MerchantInformation != null)
                    hash = hash * 59 + this.MerchantInformation.GetHashCode();
                if (this.MetaData != null)
                    hash = hash * 59 + this.MetaData.GetHashCode();
                if (this.InstrumentIdentifier != null)
                    hash = hash * 59 + this.InstrumentIdentifier.GetHashCode();
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
