using System;
namespace SalesUploader.Models;

public class SalesLead
{
    public int Id { get; set; }
    public DateTime QuoteSentDate { get; set; }
    public string SalesPerson { get; set; } = string.Empty;
    public string ProjectName { get; set; } = string.Empty;
    public string ProjectCode { get; set; } = string.Empty;
    public string Customer { get; set; } = string.Empty;
    public string CustomerCity { get; set; } = string.Empty;
    public string CustomerState { get; set; } = string.Empty;
    public string MarketingCategory { get; set; } = string.Empty;
    public int NumberOfQuotes { get; set; }
    public decimal TotalNet { get; set; }
}
