namespace MHSX2
{
    partial class TypeNumOrderDialog
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
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.typeOrderListView1 = new MHSX2.TypeOrderListView();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(150, 258);
            this.button_OK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(125, 34);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(285, 258);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(125, 34);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // typeOrderListView1
            // 
            this.typeOrderListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeOrderListView1.FullRowSelect = true;
            this.typeOrderListView1.GridLines = true;
            this.typeOrderListView1.HideSelection = false;
            this.typeOrderListView1.Location = new System.Drawing.Point(20, 18);
            this.typeOrderListView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.typeOrderListView1.Name = "typeOrderListView1";
            this.typeOrderListView1.Size = new System.Drawing.Size(517, 229);
            this.typeOrderListView1.TabIndex = 0;
            this.typeOrderListView1.UseCompatibleStateImageBehavior = false;
            this.typeOrderListView1.View = System.Windows.Forms.View.Details;
            // 
            // TypeNumOrderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 310);
            this.Controls.Add(this.typeOrderListView1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(444, 340);
            this.Name = "TypeNumOrderDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set special armor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        private TypeOrderListView typeOrderListView1;
    }
}