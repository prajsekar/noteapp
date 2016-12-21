using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheCodeFirst.Persistence
{
    public class NoteCacheException : Exception
    {
        public String Error { get; set; }
        public NoteCacheException()
            : base() { }

        public NoteCacheException(string message, String error)
            : base(message) 
        {
            this.Error = error;
        }

        public NoteCacheException(string message)
            : base(message) { }

        public NoteCacheException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public NoteCacheException(string message, Exception innerException, string error)
            : base(message, innerException)
        {
            this.Error = error;
        }

        public NoteCacheException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }
    }
}
