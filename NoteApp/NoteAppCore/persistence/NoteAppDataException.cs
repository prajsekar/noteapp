using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appnote.Core.Persistence
{
    public class NoteAppDataException : Exception
    {
        public String Error { get; set; }
        public NoteAppDataException()
            : base() { }

        public NoteAppDataException(string message, String error)
            : base(message) 
        {
            this.Error = error;
        }

        public NoteAppDataException(string message)
            : base(message) { }

        public NoteAppDataException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public NoteAppDataException(string message, Exception innerException, string error)
            : base(message, innerException)
        {
            this.Error = error;
        }

        public NoteAppDataException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }
    }
}
