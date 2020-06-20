using Microsoft.Azure.KeyVault;
using Microsoft.Azure.KeyVault.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;

namespace WebApplication13.Helper
{
    public class KeyVault
    {
        public static string connectionString;
        public static async Task<string> GetConnectionString()
        {
            var CS = new SqlConnectionStringBuilder();
            CS.DataSource = "BI-LAPTOP\\SQLEXPRESS";
            CS.InitialCatalog = "web13.4";
            CS.UserID = "sa";
            var keyVault = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(GetToken));
            var secret = await keyVault.GetSecretAsync("https://truongkv1705.vault.azure.net/secrets/DBPassword");
            CS.Password = secret.Value;
            CS.IntegratedSecurity = false;
            //ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString = CS.ToString();
            connectionString = CS.ToString();
            return CS.ToString() + " providerName='System.Data.SqlClient'";
        }
        public static async Task<string> GetToken(string authority, string resource, string scope)
        {
            var authContext = new AuthenticationContext(authority);
            ClientCredential clientCred = new ClientCredential("7a1a09cf-fbe7-413a-bc9d-473ec584d1ae", "G57O_xzp8PX19_j_7WyEah__V008sv_gz6");
            AuthenticationResult result = await authContext.AcquireTokenAsync(resource, clientCred);

            if (result == null)
                throw new InvalidOperationException("Failed to obtain the token");

            return result.AccessToken;
        }
    }
}