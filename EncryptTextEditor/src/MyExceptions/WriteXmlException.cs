using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptTextEditor.MyExceptions
{
    class WriteXmlException : ApplicationException
    {
        private string error;
        private Exception innerException;

        public WriteXmlException()
        {

        }

        public WriteXmlException(string msg)
            : base(msg)
        {
            this.error = msg;
        }

        public WriteXmlException(string msg, Exception innerException)
            : base(msg)
        {
            this.innerException = innerException;
            this.error = msg;
        }

        public string getError()
        {
            return error;
        }

    }
}
