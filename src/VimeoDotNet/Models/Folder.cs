using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models
{
    public class Folder
    {
        /// <summary>
        /// User
        /// </summary>
        [PublicAPI]
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }

        /// <summary>
        /// Created time
        /// </summary>
        [PublicAPI]
        [JsonProperty(PropertyName = "created_time")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Modified time
        /// </summary>
        [PublicAPI]
        [JsonProperty(PropertyName = "modified_time")]
        public DateTime ModifiedTime { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [PublicAPI]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Privacy
        /// </summary>
        [PublicAPI]
        [JsonProperty(PropertyName = "privacy")]
        public Privacy Privacy { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [PublicAPI]
        [JsonProperty(PropertyName = "resource_key")]
        public string ResourceKey { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }


        [PublicAPI]
        [JsonProperty(PropertyName = "metadata")]
        public FolderMetadata Metadata { get; set; }


        /// <summary>
        /// Return the parent project id if exists
        /// </summary>
        /// <returns>ProjectId or null</returns>
        [PublicAPI]
        public long? GetParentProjectId()
        {
            return InnerGetProjectId(Metadata?.Connections?.ParentFolder?.Uri);
        }

        /// <summary>
        /// Return the project id if exists
        /// </summary>
        /// <returns>ProjectId or null</returns>
        [PublicAPI]
        public long? GetProjectId()
        {
            return InnerGetProjectId(Uri);
        }

        private long? InnerGetProjectId(string uri)
        {
            if (string.IsNullOrEmpty(Uri))
            {
                return null;
            }

            Match match = RegexFoldersUri.Match(uri);
            if (match.Success)
            {
                long id = long.Parse(match.Groups["projectId"].Value);
                return id;
            }

            return null;
        }

        private static readonly Regex RegexFoldersUri = new Regex(@"/projects/(?<projectId>\d+)/?$");


    }
}
