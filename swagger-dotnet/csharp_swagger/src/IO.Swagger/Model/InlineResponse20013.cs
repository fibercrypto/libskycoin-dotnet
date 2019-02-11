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
    /// InlineResponse20013
    /// </summary>
    [DataContract]
    public partial class InlineResponse20013 :  IEquatable<InlineResponse20013>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20013" /> class.
        /// </summary>
        /// <param name="Richlist">Richlist.</param>
        public InlineResponse20013(List<InlineResponse20013Richlist> Richlist = default(List<InlineResponse20013Richlist>))
        {
            this.Richlist = Richlist;
        }
        
        /// <summary>
        /// Gets or Sets Richlist
        /// </summary>
        [DataMember(Name="richlist", EmitDefaultValue=false)]
        public List<InlineResponse20013Richlist> Richlist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20013 {\n");
            sb.Append("  Richlist: ").Append(Richlist).Append("\n");
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
            return this.Equals(input as InlineResponse20013);
        }

        /// <summary>
        /// Returns true if InlineResponse20013 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20013 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20013 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Richlist == input.Richlist ||
                    this.Richlist != null &&
                    this.Richlist.SequenceEqual(input.Richlist)
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
                if (this.Richlist != null)
                    hashCode = hashCode * 59 + this.Richlist.GetHashCode();
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
