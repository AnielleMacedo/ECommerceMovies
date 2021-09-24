using System;

namespace ECommerceMovies.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string TestError { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
