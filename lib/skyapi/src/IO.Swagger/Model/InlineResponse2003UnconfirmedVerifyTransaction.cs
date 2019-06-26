/* 
 * Skycoin REST API.
 *
 * Skycoin is a next-generation cryptocurrency.
 *
 * OpenAPI spec version: 0.25.1
 * Contact: contact@skycoin.net
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Represent unconfirmed transactions
    /// </summary>
    [DataContract]
    public partial class InlineResponse2003UnconfirmedVerifyTransaction :  IEquatable<InlineResponse2003UnconfirmedVerifyTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003UnconfirmedVerifyTransaction" /> class.
        /// </summary>
        /// <param name="burnFactor">burnFactor.</param>
        /// <param name="maxDecimals">maxDecimals.</param>
        /// <param name="maxTransactionSize">maxTransactionSize.</param>
        public InlineResponse2003UnconfirmedVerifyTransaction(int? burnFactor = default(int?), int? maxDecimals = default(int?), int? maxTransactionSize = default(int?))
        {
            this.BurnFactor = burnFactor;
            this.MaxDecimals = maxDecimals;
            this.MaxTransactionSize = maxTransactionSize;
        }
        
        /// <summary>
        /// Gets or Sets BurnFactor
        /// </summary>
        [DataMember(Name="burn_factor", EmitDefaultValue=false)]
        public int? BurnFactor { get; set; }

        /// <summary>
        /// Gets or Sets MaxDecimals
        /// </summary>
        [DataMember(Name="max_decimals", EmitDefaultValue=false)]
        public int? MaxDecimals { get; set; }

        /// <summary>
        /// Gets or Sets MaxTransactionSize
        /// </summary>
        [DataMember(Name="max_transaction_size", EmitDefaultValue=false)]
        public int? MaxTransactionSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2003UnconfirmedVerifyTransaction {\n");
            sb.Append("  BurnFactor: ").Append(BurnFactor).Append("\n");
            sb.Append("  MaxDecimals: ").Append(MaxDecimals).Append("\n");
            sb.Append("  MaxTransactionSize: ").Append(MaxTransactionSize).Append("\n");
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
            return this.Equals(input as InlineResponse2003UnconfirmedVerifyTransaction);
        }

        /// <summary>
        /// Returns true if InlineResponse2003UnconfirmedVerifyTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2003UnconfirmedVerifyTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2003UnconfirmedVerifyTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BurnFactor == input.BurnFactor ||
                    (this.BurnFactor != null &&
                    this.BurnFactor.Equals(input.BurnFactor))
                ) && 
                (
                    this.MaxDecimals == input.MaxDecimals ||
                    (this.MaxDecimals != null &&
                    this.MaxDecimals.Equals(input.MaxDecimals))
                ) && 
                (
                    this.MaxTransactionSize == input.MaxTransactionSize ||
                    (this.MaxTransactionSize != null &&
                    this.MaxTransactionSize.Equals(input.MaxTransactionSize))
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
                if (this.BurnFactor != null)
                    hashCode = hashCode * 59 + this.BurnFactor.GetHashCode();
                if (this.MaxDecimals != null)
                    hashCode = hashCode * 59 + this.MaxDecimals.GetHashCode();
                if (this.MaxTransactionSize != null)
                    hashCode = hashCode * 59 + this.MaxTransactionSize.GetHashCode();
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
