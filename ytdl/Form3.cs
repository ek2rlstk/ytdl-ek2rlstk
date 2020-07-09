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
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            wc.DownloadProgressChanged += DownloadChanged;
            try
            {
                wc.DownloadFileTaskAsync("https://youtube-dl.org/downloads/latest/youtube-dl.exe", Application.StartupPath + @"\youtube-dl.exe");
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
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }
    }
}
