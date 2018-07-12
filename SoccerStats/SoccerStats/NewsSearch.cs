using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SoccerStats
{
    public class NewsSearch
    {
        [JsonProperty(PropertyName = "value")]
        public List<NewsResult> NewsResult { get; set; }
    }

    public class NewsResult
    {
        [JsonProperty(PropertyName = "name")]
        public string Headline { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Summary { get; set; }

        [JsonProperty(PropertyName = "datePublished")]
        public DateTime DatePublished { get; set; }

        public double SentimentScore { get; set; }
    }
}
