using System.Collections.Generic;

namespace DataStatsMVC.Models
{
    public class GraphObj
    {
        public List<string> DateRange { get; set; } = new List<string>() { "Jan", "Feb", "Mar", "Apr" };
        public List<double> GraphData { get; set; } = new List<double>();
    }
}
