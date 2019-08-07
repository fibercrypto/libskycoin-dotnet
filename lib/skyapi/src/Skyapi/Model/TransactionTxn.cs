/* 
 * Skycoin REST API.
 *
 * Skycoin is a next-generation cryptocurrency.
 *
 * The version of the OpenAPI document: 0.27.0
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
using OpenAPIDateConverter = Skyapi.Client.OpenAPIDateConverter;

namespace Skyapi.Model
{
    /// <summary>
    /// TransactionVerbose has readable transaction data. It adds TransactionStatus to a BlockTransactionVerbose
    /// </summary>
    [DataContract]
    public partial class TransactionTxn :  IEquatable<TransactionTxn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTxn" /> class.
        /// </summary>
        /// <param name="innerHash">innerHash.</param>
        /// <param name="inputs">inputs.</param>
        /// <param name="length">length.</param>
        /// <param name="outputs">outputs.</param>
        /// <param name="sigs">sigs.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="txid">txid.</param>
        /// <param name="type">type.</param>
        public TransactionTxn(string innerHash = default(string), List<string> inputs = default(List<string>), int? length = default(int?), List<Object> outputs = default(List<Object>), List<string> sigs = default(List<string>), long? timestamp = default(long?), string txid = default(string), int? type = default(int?))
        {
            this.InnerHash = innerHash;
            this.Inputs = inputs;
            this.Length = length;
            this.Outputs = outputs;
            this.Sigs = sigs;
            this.Timestamp = timestamp;
            this.Txid = txid;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets InnerHash
        /// </summary>
        [DataMember(Name="inner_hash", EmitDefaultValue=false)]
        public string InnerHash { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<string> Inputs { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public List<Object> Outputs { get; set; }

        /// <summary>
        /// Gets or Sets Sigs
        /// </summary>
        [DataMember(Name="sigs", EmitDefaultValue=false)]
        public List<string> Sigs { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Txid
        /// </summary>
        [DataMember(Name="txid", EmitDefaultValue=false)]
        public string Txid { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionTxn {\n");
            sb.Append("  InnerHash: ").Append(InnerHash).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Sigs: ").Append(Sigs).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Txid: ").Append(Txid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TransactionTxn);
        }

        /// <summary>
        /// Returns true if TransactionTxn instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionTxn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionTxn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InnerHash == input.InnerHash ||
                    (this.InnerHash != null &&
                    this.InnerHash.Equals(input.InnerHash))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
                ) && 
                (
                    this.Sigs == input.Sigs ||
                    this.Sigs != null &&
                    input.Sigs != null &&
                    this.Sigs.SequenceEqual(input.Sigs)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Txid == input.Txid ||
                    (this.Txid != null &&
                    this.Txid.Equals(input.Txid))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.InnerHash != null)
                    hashCode = hashCode * 59 + this.InnerHash.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.Sigs != null)
                    hashCode = hashCode * 59 + this.Sigs.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Txid != null)
                    hashCode = hashCode * 59 + this.Txid.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
