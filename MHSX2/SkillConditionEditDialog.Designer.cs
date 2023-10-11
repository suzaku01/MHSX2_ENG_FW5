namespace MHSX2
{
    partial class SkillConditionEditDialog
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
            this.button_add = new System.Windows.Forms.Button();
            this.button_dell = new System.Windows.Forms.Button();
            this.listBox_searchskill = new System.Windows.Forms.ListBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.skillBaseTreeView1 = new MHSX2.SkillBaseTreeView();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_add.Location = new System.Drawing.Point(287, 207);
            this.button_add.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(63, 40);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "->";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_dell
            // 
            this.button_dell.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_dell.Location = new System.Drawing.Point(287, 256);
            this.button_dell.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_dell.Name = "button_dell";
            this.button_dell.Size = new System.Drawing.Size(63, 40);
            this.button_dell.TabIndex = 2;
            this.button_dell.Text = "<-";
            this.button_dell.UseVisualStyleBackColor = true;
            this.button_dell.Click += new System.EventHandler(this.button_dell_Click);
            // 
            // listBox_searchskill
            // 
            this.listBox_searchskill.FormattingEnabled = true;
            this.listBox_searchskill.ItemHeight = 18;
            this.listBox_searchskill.Location = new System.Drawing.Point(360, 10);
            this.listBox_searchskill.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBox_searchskill.Name = "listBox_searchskill";
            this.listBox_searchskill.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_searchskill.Size = new System.Drawing.Size(254, 544);
            this.listBox_searchskill.TabIndex = 3;
            this.listBox_searchskill.DoubleClick += new System.EventHandler(this.listBox_searchskill_DoubleClick);
            this.listBox_searchskill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_searchskill_KeyDown);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(493, 566);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(125, 34);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(358, 566);
            this.button_ok.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(125, 34);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            // 
            // skillBaseTreeView1
            // 
            this.skillBaseTreeView1.AllowDrop = true;
            this.skillBaseTreeView1.Location = new System.Drawing.Point(20, 10);
            this.skillBaseTreeView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.skillBaseTreeView1.Name = "skillBaseTreeView1";
            this.skillBaseTreeView1.Size = new System.Drawing.Size(254, 544);
            this.skillBaseTreeView1.TabIndex = 0;
            this.skillBaseTreeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.skillBaseTreeView1_NodeMouseDoubleClick);
            // 
            // SkillConditionEditDialog
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(637, 618);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.listBox_searchskill);
            this.Controls.Add(this.button_dell);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.skillBaseTreeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SkillConditionEditDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skill condition";
            this.Load += new System.EventHandler(this.SkillConditionEditDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SkillBaseTreeView skillBaseTreeView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_dell;
        private System.Windows.Forms.ListBox listBox_searchskill;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
    }
}