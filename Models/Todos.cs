﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace efc3.Models
{
    public partial class Todos
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public bool IsDeleted { get; set; }
        public string TestColumn { get; set; }

        public DateTime Today { get; set; }
        public DateTime UpdateDay { get; set; }
    }
}