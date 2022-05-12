
namespace Discss
{
    partial class MainForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DSOButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.characterButton = new System.Windows.Forms.Button();
            this.serverButton = new System.Windows.Forms.Button();
            this.imageServerToggleButton = new System.Windows.Forms.Button();
            this.menuSplitter = new System.Windows.Forms.Splitter();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.colseButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPanel.Controls.Add(this.tableLayoutPanel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 450);
            this.menuPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.colseButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.DSOButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.settingButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.characterButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.serverButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageServerToggleButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DSOButton
            // 
            this.DSOButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DSOButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DSOButton.Location = new System.Drawing.Point(3, 153);
            this.DSOButton.Name = "DSOButton";
            this.DSOButton.Size = new System.Drawing.Size(194, 44);
            this.DSOButton.TabIndex = 3;
            this.DSOButton.Text = "Discord Streamkit Overlay";
            this.DSOButton.UseVisualStyleBackColor = true;
            this.DSOButton.Click += new System.EventHandler(this.DSOButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.settingButton.Location = new System.Drawing.Point(3, 103);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(194, 44);
            this.settingButton.TabIndex = 2;
            this.settingButton.Text = "出力設定";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // characterButton
            // 
            this.characterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.characterButton.Location = new System.Drawing.Point(3, 53);
            this.characterButton.Name = "characterButton";
            this.characterButton.Size = new System.Drawing.Size(194, 44);
            this.characterButton.TabIndex = 1;
            this.characterButton.Text = "キャラ設定";
            this.characterButton.UseVisualStyleBackColor = true;
            this.characterButton.Click += new System.EventHandler(this.characterButton_Click);
            // 
            // serverButton
            // 
            this.serverButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serverButton.Location = new System.Drawing.Point(3, 3);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(194, 44);
            this.serverButton.TabIndex = 0;
            this.serverButton.Text = "サーバー設定";
            this.serverButton.UseVisualStyleBackColor = true;
            this.serverButton.Click += new System.EventHandler(this.serverButton_Click);
            // 
            // imageServerToggleButton
            // 
            this.imageServerToggleButton.BackColor = System.Drawing.Color.SeaGreen;
            this.imageServerToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageServerToggleButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.imageServerToggleButton.ForeColor = System.Drawing.Color.White;
            this.imageServerToggleButton.Location = new System.Drawing.Point(3, 203);
            this.imageServerToggleButton.Name = "imageServerToggleButton";
            this.imageServerToggleButton.Size = new System.Drawing.Size(194, 44);
            this.imageServerToggleButton.TabIndex = 4;
            this.imageServerToggleButton.Text = "画像公開開始";
            this.imageServerToggleButton.UseVisualStyleBackColor = false;
            this.imageServerToggleButton.Click += new System.EventHandler(this.imageServerToggleButton_Click);
            // 
            // menuSplitter
            // 
            this.menuSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuSplitter.Location = new System.Drawing.Point(200, 0);
            this.menuSplitter.Name = "menuSplitter";
            this.menuSplitter.Size = new System.Drawing.Size(3, 450);
            this.menuSplitter.TabIndex = 1;
            this.menuSplitter.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(203, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(597, 450);
            this.mainPanel.TabIndex = 2;
            // 
            // colseButton
            // 
            this.colseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colseButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.colseButton.Location = new System.Drawing.Point(3, 403);
            this.colseButton.Name = "colseButton";
            this.colseButton.Size = new System.Drawing.Size(194, 44);
            this.colseButton.TabIndex = 5;
            this.colseButton.Text = "閉じる";
            this.colseButton.UseVisualStyleBackColor = true;
            this.colseButton.Click += new System.EventHandler(this.colseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuSplitter);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.Text = "CSS作成ツール";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Splitter menuSplitter;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DSOButton;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button characterButton;
        private System.Windows.Forms.Button serverButton;
        private System.Windows.Forms.Button imageServerToggleButton;
        private System.Windows.Forms.Button colseButton;
    }
}

