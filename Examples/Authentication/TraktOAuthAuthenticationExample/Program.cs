﻿namespace TraktOAuthAuthenticationExample
{
    using System;
    using System.Threading.Tasks;
    using TraktApiSharp;
    using TraktApiSharp.Authentication;
    using TraktApiSharp.Exceptions;

    class Program
    {
        private const string CLIENT_ID = "ENTER_CLIENT_ID_HERE";
        private const string CLIENT_SECRET = "ENTER_CLIENT_SECRET_HERE";

        private static TraktClient _client = null;

        static void Main(string[] args)
        {
            try
            {
                SetupClient();
                TryToOAuthAuthenticate().Wait();

                TraktAuthorization authorization = _client.Authorization;

                if (authorization == null || !authorization.IsValid)
                    throw new InvalidOperationException("Trakt Client not authenticated for requests, that require OAuth");

                Console.Write("\nDo you want to refresh the current authorization? [y/n]: ");
                string yesNo = Console.ReadLine();

                if (yesNo.Equals("y"))
                    TryToRefreshAuthorization().Wait();

                Console.Write("\nDo you want to revoke your authorization? [y/n]: ");
                yesNo = Console.ReadLine();

                if (yesNo.Equals("y"))
                    TryToRevokeAuthorization().Wait();

                Console.ReadLine();
            }
            catch (TraktException ex)
            {
                Console.WriteLine("-------------- Trakt Exception --------------");
                Console.WriteLine($"Exception message: {ex.Message}");
                Console.WriteLine($"Status code: {ex.StatusCode}");
                Console.WriteLine($"Request URL: {ex.RequestUrl}");
                Console.WriteLine($"Request message: {ex.RequestBody}");
                Console.WriteLine($"Request response: {ex.Response}");
                Console.WriteLine($"Server Reason Phrase: {ex.ServerReasonPhrase}");
                Console.WriteLine("---------------------------------------------");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("-------------- Exception --------------");
                Console.WriteLine($"Exception message: {ex.Message}");
                Console.WriteLine("---------------------------------------");

                Console.ReadLine();
            }
        }

        static void SetupClient()
        {
            if (_client == null)
            {
                _client = new TraktClient(CLIENT_ID, CLIENT_SECRET);

                if (!_client.IsValidForAuthenticationProcess)
                    throw new InvalidOperationException("Trakt Client not valid for authentication");
            }
        }

        static async Task TryToOAuthAuthenticate()
        {
            string authorizationUrl = _client.OAuth.CreateAuthorizationUrl();

            if (!string.IsNullOrEmpty(authorizationUrl))
            {
                Console.WriteLine("You have to authenticate this application.");
                Console.WriteLine("Please visit the following webpage:");
                Console.WriteLine($"{authorizationUrl}\n");
                Console.Write("Enter the PIN code from Trakt.tv: ");

                string code = Console.ReadLine();

                if (!string.IsNullOrEmpty(code))
                {
                    TraktAuthorization authorization = await _client.OAuth.GetAuthorizationAsync(code);

                    if (authorization != null && authorization.IsValid)
                    {
                        Console.WriteLine("-------------- Authentication successful --------------");
                        WriteAuthorizationInformation(authorization);
                        Console.WriteLine("-------------------------------------------------------");
                    }
                }
            }
        }

        static async Task TryToRefreshAuthorization()
        {
            TraktAuthorization newAuthorization = await _client.OAuth.RefreshAuthorizationAsync();

            if (newAuthorization != null && newAuthorization.IsValid)
            {
                Console.WriteLine("-------------- Authorization refreshed successfully --------------");
                WriteAuthorizationInformation(newAuthorization);
                Console.WriteLine("-------------------------------------------------------");
            }
        }

        static async Task TryToRevokeAuthorization()
        {
            await _client.OAuth.RevokeAuthorizationAsync();
            // If no exception was thrown, revoking was successfull
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Authorization revoked successfully");
            Console.WriteLine("-----------------------------------");
        }

        static void WriteAuthorizationInformation(TraktAuthorization authorization)
        {
            Console.WriteLine($"Created (UTC): {authorization.Created}");
            Console.WriteLine($"Access Scope: {authorization.AccessScope.DisplayName}");
            Console.WriteLine($"Refresh Possible: {authorization.IsRefreshPossible}");
            Console.WriteLine($"Valid: {authorization.IsValid}");
            Console.WriteLine($"Token Type: {authorization.TokenType.DisplayName}");
            Console.WriteLine($"Access Token: {authorization.AccessToken}");
            Console.WriteLine($"Refresh Token: {authorization.RefreshToken}");
            Console.WriteLine($"Token Expired: {authorization.IsExpired}");
            Console.WriteLine($"Expires in {authorization.ExpiresIn / 3600 / 24} days");
        }
    }
}
