
namespace Discss
{
    partial class ServerUserControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.entryButton = new System.Windows.Forms.Button();
            this.serverNameGroupBox = new System.Windows.Forms.GroupBox();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.serverListGroupBox = new System.Windows.Forms.GroupBox();
            this.serverListComboBox = new System.Windows.Forms.ComboBox();
            this.serverIdGroupBox = new System.Windows.Forms.GroupBox();
            this.serverIdTextBox = new System.Windows.Forms.TextBox();
            this.channelListGroupBox = new System.Windows.Forms.GroupBox();
            this.channnelListComboBox1 = new System.Windows.Forms.ComboBox();
            this.cannelIdGroupBox = new System.Windows.Forms.GroupBox();
            this.channelIdTextBox = new System.Windows.Forms.TextBox();
            this.channelNameGroupBox = new System.Windows.Forms.GroupBox();
            this.channelNameTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.serverNameGroupBox.SuspendLayout();
            this.serverListGroupBox.SuspendLayout();
            this.serverIdGroupBox.SuspendLayout();
            this.channelListGroupBox.SuspendLayout();
            this.cannelIdGroupBox.SuspendLayout();
            this.channelNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.entryButton, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.serverNameGroupBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.serverListGroupBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.serverIdGroupBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.channelListGroupBox, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.cannelIdGroupBox, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.channelNameGroupBox, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.deleteButton, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(542, 635);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // entryButton
            // 
            this.entryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.entryButton.Location = new System.Drawing.Point(274, 203);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(265, 34);
            this.entryButton.TabIndex = 8;
            this.entryButton.Text = "登録";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // serverNameGroupBox
            // 
            this.serverNameGroupBox.Controls.Add(this.serverNameTextBox);
            this.serverNameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverNameGroupBox.Location = new System.Drawing.Point(274, 53);
            this.serverNameGroupBox.Name = "serverNameGroupBox";
            this.serverNameGroupBox.Size = new System.Drawing.Size(265, 44);
            this.serverNameGroupBox.TabIndex = 3;
            this.serverNameGroupBox.TabStop = false;
            this.serverNameGroupBox.Text = "サーバー名";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serverNameTextBox.Location = new System.Drawing.Point(3, 15);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(259, 23);
            this.serverNameTextBox.TabIndex = 0;
            // 
            // serverListGroupBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.serverListGroupBox, 2);
            this.serverListGroupBox.Controls.Add(this.serverListComboBox);
            this.serverListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverListGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serverListGroupBox.Location = new System.Drawing.Point(3, 3);
            this.serverListGroupBox.Name = "serverListGroupBox";
            this.serverListGroupBox.Size = new System.Drawing.Size(536, 44);
            this.serverListGroupBox.TabIndex = 1;
            this.serverListGroupBox.TabStop = false;
            this.serverListGroupBox.Text = "サーバー";
            // 
            // serverListComboBox
            // 
            this.serverListComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverListComboBox.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serverListComboBox.Location = new System.Drawing.Point(3, 16);
            this.serverListComboBox.Name = "serverListComboBox";
            this.serverListComboBox.Size = new System.Drawing.Size(530, 27);
            this.serverListComboBox.TabIndex = 0;
            this.serverListComboBox.SelectionChangeCommitted += new System.EventHandler(this.serverListComboBox_SelectionChangeCommitted);
            // 
            // serverIdGroupBox
            // 
            this.serverIdGroupBox.Controls.Add(this.serverIdTextBox);
            this.serverIdGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverIdGroupBox.Location = new System.Drawing.Point(3, 53);
            this.serverIdGroupBox.Name = "serverIdGroupBox";
            this.serverIdGroupBox.Size = new System.Drawing.Size(265, 44);
            this.serverIdGroupBox.TabIndex = 2;
            this.serverIdGroupBox.TabStop = false;
            this.serverIdGroupBox.Text = "サーバーID";
            // 
            // serverIdTextBox
            // 
            this.serverIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverIdTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serverIdTextBox.Location = new System.Drawing.Point(3, 15);
            this.serverIdTextBox.Name = "serverIdTextBox";
            this.serverIdTextBox.Size = new System.Drawing.Size(259, 23);
            this.serverIdTextBox.TabIndex = 0;
            // 
            // channelListGroupBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.channelListGroupBox, 2);
            this.channelListGroupBox.Controls.Add(this.channnelListComboBox1);
            this.channelListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelListGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.channelListGroupBox.Location = new System.Drawing.Point(3, 103);
            this.channelListGroupBox.Name = "channelListGroupBox";
            this.channelListGroupBox.Size = new System.Drawing.Size(536, 44);
            this.channelListGroupBox.TabIndex = 4;
            this.channelListGroupBox.TabStop = false;
            this.channelListGroupBox.Text = "ボイスチャンネル";
            // 
            // channnelListComboBox1
            // 
            this.channnelListComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channnelListComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channnelListComboBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.channnelListComboBox1.Location = new System.Drawing.Point(3, 16);
            this.channnelListComboBox1.Name = "channnelListComboBox1";
            this.channnelListComboBox1.Size = new System.Drawing.Size(530, 27);
            this.channnelListComboBox1.TabIndex = 0;
            this.channnelListComboBox1.SelectionChangeCommitted += new System.EventHandler(this.channnelListComboBox1_SelectionChangeCommitted);
            // 
            // cannelIdGroupBox
            // 
            this.cannelIdGroupBox.Controls.Add(this.channelIdTextBox);
            this.cannelIdGroupBox.Location = new System.Drawing.Point(3, 153);
            this.cannelIdGroupBox.Name = "cannelIdGroupBox";
            this.cannelIdGroupBox.Size = new System.Drawing.Size(265, 44);
            this.cannelIdGroupBox.TabIndex = 5;
            this.cannelIdGroupBox.TabStop = false;
            this.cannelIdGroupBox.Text = "チャンネルID";
            // 
            // channelIdTextBox
            // 
            this.channelIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelIdTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.channelIdTextBox.Location = new System.Drawing.Point(3, 15);
            this.channelIdTextBox.Name = "channelIdTextBox";
            this.channelIdTextBox.Size = new System.Drawing.Size(259, 23);
            this.channelIdTextBox.TabIndex = 0;
            // 
            // channelNameGroupBox
            // 
            this.channelNameGroupBox.Controls.Add(this.channelNameTextBox);
            this.channelNameGroupBox.Location = new System.Drawing.Point(274, 153);
            this.channelNameGroupBox.Name = "channelNameGroupBox";
            this.channelNameGroupBox.Size = new System.Drawing.Size(265, 44);
            this.channelNameGroupBox.TabIndex = 6;
            this.channelNameGroupBox.TabStop = false;
            this.channelNameGroupBox.Text = "チャンネル名";
            // 
            // channelNameTextBox
            // 
            this.channelNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.channelNameTextBox.Location = new System.Drawing.Point(3, 15);
            this.channelNameTextBox.Name = "channelNameTextBox";
            this.channelNameTextBox.Size = new System.Drawing.Size(259, 23);
            this.channelNameTextBox.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteButton.Location = new System.Drawing.Point(3, 203);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(265, 34);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ServerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ServerUserControl";
            this.Size = new System.Drawing.Size(542, 635);
            this.Load += new System.EventHandler(this.ServerUserControl_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.serverNameGroupBox.ResumeLayout(false);
            this.serverNameGroupBox.PerformLayout();
            this.serverListGroupBox.ResumeLayout(false);
            this.serverIdGroupBox.ResumeLayout(false);
            this.serverIdGroupBox.PerformLayout();
            this.channelListGroupBox.ResumeLayout(false);
            this.cannelIdGroupBox.ResumeLayout(false);
            this.cannelIdGroupBox.PerformLayout();
            this.channelNameGroupBox.ResumeLayout(false);
            this.channelNameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox serverListGroupBox;
        private System.Windows.Forms.ComboBox serverListComboBox;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.GroupBox serverNameGroupBox;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.GroupBox serverIdGroupBox;
        private System.Windows.Forms.TextBox serverIdTextBox;
        private System.Windows.Forms.GroupBox channelListGroupBox;
        private System.Windows.Forms.ComboBox channnelListComboBox1;
        private System.Windows.Forms.GroupBox cannelIdGroupBox;
        private System.Windows.Forms.TextBox channelIdTextBox;
        private System.Windows.Forms.GroupBox channelNameGroupBox;
        private System.Windows.Forms.TextBox channelNameTextBox;
        private System.Windows.Forms.Button deleteButton;
    }
}
