namespace lab_18
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listViewProcesses = new ListView();
            contextMenuStrip = new ContextMenuStrip(components);
            ToolStripMenuItemInfo = new ToolStripMenuItem();
            ToolStripMenuItemKill = new ToolStripMenuItem();
            buttonRefresh = new Button();
            buttonExport = new Button();
            listBoxDetails = new ListBox();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // listViewProcesses
            // 
            listViewProcesses.Location = new Point(12, 43);
            listViewProcesses.Name = "listViewProcesses";
            listViewProcesses.Size = new Size(332, 395);
            listViewProcesses.TabIndex = 0;
            listViewProcesses.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemInfo, ToolStripMenuItemKill });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(139, 48);
            // 
            // ToolStripMenuItemInfo
            // 
            ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            ToolStripMenuItemInfo.Size = new Size(138, 22);
            ToolStripMenuItemInfo.Text = "Інформація";
            ToolStripMenuItemInfo.Click += ToolStripMenuItemInfo_Click;
            // 
            // ToolStripMenuItemKill
            // 
            ToolStripMenuItemKill.Name = "ToolStripMenuItemKill";
            ToolStripMenuItemKill.Size = new Size(138, 22);
            ToolStripMenuItemKill.Text = "Зупинити";
            ToolStripMenuItemKill.Click += ToolStripMenuItemKill_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(378, 122);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(185, 67);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Оновити список процесів";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += button1_Click;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(378, 252);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(185, 67);
            buttonExport.TabIndex = 3;
            buttonExport.Text = "Експортувати список";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += button2_Click;
            // 
            // listBoxDetails
            // 
            listBoxDetails.FormattingEnabled = true;
            listBoxDetails.ItemHeight = 15;
            listBoxDetails.Location = new Point(594, 12);
            listBoxDetails.Name = "listBoxDetails";
            listBoxDetails.Size = new Size(194, 424);
            listBoxDetails.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxDetails);
            Controls.Add(buttonExport);
            Controls.Add(buttonRefresh);
            Controls.Add(listViewProcesses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewProcesses;
        private ContextMenuStrip contextMenuStrip;
        private Button buttonRefresh;
        private Button buttonExport;
        private ListBox listBoxDetails;
        private ToolStripMenuItem ToolStripMenuItemInfo;
        private ToolStripMenuItem ToolStripMenuItemKill;
    }
}
