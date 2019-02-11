/* 
 * Skycoin REST API.
 *
 * Skycoin is a next-generation cryptocurrency.
 *
 * OpenAPI spec version: 0.25.0
 * Contact: skycoin.doe@example.com
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
    /// InlineResponse2005
    /// </summary>
    [DataContract]
    public partial class InlineResponse2005 :  IEquatable<InlineResponse2005>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2005" /> class.
        /// </summary>
        /// <param name="Current">Current.</param>
        /// <param name="Highest">Highest.</param>
        /// <param name="Peers">Peers.</param>
        public InlineResponse2005(long? Current = default(long?), long? Highest = default(long?), List<InlineResponse2005Peers> Peers = default(List<InlineResponse2005Peers>))
        {
            this.Current = Current;
            this.Highest = Highest;
            this.Peers = Peers;
        }
        
        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name="current", EmitDefaultValue=false)]
        public long? Current { get; set; }

        /// <summary>
        /// Gets or Sets Highest
        /// </summary>
        [DataMember(Name="highest", EmitDefaultValue=false)]
        public long? Highest { get; set; }

        /// <summary>
        /// Gets or Sets Peers
        /// </summary>
        [DataMember(Name="peers", EmitDefaultValue=false)]
        public List<InlineResponse2005Peers> Peers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2005 {\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  Highest: ").Append(Highest).Append("\n");
            sb.Append("  Peers: ").Append(Peers).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse2005);
        }

        /// <summary>
        /// Returns true if InlineResponse2005 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2005 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2005 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Current == input.Current ||
                    (this.Current != null &&
                    this.Current.Equals(input.Current))
                ) && 
                (
                    this.Highest == input.Highest ||
                    (this.Highest != null &&
                    this.Highest.Equals(input.Highest))
                ) && 
                (
                    this.Peers == input.Peers ||
                    this.Peers != null &&
                    this.Peers.SequenceEqual(input.Peers)
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
                if (this.Current != null)
                    hashCode = hashCode * 59 + this.Current.GetHashCode();
                if (this.Highest != null)
                    hashCode = hashCode * 59 + this.Highest.GetHashCode();
                if (this.Peers != null)
                    hashCode = hashCode * 59 + this.Peers.GetHashCode();
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
