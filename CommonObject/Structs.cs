using System;

namespace CommonObject
{
    public struct Contact
    {
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;
        public SubInformation.MailAddress Email;
    }
}

namespace CommonObject.SubInformation
{
    public struct MailAddress
    {
        public string Identifier;
        public string Domain;

        public override string ToString()
        {
            return $"{Identifier}@{Domain}";
        }
        public Contact Owner;
    }
}
