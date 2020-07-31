// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using IdentityServer4;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
                var address = new
                {
                    street_address = "One Hacker Way",
                    locality = "Heidelberg",
                    postal_code = 69118,
                    country = "Germany"
                };
                
                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "9ca1976d-8725-464f-85d4-2c88cc7f2017",
                        Username = "frank",
                        Password = "frank",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.GivenName, "frank"),                           
                            new Claim(JwtClaimTypes.FamilyName, "Underwood"),
                            
                        }
                    },
                    new TestUser
                    {
                        SubjectId = "1059c763-988f-4096-9379-30785e2570b6",
                        Username = "Claire",
                        Password = "Claire",
                        Claims =
                        {
                             new Claim(JwtClaimTypes.GivenName, "Claire"),
                            new Claim(JwtClaimTypes.FamilyName, "Underwood"),
                        }
                    }
                };
            }
        }
    }
}