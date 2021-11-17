using JetBrains.Annotations;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// FolderMetadata Model
    /// </summary>
    public class FolderMetadata
    {
        [PublicAPI]
        [JsonProperty("connections")]
        public Connections Connections { get; set; }

        [PublicAPI]
        [JsonProperty("interactions")]
        public Interactions Interactions { get; set; }
    }


    /// <summary>
    /// Items Model
    /// </summary>
    public class Items
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }

        [PublicAPI]
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    /// <summary>
    /// Videos Model
    /// </summary>
    public class Videos
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }

        [PublicAPI]
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    /// <summary>
    /// Folders Model
    /// </summary>
    public class Folders
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }

        [PublicAPI]
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    /// <summary>
    /// AncestorPath Model
    /// </summary>
    public class AncestorPath
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    /// <summary>
    /// ParentFolder Model
    /// </summary>
    public class ParentFolder
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }
    }

    /// <summary>
    /// Connections Model
    /// </summary>
    public class Connections
    {
        [PublicAPI]
        [JsonProperty("items")]
        public Items Items { get; set; }

        [PublicAPI]
        [JsonProperty("videos")]
        public Videos Videos { get; set; }

        [PublicAPI]
        [JsonProperty("folders")]
        public Folders Folders { get; set; }

        [PublicAPI]
        [JsonProperty("ancestor_path")]
        public List<AncestorPath> AncestorPath { get; set; }

        [PublicAPI]
        [JsonProperty("parent_folder")]
        public ParentFolder ParentFolder { get; set; }
    }

    /// <summary>
    /// Edit Model
    /// </summary>
    public class Edit
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }
    }

    /// <summary>
    /// View Model
    /// </summary>
    public class View
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }
    }

    /// <summary>
    /// Invite Model
    /// </summary>
    public class Invite
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }
    }

    /// <summary>
    /// DeleteVideo Model
    /// </summary>
    public class DeleteVideo
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }
    }

    /// <summary>
    /// Property Model
    /// </summary>
    public class Property
    {
        [PublicAPI]
        [JsonProperty("name")]
        public string Name { get; set; }

        [PublicAPI]
        [JsonProperty("required")]
        public bool Required { get; set; }

        [PublicAPI]
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    /// <summary>
    /// AddSubfolder Model
    /// </summary>
    public class AddSubfolder
    {
        [PublicAPI]
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonProperty("options")]
        public List<string> Options { get; set; }

        [PublicAPI]
        [JsonProperty("can_add_subfolders")]
        public bool CanAddSubfolders { get; set; }

        [PublicAPI]
        [JsonProperty("subfolder_depth_limit_reached")]
        public bool SubfolderDepthLimitReached { get; set; }

        [PublicAPI]
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [PublicAPI]
        [JsonProperty("properties")]
        public List<Property> Properties { get; set; }
    }

    /// <summary>
    /// Interactions Model
    /// </summary>
    public class Interactions
    {
        [PublicAPI]
        [JsonProperty("edit")]
        public Edit Edit { get; set; }

        [PublicAPI]
        [JsonProperty("view")]
        public View View { get; set; }

        [PublicAPI]
        [JsonProperty("invite")]
        public Invite Invite { get; set; }

        [PublicAPI]
        [JsonProperty("delete_video")]
        public DeleteVideo DeleteVideo { get; set; }

        [PublicAPI]
        [JsonProperty("add_subfolder")]
        public AddSubfolder AddSubfolder { get; set; }
    }
}