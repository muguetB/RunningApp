﻿using System;
using Newtonsoft.Json;

namespace Fitbit.Models
{
    public class CaloriesOutStats
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}