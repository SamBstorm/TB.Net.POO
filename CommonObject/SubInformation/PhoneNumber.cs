using System;
using System.Collections.Generic;
using System.Text;

namespace CommonObject.SubInformation
{
    public struct PhoneNumber
    {
        public string CountryCode;
        public string Number;

        public Contact Owner;
        public MailAddress Email;
    }
}
