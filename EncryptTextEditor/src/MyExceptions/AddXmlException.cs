using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptTextEditor.MyExceptions
{
    class AddXmlException : ApplicationException
    {
        private string error;
        private Exception innerException;

        public AddXmlException()
        {

        }

        public AddXmlException(string msg)
            : base(msg)
        {
            this.error = msg;
        }

        public AddXmlException(string msg, Exception innerException)
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
