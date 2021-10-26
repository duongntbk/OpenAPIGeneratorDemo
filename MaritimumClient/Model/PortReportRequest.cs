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
    /// Home country and deep water flag used to filter the reported existing port.
    /// </summary>
    [DataContract(Name = "PortReportRequest")]
    public partial class PortReportRequest : IEquatable<PortReportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortReportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortReportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortReportRequest" /> class.
        /// </summary>
        /// <param name="country">Port&#39;s country. (required).</param>
        /// <param name="isDeepWater">Whether this port is a deep water port..</param>
        public PortReportRequest(string country = default(string), bool? isDeepWater = default(bool?))
        {
            // to ensure "country" is required (not null)
            if (country == null) {
                throw new ArgumentNullException("country is a required property for PortReportRequest and cannot be null");
            }
            this.Country = country;
            this.IsDeepWater = isDeepWater;
        }

        /// <summary>
        /// Port&#39;s country.
        /// </summary>
        /// <value>Port&#39;s country.</value>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Whether this port is a deep water port.
        /// </summary>
        /// <value>Whether this port is a deep water port.</value>
        [DataMember(Name = "is_deep_water", EmitDefaultValue = true)]
        public bool? IsDeepWater { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortReportRequest {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  IsDeepWater: ").Append(IsDeepWater).Append("\n");
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
            return this.Equals(input as PortReportRequest);
        }

        /// <summary>
        /// Returns true if PortReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PortReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortReportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.IsDeepWater == input.IsDeepWater ||
                    (this.IsDeepWater != null &&
                    this.IsDeepWater.Equals(input.IsDeepWater))
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
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.IsDeepWater != null)
                    hashCode = hashCode * 59 + this.IsDeepWater.GetHashCode();
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
            yield break;
        }
    }

}
