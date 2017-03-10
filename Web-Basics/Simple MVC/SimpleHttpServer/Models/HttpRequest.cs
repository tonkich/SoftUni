using SimpleHttpServer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHttpServer.Models
{
    public class HttpRequest
    {
        public RequestMethod Method { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }

        public Header Header { get; set; }
        public HttpSession Session { get; set; }


        public HttpRequest()
        {
            this.Header = new Header(HeaderType.HttpRequest);

        }

        public override string ToString()
        {
            return string.Format("{0} {1} HTTP/1.0\r\n{2}{3}",
                this.Method,
                this.Url,
                this.Header,
                this.Content);
        }
    }
}
