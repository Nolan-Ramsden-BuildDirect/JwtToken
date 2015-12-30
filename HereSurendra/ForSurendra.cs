using System;
using BuildDirect.Services.WebAPI.Common.Helpers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Claims;

namespace HereSurendra
{
    public partial class ForSurendra : Form
    {
        public ForSurendra()
        {
            InitializeComponent();
            env_drop.SelectedIndex = 0;
            service_drop.SelectedIndex = 0;
        }

        private void TokenifyService(object sender, EventArgs e)
        {
            try
            {
                String configTransform = GetEnvironmentWebConfig();
                String serviceConfig = GetServiceWebConfig(configTransform);
                String token = GetTokenFromConfig(serviceConfig);
                token_text.Text = token;
                SetEncryptedValue();
            }catch
            {
                jwt_text.Text = "Woooops, something went wrong";
            }
        }

        private string GetEnvironmentWebConfig()
        {
            String envConfig = "Web.config";
            if (env_drop.Text != "None")
                envConfig = "Web." + env_drop.Text + ".config";
            return envConfig;
        }

        private string GetServiceWebConfig(string webConfig)
        {
            const String rootFolder = @"\\v3dewa01\wwwroot\DEV_";
            String buildFolder = LastModifiedFolder(rootFolder + service_drop.Text);
            return Path.Combine(buildFolder, webConfig);
        }

        private string GetTokenFromConfig(string configFile)
        {
            String text = String.Empty;
            using (StreamReader sr = new StreamReader(configFile))
            {
                text = sr.ReadToEnd();
            }
            String cutText = text.Substring(text.IndexOf("key=\"JwtSharedKey\""));
            String tokenWithTrailing = cutText.Substring(cutText.IndexOf("value=\"") + 7);
            String token = tokenWithTrailing.Substring(0, tokenWithTrailing.IndexOf("\""));
            return token;
        }

        private String LastModifiedFolder(String folder)
        {
            DateTime lastHigh = new DateTime(1900, 1, 1);
            string highDir = String.Empty;
            foreach (string subdir in Directory.GetDirectories(folder))
            {
                DirectoryInfo fi1 = new DirectoryInfo(subdir);
                DateTime created = fi1.LastWriteTime;

                if (created > lastHigh)
                {
                    highDir = subdir;
                    lastHigh = created;
                }
            }
            return highDir;
        }

        private void TokenifyKey(object sender, EventArgs e)
        {
            SetEncryptedValue();
        }

        private Claim[] GetClaims()
        {
            var claims = new List<Claim>();
            if (!string.IsNullOrWhiteSpace(ClaimType1.Text))
            {
                claims.Add(new Claim(ClaimType1.Text, ClaimValue1.Text));
            }
            if (!string.IsNullOrWhiteSpace(ClaimType2.Text))
            {
                claims.Add(new Claim(ClaimType2.Text, ClaimValue2.Text));
            }
            if (!string.IsNullOrWhiteSpace(ClaimType3.Text))
            {
                claims.Add(new Claim(ClaimType3.Text, ClaimValue3.Text));
            }
            if (!string.IsNullOrWhiteSpace(role1.Text))
            {
                claims.Add(new Claim(ClaimTypes.Role, role1.Text));
            }
            if (!string.IsNullOrWhiteSpace(role2.Text))
            {
                claims.Add(new Claim(ClaimTypes.Role, role2.Text));
            }
            if (!string.IsNullOrWhiteSpace(role3.Text))
            {
                claims.Add(new Claim(ClaimTypes.Role, role3.Text));
            }
            if (!string.IsNullOrWhiteSpace(role4.Text))
            {
                claims.Add(new Claim(ClaimTypes.Role, role4.Text));
            }
            if (!string.IsNullOrWhiteSpace(role5.Text))
            {
                claims.Add(new Claim(ClaimTypes.Role, role5.Text));
            }
            if (!string.IsNullOrWhiteSpace(role6.Text))
            {
                claims.Add(new Claim(ClaimTypes.Role, role6.Text));
            }
            return claims.ToArray();
        }

        private void SetEncryptedValue()
        {
            var claims = GetClaims();
            var jwtToken = new JwtHelper().CreateSymmetricKeyJwt(
             key: token_text.Text,
             issuer: "builddirect.com",
             audience: "builddirect.com",
             expiry: DateTime.Now.AddYears(5),
             claims: claims.ToArray()
             );
            jwt_text.Text = String.Format("Bearer {0}", jwtToken);
        }

        private void CopyToClipboard(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(jwt_text.Text);
        }
    }
}
