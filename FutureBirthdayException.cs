using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    internal class FutureBirthdayException : Exception
    {
        private string _message;
        private DateTime? _receivedDate;

        public FutureBirthdayException(string message)
        {
            _message = message;
        }

        public FutureBirthdayException(DateTime badDate)
        {
            _receivedDate = badDate;
            _message = $"A date from future was passed: {_receivedDate.ToString()}";
        }

        public FutureBirthdayException(DateTime badDate, string message)
        {
            _receivedDate = badDate;
            _message = message;
        }

        public override string Message
        {
            get => _message;
        }
    }
}
