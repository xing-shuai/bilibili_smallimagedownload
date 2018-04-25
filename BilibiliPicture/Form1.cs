using MyClassLibrary.JSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilibiliPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string bilibili = "https://www.bilibili.com/index/index-icon.json";
        string file_path = String.Empty;

        private void bro_button_Click(object sender, EventArgs e)
        {
            if (open_folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                file_path = open_folderBrowserDialog.SelectedPath;
                start_button.Enabled = true;
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (file_path == "")
                {
                    file_path = Application.CommonAppDataPath;
                }
                string json_result = String.Empty;
                WebRequest request = WebRequest.Create(bilibili);
                WebResponse response = request.GetResponse();
                Stream htmlStream = response.GetResponseStream();
                StreamReader weatherStreamReader = new StreamReader(htmlStream, Encoding.UTF8);
                json_result = weatherStreamReader.ReadToEnd();
                JsonData data = JsonMapper.ToObject(json_result)["fix"];

                WebClient webClient = new WebClient();
                string file_name = String.Empty;
                string file_url = String.Empty;
                foreach (JsonData single in data)
                {
                    file_url = "http:" + single["icon"].ToString();
                    file_name = file_path + "\\" + single["title"] + ".gif";
                    if (File.Exists(file_name))
                        continue;
                    webClient.DownloadFile(file_url, file_name);
                    textBox1.AppendText("\n已下载:" + single["title"] + ".gif");
                    currentdownloadcount_label.Text = (Convert.ToInt32(currentdownloadcount_label.Text)+1).ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }


    }
}
