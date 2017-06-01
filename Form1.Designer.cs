namespace HangulFixer
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.listFile = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btFindDir = new System.Windows.Forms.ToolStripButton();
            this.btDo = new System.Windows.Forms.ToolStripButton();
            this.btAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFindDir,
            this.btDo,
            this.btAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(682, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // listFile
            // 
            this.listFile.CheckBoxes = true;
            this.listFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFile.Location = new System.Drawing.Point(0, 25);
            this.listFile.Name = "listFile";
            this.listFile.Size = new System.Drawing.Size(682, 341);
            this.listFile.TabIndex = 1;
            this.listFile.UseCompatibleStateImageBehavior = false;
            this.listFile.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "현재 이름";
            this.columnHeader1.Width = 280;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "바뀔 이름";
            this.columnHeader2.Width = 257;
            // 
            // btFindDir
            // 
            this.btFindDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFindDir.Image = global::HangulFixer.Properties.Resources.folder_horizontal_open_icon;
            this.btFindDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFindDir.Name = "btFindDir";
            this.btFindDir.Size = new System.Drawing.Size(23, 22);
            this.btFindDir.Text = "toolStripButton1";
            this.btFindDir.Click += new System.EventHandler(this.btFindDir_Click);
            // 
            // btDo
            // 
            this.btDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDo.Image = global::HangulFixer.Properties.Resources.control_icon;
            this.btDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDo.Name = "btDo";
            this.btDo.Size = new System.Drawing.Size(23, 22);
            this.btDo.Text = "toolStripButton2";
            this.btDo.Click += new System.EventHandler(this.btDo_Click);
            // 
            // btAbout
            // 
            this.btAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAbout.Image = global::HangulFixer.Properties.Resources.information_octagon_icon;
            this.btAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(23, 22);
            this.btAbout.Text = "toolStripButton3";
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 366);
            this.Controls.Add(this.listFile);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "HangulFixer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btFindDir;
        private System.Windows.Forms.ToolStripButton btDo;
        private System.Windows.Forms.ToolStripButton btAbout;
        private System.Windows.Forms.ListView listFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

