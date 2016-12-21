using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheCodeFirst.Persistence
{
    public class NoteCacheException : Exception
    {
        public NoteCacheException()
            : base() { }

        public NoteCacheException(string message)
            : base(message) { }

        public NoteCacheException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public NoteCacheException(string message, Exception innerException)
            : base(message, innerException) { }

        public NoteCacheException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }
    }
}
