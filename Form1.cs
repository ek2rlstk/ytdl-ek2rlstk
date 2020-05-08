﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ytdl
{
    public partial class Form1 : Form
    {
        string isupdate = "";
        public Form1()
        {
            InitializeComponent();
        }

        private Process Youtubedlload(string parameter)
        {
            var process = new ProcessStartInfo(Application.StartupPath + @"\youtube-dl.exe");
            process.Arguments = parameter;
            process.CreateNoWindow = true;
            process.UseShellExecute = false;
            process.RedirectStandardError = true;
            process.RedirectStandardOutput = true;
            return Process.Start(process);
        }

        private void Initytdl(string parameter)
        {
            Process PStart = Youtubedlload(parameter);
            PStart.BeginOutputReadLine();
            PStart.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
            {
                if (e.Data != null)
                    if (e.Data.Trim() != "") isupdate = e.Data;
            };
            PStart.WaitForExit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initytdl("--update");
            versionchecker.Text = isupdate;
        }

        private void linkbox_Click(object sender, EventArgs e)
        {
            if (linkbox.ReadOnly == true)
            {
                linkbox.Text = string.Empty;
                linkbox.ReadOnly = false;
            }
        }

        private void addurlb_Click(object sender, EventArgs e)
        {
            urlparser(linkbox.Text);
        }

        private void urlparser(string link)
        {
            if (link.Contains("youtube.com"))
            {
                string[] res = link.Split(new char[] { '=' });
                queuebox.Text += "[youtube]" + res[1] + Environment.NewLine;
            }
            else if (link.Contains("youtu.be"))
            {
                string[] res = link.Split(new string[] { "youtu.be/" }, System.StringSplitOptions.RemoveEmptyEntries);
                if (link.Contains("//"))
                {
                    queuebox.Text += "[youtube]" + res[1] + Environment.NewLine;
                }
                else
                {
                    queuebox.Text += "[youtube]" + res[0] + Environment.NewLine;
                }
            }
            else if (link.Contains("twitch.tv"))
            {
                string[] res = link.Split(new string[] { "twitch.tv/" }, System.StringSplitOptions.RemoveEmptyEntries);
                queuebox.Text += "[twitch]" + res[1] + Environment.NewLine;
            }
            else
            {
                queuebox.Text += link + Environment.NewLine;
            }
        }

        private void runbutton_Click(object sender, EventArgs e)
        {
            if (queuebox.Text.Trim() != "")
            {
                status.Text = "";
                runbutton.Enabled = false;
                runbutton.Text = "Downloading";
                string[] vqueue = queuebox.Text.Split('\n');
                int i = 0;
                while (vqueue[i] != null && vqueue[i] != "")
                {
                    var lines = (from item in queuebox.Text.Split('\n') select item.Trim());
                    lines = lines.Skip(1);
                    queuebox.Text = string.Join(Environment.NewLine, lines.ToArray());
                    if (vqueue[i].Contains("[youtube]"))
                    {
                        string url = vqueue[i].Split(new string[] { "[youtube]" }, System.StringSplitOptions.RemoveEmptyEntries)[0].TrimEnd('\r', '\n');
                        startdownload("https://www.youtube.com/watch?v=" + url);
                    }
                    else if (vqueue[i].Contains("[twitch]"))
                    {
                        string url = vqueue[i].Split(new string[] { "[twitch]" }, System.StringSplitOptions.RemoveEmptyEntries)[0];
                        startdownload("https://www.twitch.tv/" + url);
                    }
                    else
                    {
                        startdownload(vqueue[i]);
                    }
                    i++;
                }
                DialogResult dr = MessageBox.Show("Download is Completed, Are you Exit?", "Download Complete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    this.Dispose();
                }
                else { }
                runbutton.Text = "Start";
                runbutton.Enabled = true;
            }
        }

        private void startdownload(string url)
        {
            Process ps = null;
            if (option1.Checked)
            {
                ps = Youtubedlload(url+ " -f \"bestvideo[ext = mp4] + bestaudio[ext = m4a] / best[ext = mp4] / best\" -o \"%(title)s.%(ext)s");
                ps.BeginOutputReadLine();
                ps.BeginErrorReadLine();
                ps.OutputDataReceived += (object sender, DataReceivedEventArgs e) => status.Text += e.Data + Environment.NewLine;
                ps.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => status.Text += e.Data + Environment.NewLine;
                ps.WaitForExit();
            }
            else if (option2.Checked)
            {
                ps = Youtubedlload(url + " -f \"bestvideo+bestaudio/best\" -o \"%(title)s.%(ext)s");
                ps.BeginOutputReadLine();
                ps.BeginErrorReadLine();
                ps.OutputDataReceived += (object sender, DataReceivedEventArgs e) => status.Text += e.Data + Environment.NewLine;
                ps.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => status.Text += e.Data + Environment.NewLine;
                ps.WaitForExit();
            }

            if (option3.Checked)
            {
                string fcode = "";
                ps = Youtubedlload("-F " + url);
                ps.OutputDataReceived += (object sender, DataReceivedEventArgs e) => fcode += e.Data + Environment.NewLine;
                ps.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => fcode += e.Data + Environment.NewLine;
                ps.BeginOutputReadLine();
                ps.BeginErrorReadLine();
                ps.WaitForExit();
                Form2 form = new Form2();
                form.textBox2.Text = fcode;
                form.ShowDialog();
                string format = form.text;
                ps = Youtubedlload(url + " -f "+ format + " -o \"%(title)s.%(ext)s");
                ps.BeginOutputReadLine();
                ps.BeginErrorReadLine();
                ps.OutputDataReceived += (object sender, DataReceivedEventArgs e) => status.Text += e.Data + Environment.NewLine;
                ps.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => status.Text += e.Data + Environment.NewLine;
                ps.WaitForExit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.DefaultExt = "txt";
            ofile.Filter = "Text File(*.txt)|*.txt";
            if (ofile.ShowDialog() == DialogResult.OK)
            {
                string fname = ofile.FileName;
                string line;
                StreamReader file = new StreamReader(fname);
                while ((line = file.ReadLine()) != null)
                {
                    urlparser(line);
                }
            }
        }
    }
}
