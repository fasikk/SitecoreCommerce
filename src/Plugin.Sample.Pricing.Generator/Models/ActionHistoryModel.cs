﻿
namespace Plugin.Sample.Pricing.Generator.Models
{
    using System;

    using Sitecore.Commerce.Core;

    public class ActionHistoryModel : Model
    {
        public ActionHistoryModel()
        {
            this.Id = string.Empty;
            this.StartTime = DateTime.UtcNow;
            this.Completed = DateTime.UtcNow;
            this.Response = string.Empty;
            this.JSON = string.Empty;
        }
        
        public string Id { get; private set; }
        
        public string Response { get; set; }
        
        public DateTime Completed { get; set; }
        
        public string JSON { get; set; }
        
        public string EntityId { get; set; }
        
        public string ItemId { get; set; }
        
        public DateTime StartTime { get; set; }
    }
}
