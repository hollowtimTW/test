﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace test2.Models;

public partial class Record
{
    public long RecordId { get; set; }

    public long CategoryId { get; set; }

    public long ChildCategoryId { get; set; }

    public long PurchaseNo { get; set; }

    public string MaterialNo { get; set; }

    public string Model { get; set; }

    public string DeliveryDate { get; set; }

    public string Quantity { get; set; }

    public string Vendor { get; set; }

    public long Stock { get; set; }

    public long ReceiptNo { get; set; }

    public byte[] Price { get; set; }

    public string Notes { get; set; }
}