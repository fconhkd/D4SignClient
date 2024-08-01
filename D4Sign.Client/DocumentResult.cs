using Newtonsoft.Json;
using System;

namespace D4Sign.Client
{
    public class GetDocumentResult
    {
        [JsonProperty(PropertyName = "uuid")]
        public string ReferenceId { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }

    public class DocumentResult
    {
        //[JsonProperty("total_documents", NullValueHandling = NullValueHandling.Ignore)]
        //public long? TotalDocuments { get; set; }

        //[JsonProperty("total_in_this_page", NullValueHandling = NullValueHandling.Ignore)]
        //public long? TotalInThisPage { get; set; }

        //[JsonProperty("current_page", NullValueHandling = NullValueHandling.Ignore)]
        //public long? CurrentPage { get; set; }

        //[JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        //public long? TotalPages { get; set; }

        [JsonProperty("uuidDoc", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UuidDoc { get; set; }

        [JsonProperty("nameDoc", NullValueHandling = NullValueHandling.Ignore)]
        public string NameDoc { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        [JsonProperty("pages", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pages { get; set; }

        [JsonProperty("uuidSafe", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UuidSafe { get; set; }

        [JsonProperty("safeName", NullValueHandling = NullValueHandling.Ignore)]
        public string SafeName { get; set; }

        [JsonProperty("statusId", NullValueHandling = NullValueHandling.Ignore)]
        public long? StatusId { get; set; }

        [JsonProperty("statusName", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusName { get; set; }

        [JsonProperty("statusComment")]
        public string StatusComment { get; set; }

        [JsonProperty("whoCanceled")]
        public string WhoCanceled { get; set; }
    }

}