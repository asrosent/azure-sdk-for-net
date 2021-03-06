// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The object containing the job profile information.
    /// </summary>
    public partial class Profile
    {
        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        public Profile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Profile class.
        /// </summary>
        /// <param name="jobFile">The job configuration file.</param>
        /// <param name="jobId">The full ID of the job.</param>
        /// <param name="jobID">The ID of the job.</param>
        /// <param name="jobName">The user-specified job name.</param>
        /// <param name="queueName">The name of the queue to which the job is
        /// submitted.</param>
        /// <param name="url">The link to the web-ui for details of the
        /// job.</param>
        /// <param name="user">The userid of the person who submitted the
        /// job.</param>
        public Profile(string jobFile = default(string), string jobId = default(string), JobID jobID = default(JobID), string jobName = default(string), string queueName = default(string), string url = default(string), string user = default(string))
        {
            JobFile = jobFile;
            JobId = jobId;
            JobID = jobID;
            JobName = jobName;
            QueueName = queueName;
            Url = url;
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the job configuration file.
        /// </summary>
        [JsonProperty(PropertyName = "jobFile")]
        public string JobFile { get; set; }

        /// <summary>
        /// Gets or sets the full ID of the job.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the job.
        /// </summary>
        [JsonProperty(PropertyName = "jobID")]
        public JobID JobID { get; set; }

        /// <summary>
        /// Gets or sets the user-specified job name.
        /// </summary>
        [JsonProperty(PropertyName = "jobName")]
        public string JobName { get; set; }

        /// <summary>
        /// Gets or sets the name of the queue to which the job is submitted.
        /// </summary>
        [JsonProperty(PropertyName = "queueName")]
        public string QueueName { get; set; }

        /// <summary>
        /// Gets or sets the link to the web-ui for details of the job.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the userid of the person who submitted the job.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

    }
}
