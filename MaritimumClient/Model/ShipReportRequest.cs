/*
 * Maritimum
 *
 * a sample API to return ships and ports information.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = MaritimumClient.Client.OpenAPIDateConverter;

namespace MaritimumClient.Model
{
    /// <summary>
    /// UUID of the homeport, minimal tonnage and maximum tonnage used to filter the reported existing ships.
    /// </summary>
    [DataContract(Name = "ShipReportRequest")]
    public partial class ShipReportRequest : IEquatable<ShipReportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipReportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipReportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipReportRequest" /> class.
        /// </summary>
        /// <param name="homePortUuid">UUID of home port. (required).</param>
        /// <param name="maxTonnage">Maximum tonnage..</param>
        /// <param name="minTonnage">Mminimum tonnage..</param>
        public ShipReportRequest(Guid homePortUuid = default(Guid), int? maxTonnage = default(int?), int? minTonnage = default(int?))
        {
            this.HomePortUuid = homePortUuid;
            this.MaxTonnage = maxTonnage;
            this.MinTonnage = minTonnage;
        }

        /// <summary>
        /// UUID of home port.
        /// </summary>
        /// <value>UUID of home port.</value>
        [DataMember(Name = "home_port_uuid", IsRequired = true, EmitDefaultValue = false)]
        public Guid HomePortUuid { get; set; }

        /// <summary>
        /// Maximum tonnage.
        /// </summary>
        /// <value>Maximum tonnage.</value>
        [DataMember(Name = "max_tonnage", EmitDefaultValue = true)]
        public int? MaxTonnage { get; set; }

        /// <summary>
        /// Mminimum tonnage.
        /// </summary>
        /// <value>Mminimum tonnage.</value>
        [DataMember(Name = "min_tonnage", EmitDefaultValue = true)]
        public int? MinTonnage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipReportRequest {\n");
            sb.Append("  HomePortUuid: ").Append(HomePortUuid).Append("\n");
            sb.Append("  MaxTonnage: ").Append(MaxTonnage).Append("\n");
            sb.Append("  MinTonnage: ").Append(MinTonnage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShipReportRequest);
        }

        /// <summary>
        /// Returns true if ShipReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipReportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HomePortUuid == input.HomePortUuid ||
                    (this.HomePortUuid != null &&
                    this.HomePortUuid.Equals(input.HomePortUuid))
                ) && 
                (
                    this.MaxTonnage == input.MaxTonnage ||
                    (this.MaxTonnage != null &&
                    this.MaxTonnage.Equals(input.MaxTonnage))
                ) && 
                (
                    this.MinTonnage == input.MinTonnage ||
                    (this.MinTonnage != null &&
                    this.MinTonnage.Equals(input.MinTonnage))
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
                if (this.HomePortUuid != null)
                    hashCode = hashCode * 59 + this.HomePortUuid.GetHashCode();
                if (this.MaxTonnage != null)
                    hashCode = hashCode * 59 + this.MaxTonnage.GetHashCode();
                if (this.MinTonnage != null)
                    hashCode = hashCode * 59 + this.MinTonnage.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // MaxTonnage (int?) minimum
            if(this.MaxTonnage < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxTonnage, must be a value greater than or equal to 1.", new [] { "MaxTonnage" });
            }

            // MinTonnage (int?) minimum
            if(this.MinTonnage < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinTonnage, must be a value greater than or equal to 1.", new [] { "MinTonnage" });
            }

            yield break;
        }
    }

}
