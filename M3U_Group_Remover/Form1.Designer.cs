
namespace M3U_Group_Remover
{
    partial class M3UGroupRemover
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
            this.ListView_Groups = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_OpenFile = new System.Windows.Forms.Button();
            this.Label_SelectedFile = new System.Windows.Forms.Label();
            this.Label_SelectedFileActual = new System.Windows.Forms.Label();
            this.Label_ListDescription = new System.Windows.Forms.Label();
            this.Button_SaveExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView_Groups
            // 
            this.ListView_Groups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListView_Groups.GridLines = true;
            this.ListView_Groups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView_Groups.HideSelection = false;
            this.ListView_Groups.Location = new System.Drawing.Point(13, 37);
            this.ListView_Groups.Name = "ListView_Groups";
            this.ListView_Groups.Size = new System.Drawing.Size(400, 350);
            this.ListView_Groups.TabIndex = 0;
            this.ListView_Groups.UseCompatibleStateImageBehavior = false;
            this.ListView_Groups.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 396;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(207, 408);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(100, 30);
            this.Btn_Delete.TabIndex = 1;
            this.Btn_Delete.Text = "Delete group";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_OpenFile
            // 
            this.Btn_OpenFile.Location = new System.Drawing.Point(13, 408);
            this.Btn_OpenFile.Name = "Btn_OpenFile";
            this.Btn_OpenFile.Size = new System.Drawing.Size(100, 30);
            this.Btn_OpenFile.TabIndex = 2;
            this.Btn_OpenFile.Text = "Open M3U file";
            this.Btn_OpenFile.UseVisualStyleBackColor = true;
            this.Btn_OpenFile.Click += new System.EventHandler(this.Btn_OpenFile_Click);
            // 
            // Label_SelectedFile
            // 
            this.Label_SelectedFile.AutoSize = true;
            this.Label_SelectedFile.Location = new System.Drawing.Point(13, 390);
            this.Label_SelectedFile.Name = "Label_SelectedFile";
            this.Label_SelectedFile.Size = new System.Drawing.Size(54, 15);
            this.Label_SelectedFile.TabIndex = 3;
            this.Label_SelectedFile.Text = "Selected:";
            // 
            // Label_SelectedFileActual
            // 
            this.Label_SelectedFileActual.AutoSize = true;
            this.Label_SelectedFileActual.Location = new System.Drawing.Point(73, 390);
            this.Label_SelectedFileActual.Name = "Label_SelectedFileActual";
            this.Label_SelectedFileActual.Size = new System.Drawing.Size(16, 15);
            this.Label_SelectedFileActual.TabIndex = 4;
            this.Label_SelectedFileActual.Text = "...";
            // 
            // Label_ListDescription
            // 
            this.Label_ListDescription.AutoSize = true;
            this.Label_ListDescription.Location = new System.Drawing.Point(13, 16);
            this.Label_ListDescription.Name = "Label_ListDescription";
            this.Label_ListDescription.Size = new System.Drawing.Size(48, 15);
            this.Label_ListDescription.TabIndex = 5;
            this.Label_ListDescription.Text = "Groups:";
            // 
            // Button_SaveExit
            // 
            this.Button_SaveExit.Location = new System.Drawing.Point(313, 408);
            this.Button_SaveExit.Name = "Button_SaveExit";
            this.Button_SaveExit.Size = new System.Drawing.Size(100, 30);
            this.Button_SaveExit.TabIndex = 6;
            this.Button_SaveExit.Text = "Save";
            this.Button_SaveExit.UseVisualStyleBackColor = true;
            this.Button_SaveExit.Click += new System.EventHandler(this.Button_SaveExit_Click);
            // 
            // M3UGroupRemover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.Button_SaveExit);
            this.Controls.Add(this.Label_ListDescription);
            this.Controls.Add(this.Label_SelectedFileActual);
            this.Controls.Add(this.Label_SelectedFile);
            this.Controls.Add(this.Btn_OpenFile);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.ListView_Groups);
            this.Name = "M3UGroupRemover";
            this.Text = "M3U Group Remover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Groups;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_OpenFile;
        private System.Windows.Forms.Label Label_SelectedFile;
        private System.Windows.Forms.Label Label_SelectedFileActual;
        private System.Windows.Forms.Label Label_ListDescription;
        private System.Windows.Forms.Button Button_SaveExit;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

