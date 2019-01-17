using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDN
{
    public class ApiResponse<TResult> : ApiResponse
    {

        public List<TResult> results { get; set; }
    }

    public class ApiResponse
    {
        public string success { get; set; }

        public string status { get; set; }

        public string message { get; set; }
    }
}
