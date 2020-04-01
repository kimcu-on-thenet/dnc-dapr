﻿using System;

namespace Example.Dapr.FirstSubscriber.Models
{
    public class ProductCreated
    {
        public int ProductId { get; set; }
        public string Code { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
