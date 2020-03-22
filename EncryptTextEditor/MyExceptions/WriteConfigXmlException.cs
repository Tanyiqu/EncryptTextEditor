using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptTextEditor.MyExceptions
{
    class WriteConfigXmlException : ApplicationException
    {
        private string error;
        private Exception innerException;

        public WriteConfigXmlException()
        {

        }

        public WriteConfigXmlException(string msg)
            : base(msg)
        {
            this.error = msg;
        }

        public WriteConfigXmlException(string msg, Exception innerException)
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
