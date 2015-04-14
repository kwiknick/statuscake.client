﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCake.Client.Models
{
    /// <summary>
    /// StatusCake auth details
    /// </summary>
    public class Auth
    {
        /// <summary>
        /// True if the authentication was successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The details of the currently authenticated account
        /// </summary>
        public AuthDetails Details { get; set; }
    }
}
