﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace tt0103.Models;

public partial class Category
{
    public long CategoryId { get; set; }

    public string CategoryName { get; set; }

    public virtual ICollection<ChildCategory> ChildCategories { get; set; } = new List<ChildCategory>();
}