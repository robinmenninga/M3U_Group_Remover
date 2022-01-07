using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3U_Group_Remover
{
    public partial class M3UGroupRemover : Form
    {
        public M3UGroupRemover()
        {
            InitializeComponent();
        }

        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Open M3U file",
                DefaultExt = "m3u",
                Filter = "m3u files (*.m3u)|*.m3u",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                M3ULogic.Init(openFileDialog.FileName);
                if (M3ULogic.Groups.Count == 0)
                {
                    MessageBox.Show("No groups found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ListView_Groups.Items.Clear();
                M3ULogic.Groups.ForEach(group => ListView_Groups.Items.Add(group));
                Label_SelectedFileActual.Text = openFileDialog.FileName;
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection removeListView = ListView_Groups.SelectedItems;
            if (removeListView.Count == 0) return;
            List<string> toRemoveGroups = removeListView.Cast<ListViewItem>().Select(x => x.Text).ToList();
            M3ULogic.RemoveGroup(toRemoveGroups);
            
            foreach (ListViewItem listViewItem in removeListView)
            {
                ListView_Groups.Items.Remove(listViewItem);
            }
        }

        private void Button_SaveExit_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Save M3U file",
                FileName = "newlist.m3u",
                DefaultExt = "m3u",
                Filter = "m3u files (*.m3u)|*.m3u",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                M3ULogic.Save(saveFileDialog.FileName);
            }

        }
    }
}
