using System;
using System.Collections;

namespace WeekNineteenMVC.Models
{
  public class WorkHistory
  {
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsCurrentEmployeer { get; set; }
    //public IEnumerable<>
  }
}