
namespace Script_Hub_Uploader_Beta
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlebox = new System.Windows.Forms.TextBox();
            this.imageurl = new System.Windows.Forms.TextBox();
            this.scripturl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.printoutput = new System.Windows.Forms.RichTextBox();
            this.ConsoleLog = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.header1 = new System.Windows.Forms.RichTextBox();
            this.header2 = new System.Windows.Forms.RichTextBox();
            this.header3 = new System.Windows.Forms.RichTextBox();
            this.header4 = new System.Windows.Forms.RichTextBox();
            this.main1 = new System.Windows.Forms.RichTextBox();
            this.main2 = new System.Windows.Forms.RichTextBox();
            this.input = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(43, 45);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(378, 20);
            this.titlebox.TabIndex = 0;
            // 
            // imageurl
            // 
            this.imageurl.Location = new System.Drawing.Point(43, 90);
            this.imageurl.Name = "imageurl";
            this.imageurl.Size = new System.Drawing.Size(378, 20);
            this.imageurl.TabIndex = 1;
            // 
            // scripturl
            // 
            this.scripturl.Location = new System.Drawing.Point(43, 131);
            this.scripturl.Name = "scripturl";
            this.scripturl.Size = new System.Drawing.Size(378, 20);
            this.scripturl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title / Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Image Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "URL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add to List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ConsoleLog);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.titlebox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.imageurl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.scripturl);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 584);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script JSON Uploader";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Console Log";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.printoutput);
            this.groupBox3.Location = new System.Drawing.Point(24, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(578, 150);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Script Added";
            // 
            // printoutput
            // 
            this.printoutput.Location = new System.Drawing.Point(15, 19);
            this.printoutput.Name = "printoutput";
            this.printoutput.Size = new System.Drawing.Size(541, 111);
            this.printoutput.TabIndex = 20;
            this.printoutput.Text = "";
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.Location = new System.Drawing.Point(24, 346);
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.ReadOnly = true;
            this.ConsoleLog.Size = new System.Drawing.Size(578, 220);
            this.ConsoleLog.TabIndex = 22;
            this.ConsoleLog.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 57);
            this.button3.TabIndex = 8;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // header1
            // 
            this.header1.Location = new System.Drawing.Point(15, 708);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(47, 36);
            this.header1.TabIndex = 9;
            this.header1.Text = "{ \"description\": \"";
            this.header1.Visible = false;
            // 
            // header2
            // 
            this.header2.Location = new System.Drawing.Point(68, 708);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(47, 36);
            this.header2.TabIndex = 10;
            this.header2.Text = "\", \"ImageLink\": \"";
            this.header2.Visible = false;
            // 
            // header3
            // 
            this.header3.Location = new System.Drawing.Point(121, 708);
            this.header3.Name = "header3";
            this.header3.Size = new System.Drawing.Size(47, 36);
            this.header3.TabIndex = 11;
            this.header3.Text = "\", \"scriptURLRaw\": \"";
            this.header3.Visible = false;
            // 
            // header4
            // 
            this.header4.Location = new System.Drawing.Point(174, 708);
            this.header4.Name = "header4";
            this.header4.Size = new System.Drawing.Size(47, 36);
            this.header4.TabIndex = 12;
            this.header4.Text = "\" }";
            this.header4.Visible = false;
            // 
            // main1
            // 
            this.main1.Location = new System.Drawing.Point(227, 708);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(47, 36);
            this.main1.TabIndex = 13;
            this.main1.Text = "{\n    \"scripts\": [\n\n";
            this.main1.Visible = false;
            // 
            // main2
            // 
            this.main2.Location = new System.Drawing.Point(280, 708);
            this.main2.Name = "main2";
            this.main2.Size = new System.Drawing.Size(47, 36);
            this.main2.TabIndex = 14;
            this.main2.Text = "]\n }";
            this.main2.Visible = false;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(299, 725);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(72, 61);
            this.input.TabIndex = 15;
            this.input.Text = "{\n  \"scripts\": [";
            this.input.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 755);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(77, 42);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "{\n  \"scripts\": [";
            this.richTextBox1.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(95, 755);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(67, 42);
            this.richTextBox2.TabIndex = 17;
            this.richTextBox2.Text = "  ]\n}";
            this.richTextBox2.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(95, 803);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(67, 42);
            this.richTextBox3.TabIndex = 19;
            this.richTextBox3.Text = "$]\n }";
            this.richTextBox3.Visible = false;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(12, 803);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(77, 42);
            this.richTextBox4.TabIndex = 18;
            this.richTextBox4.Text = "{\n    \"scripts\": [";
            this.richTextBox4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 658);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.main2);
            this.Controls.Add(this.main1);
            this.Controls.Add(this.header4);
            this.Controls.Add(this.header3);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pandatechnology.xyz [ Script Hub Uploader ]";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.TextBox imageurl;
        private System.Windows.Forms.TextBox scripturl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox header1;
        private System.Windows.Forms.RichTextBox header2;
        private System.Windows.Forms.RichTextBox header3;
        private System.Windows.Forms.RichTextBox header4;
        private System.Windows.Forms.RichTextBox main1;
        private System.Windows.Forms.RichTextBox main2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox printoutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ConsoleLog;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

