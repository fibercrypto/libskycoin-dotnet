/* 
 * Skycoin REST API.
 *
 * Skycoin is a next-generation cryptocurrency.
 *
 * OpenAPI spec version: 0.25.1
 * Contact: contact@skycoin.net
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = RestCSharp.Client.OpenAPIDateConverter;

namespace RestCSharp.Model
{
    /// <summary>
    /// Apiv1exploreraddressStatus
    /// </summary>
    [DataContract]
    public partial class Apiv1exploreraddressStatus :  IEquatable<Apiv1exploreraddressStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apiv1exploreraddressStatus" /> class.
        /// </summary>
        /// <param name="unconfirmed">unconfirmed.</param>
        /// <param name="blockSeq">blockSeq.</param>
        /// <param name="label">label.</param>
        /// <param name="confirmed">confirmed.</param>
        public Apiv1exploreraddressStatus(bool? unconfirmed = default(bool?), long? blockSeq = default(long?), long? label = default(long?), bool? confirmed = default(bool?))
        {
            this.Unconfirmed = unconfirmed;
            this.BlockSeq = blockSeq;
            this.Label = label;
            this.Confirmed = confirmed;
        }
        
        /// <summary>
        /// Gets or Sets Unconfirmed
        /// </summary>
        [DataMember(Name="unconfirmed", EmitDefaultValue=false)]
        public bool? Unconfirmed { get; set; }

        /// <summary>
        /// Gets or Sets BlockSeq
        /// </summary>
        [DataMember(Name="block_seq", EmitDefaultValue=false)]
        public long? BlockSeq { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public long? Label { get; set; }

        /// <summary>
        /// Gets or Sets Confirmed
        /// </summary>
        [DataMember(Name="confirmed", EmitDefaultValue=false)]
        public bool? Confirmed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Apiv1exploreraddressStatus {\n");
            sb.Append("  Unconfirmed: ").Append(Unconfirmed).Append("\n");
            sb.Append("  BlockSeq: ").Append(BlockSeq).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Confirmed: ").Append(Confirmed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Apiv1exploreraddressStatus);
        }

        /// <summary>
        /// Returns true if Apiv1exploreraddressStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of Apiv1exploreraddressStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Apiv1exploreraddressStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Unconfirmed == input.Unconfirmed ||
                    (this.Unconfirmed != null &&
                    this.Unconfirmed.Equals(input.Unconfirmed))
                ) && 
                (
                    this.BlockSeq == input.BlockSeq ||
                    (this.BlockSeq != null &&
                    this.BlockSeq.Equals(input.BlockSeq))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Confirmed == input.Confirmed ||
                    (this.Confirmed != null &&
                    this.Confirmed.Equals(input.Confirmed))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Unconfirmed != null)
                    hashCode = hashCode * 59 + this.Unconfirmed.GetHashCode();
                if (this.BlockSeq != null)
                    hashCode = hashCode * 59 + this.BlockSeq.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Confirmed != null)
                    hashCode = hashCode * 59 + this.Confirmed.GetHashCode();
                return hashCode;
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