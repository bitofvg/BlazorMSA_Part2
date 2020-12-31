﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdServer {
  public static class Config {
    public static IEnumerable<IdentityResource> IdentityResources =>
               new IdentityResource[]
               {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResources.Phone(),
               };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
                new ApiScope("scope1"),
                new ApiScope("scope2"),
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {

          // Clent Blazor #1
          new Client
          {
            ClientId = "BlazorCli1",
            AllowedGrantTypes = GrantTypes.Code,
            RequirePkce = true,
            RequireClientSecret = false,
            AllowedCorsOrigins = { "https://localhost:5001" },
            AllowedScopes = { 
              "openid", "profile", 
              "email", "phone" 
            },
            RedirectUris = { "https://localhost:5001/authentication/login-callback" },
            PostLogoutRedirectUris = { "https://localhost:5001/" },
            Enabled = true
          },

        };
  }
}