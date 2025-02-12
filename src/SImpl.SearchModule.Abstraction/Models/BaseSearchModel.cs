﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace SImpl.SearchModule.Abstraction.Models
{
    public class BaseSearchModel: ISearchModel
    {
        public DateTime? IndexedAt { get; set; }
        public CultureInfo Culture { get; set; }
        public string ContentKey { get; set; }
        public string Content { get; set; }
        public IList<string> Tags { get; set; }
        public string ContentType { get; set; }
        public Type ViewModelType { get; set; }
        public IDictionary<string, List<object>> CustomProperties { get; set; }

        public string Id
        {
            get => ContentKey.ToLowerInvariant();
            set => ContentKey = value;
        }
    }
}