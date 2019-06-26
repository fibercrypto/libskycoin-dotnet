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
    /// InlineResponse2003
    /// </summary>
    [DataContract]
    public partial class InlineResponse2003 :  IEquatable<InlineResponse2003>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,
            
            /// <summary>
            /// Enum Connected for value: connected
            /// </summary>
            [EnumMember(Value = "connected")]
            Connected = 2,
            
            /// <summary>
            /// Enum Introduced for value: introduced
            /// </summary>
            [EnumMember(Value = "introduced")]
            Introduced = 3
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="connectedAt">connectedAt.</param>
        /// <param name="height">height.</param>
        /// <param name="id">id.</param>
        /// <param name="isTrustedPeer">isTrustedPeer.</param>
        /// <param name="lastReceived">lastReceived.</param>
        /// <param name="lastSent">lastSent.</param>
        /// <param name="listenPort">listenPort.</param>
        /// <param name="mirror">mirror.</param>
        /// <param name="outgoing">outgoing.</param>
        /// <param name="state">state.</param>
        /// <param name="unconfirmedVerifyTransaction">unconfirmedVerifyTransaction.</param>
        /// <param name="userAgent">userAgent.</param>
        public InlineResponse2003(string address = default(string), long? connectedAt = default(long?), long? height = default(long?), long? id = default(long?), bool? isTrustedPeer = default(bool?), long? lastReceived = default(long?), long? lastSent = default(long?), int? listenPort = default(int?), int? mirror = default(int?), bool? outgoing = default(bool?), StateEnum? state = default(StateEnum?), InlineResponse2003UnconfirmedVerifyTransaction unconfirmedVerifyTransaction = default(InlineResponse2003UnconfirmedVerifyTransaction), string userAgent = default(string))
        {
            this.Address = address;
            this.ConnectedAt = connectedAt;
            this.Height = height;
            this.Id = id;
            this.IsTrustedPeer = isTrustedPeer;
            this.LastReceived = lastReceived;
            this.LastSent = lastSent;
            this.ListenPort = listenPort;
            this.Mirror = mirror;
            this.Outgoing = outgoing;
            this.State = state;
            this.UnconfirmedVerifyTransaction = unconfirmedVerifyTransaction;
            this.UserAgent = userAgent;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets ConnectedAt
        /// </summary>
        [DataMember(Name="connected_at", EmitDefaultValue=false)]
        public long? ConnectedAt { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public long? Height { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets IsTrustedPeer
        /// </summary>
        [DataMember(Name="is_trusted_peer", EmitDefaultValue=false)]
        public bool? IsTrustedPeer { get; set; }

        /// <summary>
        /// Gets or Sets LastReceived
        /// </summary>
        [DataMember(Name="last_received", EmitDefaultValue=false)]
        public long? LastReceived { get; set; }

        /// <summary>
        /// Gets or Sets LastSent
        /// </summary>
        [DataMember(Name="last_sent", EmitDefaultValue=false)]
        public long? LastSent { get; set; }

        /// <summary>
        /// Gets or Sets ListenPort
        /// </summary>
        [DataMember(Name="listen_port", EmitDefaultValue=false)]
        public int? ListenPort { get; set; }

        /// <summary>
        /// Gets or Sets Mirror
        /// </summary>
        [DataMember(Name="mirror", EmitDefaultValue=false)]
        public int? Mirror { get; set; }

        /// <summary>
        /// Gets or Sets Outgoing
        /// </summary>
        [DataMember(Name="outgoing", EmitDefaultValue=false)]
        public bool? Outgoing { get; set; }


        /// <summary>
        /// Gets or Sets UnconfirmedVerifyTransaction
        /// </summary>
        [DataMember(Name="unconfirmed_verify_transaction", EmitDefaultValue=false)]
        public InlineResponse2003UnconfirmedVerifyTransaction UnconfirmedVerifyTransaction { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name="user_agent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2003 {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ConnectedAt: ").Append(ConnectedAt).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsTrustedPeer: ").Append(IsTrustedPeer).Append("\n");
            sb.Append("  LastReceived: ").Append(LastReceived).Append("\n");
            sb.Append("  LastSent: ").Append(LastSent).Append("\n");
            sb.Append("  ListenPort: ").Append(ListenPort).Append("\n");
            sb.Append("  Mirror: ").Append(Mirror).Append("\n");
            sb.Append("  Outgoing: ").Append(Outgoing).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UnconfirmedVerifyTransaction: ").Append(UnconfirmedVerifyTransaction).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
            return this.Equals(input as InlineResponse2003);
        }

        /// <summary>
        /// Returns true if InlineResponse2003 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2003 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2003 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ConnectedAt == input.ConnectedAt ||
                    (this.ConnectedAt != null &&
                    this.ConnectedAt.Equals(input.ConnectedAt))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsTrustedPeer == input.IsTrustedPeer ||
                    (this.IsTrustedPeer != null &&
                    this.IsTrustedPeer.Equals(input.IsTrustedPeer))
                ) && 
                (
                    this.LastReceived == input.LastReceived ||
                    (this.LastReceived != null &&
                    this.LastReceived.Equals(input.LastReceived))
                ) && 
                (
                    this.LastSent == input.LastSent ||
                    (this.LastSent != null &&
                    this.LastSent.Equals(input.LastSent))
                ) && 
                (
                    this.ListenPort == input.ListenPort ||
                    (this.ListenPort != null &&
                    this.ListenPort.Equals(input.ListenPort))
                ) && 
                (
                    this.Mirror == input.Mirror ||
                    (this.Mirror != null &&
                    this.Mirror.Equals(input.Mirror))
                ) && 
                (
                    this.Outgoing == input.Outgoing ||
                    (this.Outgoing != null &&
                    this.Outgoing.Equals(input.Outgoing))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.UnconfirmedVerifyTransaction == input.UnconfirmedVerifyTransaction ||
                    (this.UnconfirmedVerifyTransaction != null &&
                    this.UnconfirmedVerifyTransaction.Equals(input.UnconfirmedVerifyTransaction))
                ) && 
                (
                    this.UserAgent == input.UserAgent ||
                    (this.UserAgent != null &&
                    this.UserAgent.Equals(input.UserAgent))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ConnectedAt != null)
                    hashCode = hashCode * 59 + this.ConnectedAt.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsTrustedPeer != null)
                    hashCode = hashCode * 59 + this.IsTrustedPeer.GetHashCode();
                if (this.LastReceived != null)
                    hashCode = hashCode * 59 + this.LastReceived.GetHashCode();
                if (this.LastSent != null)
                    hashCode = hashCode * 59 + this.LastSent.GetHashCode();
                if (this.ListenPort != null)
                    hashCode = hashCode * 59 + this.ListenPort.GetHashCode();
                if (this.Mirror != null)
                    hashCode = hashCode * 59 + this.Mirror.GetHashCode();
                if (this.Outgoing != null)
                    hashCode = hashCode * 59 + this.Outgoing.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.UnconfirmedVerifyTransaction != null)
                    hashCode = hashCode * 59 + this.UnconfirmedVerifyTransaction.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
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
