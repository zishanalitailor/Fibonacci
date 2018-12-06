using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Web.Models
{
    public class FibonacciViewModel
    {
        public IEnumerable<int> Results { get; set; }

        public int NumberRequested { get; set; }

        public bool HasResults
        {
            get { return Results != null && Results.Any(); }
        }
    }
}