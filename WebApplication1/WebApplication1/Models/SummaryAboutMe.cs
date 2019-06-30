using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekNineteenMVC.Models
{
  public class SummaryAboutMe
  {
    public int Id { get; set; }
    public string Summary { get; set; }
    public IEnumerable<WorkHistory> Histories { get; set; }
  }
}