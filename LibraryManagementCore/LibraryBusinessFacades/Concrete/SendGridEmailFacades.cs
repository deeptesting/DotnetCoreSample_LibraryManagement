using LibraryBusinessFacades.Absolute;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBusinessFacades.Concrete
{
    public class SendGridEmailFacades : IEmailFacades
    {
        public void SendEmail(string To, string From, string htmlContent, string subject)
        {
            throw new NotImplementedException();
        }
    }
}
