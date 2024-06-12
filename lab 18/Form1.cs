using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace lab_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listViewProcesses.ContextMenuStrip = contextMenuStrip;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(sfd.FileName))
                    {
                        foreach (ListViewItem item in listViewProcesses.Items)
                        {
                            writer.WriteLine($"{item.SubItems[0].Text}\t{item.SubItems[1].Text}");
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            listViewProcesses.Items.Clear();
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                var item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                listViewProcesses.Items.Add(item);
            }
        }

        private void ToolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            if (listViewProcesses.SelectedItems.Count > 0)
            {
                var selectedItem = listViewProcesses.SelectedItems[0];
                int processId = int.Parse(selectedItem.SubItems[1].Text);
                var process = Process.GetProcessById(processId);
                listBoxDetails.Items.Clear();
                listBoxDetails.Items.Add($"ID: {process.Id}");
                listBoxDetails.Items.Add($"Name: {process.ProcessName}");
                listBoxDetails.Items.Add($"Start Time: {process.StartTime}");
                listBoxDetails.Items.Add($"Total Processor Time: {process.TotalProcessorTime}");
                listBoxDetails.Items.Add($"Threads: {process.Threads.Count}");
                listBoxDetails.Items.Add("Modules:");
                foreach (ProcessModule module in process.Modules)
                {
                    listBoxDetails.Items.Add(module.ModuleName);
                }
            }
        }

        private void ToolStripMenuItemKill_Click(object sender, EventArgs e)
        {
            if (listViewProcesses.SelectedItems.Count > 0)
            {
                var selectedItem = listViewProcesses.SelectedItems[0];
                int processId = int.Parse(selectedItem.SubItems[1].Text);
                var process = Process.GetProcessById(processId);
                try
                {
                    process.Kill();
                    RefreshProcessList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося зупинити процес: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }
    }
}
