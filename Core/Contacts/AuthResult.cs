using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contacts
{
    public class AuthResult
    {
        public List<string> Errors { get; set; }
        public bool Saccess { get; set; }
        public string Token { get; set; }
    }
}
