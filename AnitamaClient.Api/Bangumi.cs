﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnitamaClient.Api
{
    [System.Diagnostics.DebuggerDisplay(@"Bangumi\{ Id={Id} Title={Title} \}")]
    public class Bangumi : IPrimeryKey<int>
    {
        [JsonConstructor]
        internal Bangumi([JsonProperty("bid")]int id)
        {
            this.Id = id;
        }

        public int Id { get; }

        [JsonProperty("title")]
        public string Title { get; internal set; }

        [JsonProperty("cover")]
        public Image Cover { get; internal set; }

        [JsonProperty("verticalCover")]
        public Image VerticalCover { get; internal set; }

        [JsonProperty("episode")]
        public string LatestEpisodeName { get; internal set; }

        [JsonProperty("playDate")]
        public DateTimeOffset? LatestEpisodePlayDate { get; internal set; }

        [JsonProperty("playSite")]
        public string PlaySiteName { get; internal set; }

        [JsonProperty("playUrl")]
        public Uri PlayUri { get; internal set; }

        [JsonProperty("playWeekday")]
        public string PlayWeekday { get; internal set; }

        [JsonProperty("playTime")]
        public TimeSpan? PlayTime { get; internal set; }

        [JsonProperty("originStation")]
        public string OriginStationName { get; internal set; }

        [JsonProperty("originWeekday")]
        public string OriginWeekday { get; internal set; }

        [JsonProperty("originTime")]
        public TimeSpan? OriginPlayTime { get; internal set; }

        int IPrimeryKey<int>.GetPrimeryKey() => this.Id;
    }
}