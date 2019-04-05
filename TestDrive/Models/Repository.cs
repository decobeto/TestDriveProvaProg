using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDrive.Models
{
    public class Repository
    {
        public static List<TesteDrive> responses = new List<TesteDrive>();

        public static IEnumerable<TesteDrive> Responses
        {
            get
            {
                return responses;
            }
        }

        public static void AddResponse(TesteDrive testeDrive)
        {
            responses.Add(testeDrive);
        }

    }
}
