using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace ConsoleAppEnum
{



    public class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            const string accountSid = "ACd255a1256cc352f681c4b6e15f1d0c01";
            const string authToken = "aaa00cb12aba6107ac05a717a9f91445";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Thank you....arif",
                from: new Twilio.Types.PhoneNumber("+13347817048"),
                to: new Twilio.Types.PhoneNumber("+8801743692955")
                to:new Twilio.Types.PhoneNumber("")

            );

            Console.WriteLine(message.Sid);
        }
    }

}

   