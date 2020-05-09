namespace ytdl
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.versionchecker = new System.Windows.Forms.Label();
            this.linkbox = new System.Windows.Forms.TextBox();
            this.addurlb = new System.Windows.Forms.Button();
            this.queuebox = new System.Windows.Forms.TextBox();
            this.queue = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.options = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.runbutton = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.directory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "youtube-dl";
            // 
            // versionchecker
            // 
            this.versionchecker.AutoSize = true;
            this.versionchecker.BackColor = System.Drawing.Color.Transparent;
            this.versionchecker.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionchecker.Location = new System.Drawing.Point(40, 76);
            this.versionchecker.Name = "versionchecker";
            this.versionchecker.Size = new System.Drawing.Size(119, 23);
            this.versionchecker.TabIndex = 1;
            this.versionchecker.Text = "versionchecker";
            // 
            // linkbox
            // 
            this.linkbox.Location = new System.Drawing.Point(41, 111);
            this.linkbox.Name = "linkbox";
            this.linkbox.ReadOnly = true;
            this.linkbox.Size = new System.Drawing.Size(484, 21);
            this.linkbox.TabIndex = 2;
            this.linkbox.Text = "Enter Video Link";
            this.linkbox.Click += new System.EventHandler(this.linkbox_Click);
            // 
            // addurlb
            // 
            this.addurlb.Location = new System.Drawing.Point(541, 111);
            this.addurlb.Name = "addurlb";
            this.addurlb.Size = new System.Drawing.Size(90, 23);
            this.addurlb.TabIndex = 3;
            this.addurlb.Text = "Add";
            this.addurlb.UseVisualStyleBackColor = true;
            this.addurlb.Click += new System.EventHandler(this.addurlb_Click);
            // 
            // queuebox
            // 
            this.queuebox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.queuebox.Location = new System.Drawing.Point(41, 165);
            this.queuebox.Multiline = true;
            this.queuebox.Name = "queuebox";
            this.queuebox.ReadOnly = true;
            this.queuebox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.queuebox.Size = new System.Drawing.Size(233, 227);
            this.queuebox.TabIndex = 4;
            // 
            // queue
            // 
            this.queue.AutoSize = true;
            this.queue.BackColor = System.Drawing.Color.Transparent;
            this.queue.Cursor = System.Windows.Forms.Cursors.Default;
            this.queue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queue.Location = new System.Drawing.Point(42, 137);
            this.queue.Name = "queue";
            this.queue.Size = new System.Drawing.Size(56, 23);
            this.queue.TabIndex = 5;
            this.queue.Text = "Queue";
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.BackColor = System.Drawing.Color.Transparent;
            this.option1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.option1.Checked = true;
            this.option1.Location = new System.Drawing.Point(294, 173);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(47, 16);
            this.option1.TabIndex = 6;
            this.option1.TabStop = true;
            this.option1.Text = "mp4";
            this.option1.UseVisualStyleBackColor = false;
            // 
            // options
            // 
            this.options.AutoSize = true;
            this.options.BackColor = System.Drawing.Color.Transparent;
            this.options.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.Location = new System.Drawing.Point(279, 138);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(134, 23);
            this.options.TabIndex = 7;
            this.options.Text = "Download Option";
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.BackColor = System.Drawing.Color.Transparent;
            this.option2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.option2.Location = new System.Drawing.Point(363, 173);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(58, 16);
            this.option2.TabIndex = 9;
            this.option2.Text = "webm";
            this.option2.UseVisualStyleBackColor = false;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.BackColor = System.Drawing.Color.Transparent;
            this.option3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.option3.Location = new System.Drawing.Point(437, 173);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(88, 16);
            this.option3.TabIndex = 10;
            this.option3.Text = "User Select";
            this.option3.UseVisualStyleBackColor = false;
            // 
            // runbutton
            // 
            this.runbutton.Location = new System.Drawing.Point(541, 170);
            this.runbutton.Name = "runbutton";
            this.runbutton.Size = new System.Drawing.Size(91, 23);
            this.runbutton.TabIndex = 11;
            this.runbutton.Text = "Start";
            this.runbutton.UseVisualStyleBackColor = true;
            this.runbutton.Click += new System.EventHandler(this.runbutton_Click);
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.BackColor = System.Drawing.Color.Transparent;
            this.progress.Cursor = System.Windows.Forms.Cursors.Default;
            this.progress.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.Location = new System.Drawing.Point(282, 200);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(58, 23);
            this.progress.TabIndex = 12;
            this.progress.Text = "Status";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.status.Location = new System.Drawing.Point(280, 226);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.status.Size = new System.Drawing.Size(351, 166);
            this.status.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Load txt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Open Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(177, 398);
            this.directory.Name = "directory";
            this.directory.ReadOnly = true;
            this.directory.Size = new System.Drawing.Size(358, 21);
            this.directory.TabIndex = 16;
            this.directory.Click += new System.EventHandler(this.directory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ytdl.Properties.Resources.color6;
            this.ClientSize = new System.Drawing.Size(665, 427);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.runbutton);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.options);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.queue);
            this.Controls.Add(this.queuebox);
            this.Controls.Add(this.addurlb);
            this.Controls.Add(this.linkbox);
            this.Controls.Add(this.versionchecker);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "youtube-dl Wrapper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionchecker;
        private System.Windows.Forms.TextBox linkbox;
        private System.Windows.Forms.Button addurlb;
        private System.Windows.Forms.TextBox queuebox;
        private System.Windows.Forms.Label queue;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.Label options;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.Button runbutton;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox directory;
    }
}

