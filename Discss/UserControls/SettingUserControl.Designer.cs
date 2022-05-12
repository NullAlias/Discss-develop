
namespace Discss.UserControls
{
    partial class SettingUserControl
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
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.channelGroupBox = new System.Windows.Forms.GroupBox();
            this.urlGroupBox = new System.Windows.Forms.GroupBox();
            this.cssGroupBox = new System.Windows.Forms.GroupBox();
            this.charaInGroupBox = new System.Windows.Forms.GroupBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.urlButton = new System.Windows.Forms.Button();
            this.cssButton = new System.Windows.Forms.Button();
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.channelComboBox = new System.Windows.Forms.ComboBox();
            this.characterCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.cssTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.serverGroupBox.SuspendLayout();
            this.channelGroupBox.SuspendLayout();
            this.urlGroupBox.SuspendLayout();
            this.cssGroupBox.SuspendLayout();
            this.charaInGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.charaInGroupBox, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.cssGroupBox, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.urlGroupBox, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.serverGroupBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.channelGroupBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.outputButton, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.urlButton, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.cssButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(518, 640);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // serverGroupBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.serverGroupBox, 2);
            this.serverGroupBox.Controls.Add(this.serverComboBox);
            this.serverGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serverGroupBox.Location = new System.Drawing.Point(3, 3);
            this.serverGroupBox.Name = "serverGroupBox";
            this.serverGroupBox.Size = new System.Drawing.Size(512, 44);
            this.serverGroupBox.TabIndex = 0;
            this.serverGroupBox.TabStop = false;
            this.serverGroupBox.Text = "サーバー";
            // 
            // channelGroupBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.channelGroupBox, 2);
            this.channelGroupBox.Controls.Add(this.channelComboBox);
            this.channelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.channelGroupBox.Location = new System.Drawing.Point(3, 53);
            this.channelGroupBox.Name = "channelGroupBox";
            this.channelGroupBox.Size = new System.Drawing.Size(512, 44);
            this.channelGroupBox.TabIndex = 1;
            this.channelGroupBox.TabStop = false;
            this.channelGroupBox.Text = "チャンネル";
            // 
            // urlGroupBox
            // 
            this.urlGroupBox.Controls.Add(this.urlTextBox);
            this.urlGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.urlGroupBox.Location = new System.Drawing.Point(3, 493);
            this.urlGroupBox.Name = "urlGroupBox";
            this.urlGroupBox.Size = new System.Drawing.Size(382, 44);
            this.urlGroupBox.TabIndex = 1;
            this.urlGroupBox.TabStop = false;
            this.urlGroupBox.Text = "URL";
            // 
            // cssGroupBox
            // 
            this.cssGroupBox.Controls.Add(this.cssTextBox);
            this.cssGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cssGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cssGroupBox.Location = new System.Drawing.Point(3, 543);
            this.cssGroupBox.Name = "cssGroupBox";
            this.cssGroupBox.Size = new System.Drawing.Size(382, 94);
            this.cssGroupBox.TabIndex = 1;
            this.cssGroupBox.TabStop = false;
            this.cssGroupBox.Text = "カスタムCSS";
            // 
            // charaInGroupBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.charaInGroupBox, 2);
            this.charaInGroupBox.Controls.Add(this.characterCheckedListBox);
            this.charaInGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charaInGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.charaInGroupBox.Location = new System.Drawing.Point(3, 103);
            this.charaInGroupBox.Name = "charaInGroupBox";
            this.charaInGroupBox.Size = new System.Drawing.Size(512, 334);
            this.charaInGroupBox.TabIndex = 2;
            this.charaInGroupBox.TabStop = false;
            this.charaInGroupBox.Text = "キャラ一覧";
            // 
            // outputButton
            // 
            this.tableLayoutPanel.SetColumnSpan(this.outputButton, 2);
            this.outputButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputButton.Location = new System.Drawing.Point(3, 443);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(512, 44);
            this.outputButton.TabIndex = 6;
            this.outputButton.Text = "出力";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // urlButton
            // 
            this.urlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.urlButton.Location = new System.Drawing.Point(391, 493);
            this.urlButton.Name = "urlButton";
            this.urlButton.Size = new System.Drawing.Size(124, 44);
            this.urlButton.TabIndex = 7;
            this.urlButton.Text = "クリップボードに貼り付け";
            this.urlButton.UseVisualStyleBackColor = true;
            this.urlButton.Click += new System.EventHandler(this.urlButton_Click);
            // 
            // cssButton
            // 
            this.cssButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cssButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cssButton.Location = new System.Drawing.Point(391, 543);
            this.cssButton.Name = "cssButton";
            this.cssButton.Size = new System.Drawing.Size(124, 94);
            this.cssButton.TabIndex = 8;
            this.cssButton.Text = "クリップボードに貼り付け";
            this.cssButton.UseVisualStyleBackColor = true;
            this.cssButton.Click += new System.EventHandler(this.cssButton_Click);
            // 
            // serverComboBox
            // 
            this.serverComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverComboBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Location = new System.Drawing.Point(3, 16);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(506, 24);
            this.serverComboBox.TabIndex = 0;
            this.serverComboBox.SelectionChangeCommitted += new System.EventHandler(this.serverComboBox_SelectionChangeCommitted);
            // 
            // channelComboBox
            // 
            this.channelComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelComboBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.channelComboBox.FormattingEnabled = true;
            this.channelComboBox.Location = new System.Drawing.Point(3, 16);
            this.channelComboBox.Name = "channelComboBox";
            this.channelComboBox.Size = new System.Drawing.Size(506, 24);
            this.channelComboBox.TabIndex = 1;
            // 
            // characterCheckedListBox
            // 
            this.characterCheckedListBox.CheckOnClick = true;
            this.characterCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterCheckedListBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.characterCheckedListBox.FormattingEnabled = true;
            this.characterCheckedListBox.Location = new System.Drawing.Point(3, 16);
            this.characterCheckedListBox.Name = "characterCheckedListBox";
            this.characterCheckedListBox.Size = new System.Drawing.Size(506, 315);
            this.characterCheckedListBox.TabIndex = 0;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlTextBox.Location = new System.Drawing.Point(3, 16);
            this.urlTextBox.Multiline = true;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.ReadOnly = true;
            this.urlTextBox.Size = new System.Drawing.Size(376, 25);
            this.urlTextBox.TabIndex = 0;
            // 
            // cssTextBox
            // 
            this.cssTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cssTextBox.Location = new System.Drawing.Point(3, 16);
            this.cssTextBox.Multiline = true;
            this.cssTextBox.Name = "cssTextBox";
            this.cssTextBox.ReadOnly = true;
            this.cssTextBox.Size = new System.Drawing.Size(376, 75);
            this.cssTextBox.TabIndex = 1;
            // 
            // SettingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "SettingUserControl";
            this.Size = new System.Drawing.Size(518, 640);
            this.Load += new System.EventHandler(this.SettingUserControl_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.serverGroupBox.ResumeLayout(false);
            this.channelGroupBox.ResumeLayout(false);
            this.urlGroupBox.ResumeLayout(false);
            this.urlGroupBox.PerformLayout();
            this.cssGroupBox.ResumeLayout(false);
            this.cssGroupBox.PerformLayout();
            this.charaInGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox charaInGroupBox;
        private System.Windows.Forms.CheckedListBox characterCheckedListBox;
        private System.Windows.Forms.GroupBox cssGroupBox;
        private System.Windows.Forms.TextBox cssTextBox;
        private System.Windows.Forms.GroupBox urlGroupBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.GroupBox serverGroupBox;
        private System.Windows.Forms.ComboBox serverComboBox;
        private System.Windows.Forms.GroupBox channelGroupBox;
        private System.Windows.Forms.ComboBox channelComboBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button urlButton;
        private System.Windows.Forms.Button cssButton;
    }
}
