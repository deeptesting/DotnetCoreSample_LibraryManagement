using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBusinessFacades.Absolute
{
    public interface IEmailFacades
    {
        void SendEmail(string To,string From,string htmlContent,string subject);
    }


   
}
