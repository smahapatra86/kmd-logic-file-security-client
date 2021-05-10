// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.FileSecurity.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CertificateResponse
    {
        /// <summary>
        /// Initializes a new instance of the CertificateResponse class.
        /// </summary>
        public CertificateResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateResponse class.
        /// </summary>
        public CertificateResponse(System.Guid? certificateId = default(System.Guid?), string name = default(string), System.Guid? subscriptionId = default(System.Guid?), System.DateTime? createdDate = default(System.DateTime?))
        {
            CertificateId = certificateId;
            Name = name;
            SubscriptionId = subscriptionId;
            CreatedDate = createdDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificateId")]
        public System.Guid? CertificateId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public System.Guid? SubscriptionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public System.DateTime? CreatedDate { get; set; }

    }
}