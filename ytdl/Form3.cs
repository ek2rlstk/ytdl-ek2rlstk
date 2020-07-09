using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ytdl
{
    public partial class Form3 : Form
    {
        WebClient wc = new WebClient();
        string downloadlink;
        string downloadfile;
        int sel;
        public Form3(int mysel)
        {
            InitializeComponent();
            sel = mysel;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (sel == 1)
            {
                downloadlink = "https://youtube-dl.org/downloads/latest/youtube-dl.exe";
                downloadfile = Application.StartupPath + @"\youtube-dl.exe";
            }
            else if (sel == 2)
            {
                downloadlink = "https://ffmpeg.zeranoe.com/builds/win64/static/ffmpeg-latest-win64-static.zip";
                downloadfile = Application.StartupPath + @"\ffmpeg.zip";
            }
            wc.DownloadProgressChanged += DownloadChanged;
            try
            {
                wc.DownloadFileTaskAsync(downloadlink, downloadfile);
            }
            catch (WebException) { DialogResult = DialogResult.No; Dispose(); }
            catch (ArgumentNullException) { DialogResult = DialogResult.No; Dispose(); }
            catch (InvalidOperationException) { DialogResult = DialogResult.No; Dispose(); }
        }

        private void DownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (e.ProgressPercentage >= 100)
            {
                DialogResult = DialogResult.OK;
                Dispose();
            }
        }
    }
}
