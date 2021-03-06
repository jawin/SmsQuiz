﻿using System;
using System.Runtime.Serialization;

namespace BB.SmsQuiz.Api.Controllers.Users
{
    [Serializable, DataContract]
    public class CreateUserItem
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}