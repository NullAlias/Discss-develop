
namespace Discss.UserControls
{
    partial class CharacterUserControl
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.defaultButton = new System.Windows.Forms.Button();
            this.characterNameGroupBox = new System.Windows.Forms.GroupBox();
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.CharacterGroupBox = new System.Windows.Forms.GroupBox();
            this.characterListComboBox = new System.Windows.Forms.ComboBox();
            this.characterIdGroupBox = new System.Windows.Forms.GroupBox();
            this.characterIdTextBox = new System.Windows.Forms.TextBox();
            this.imageListGroupBox = new System.Windows.Forms.GroupBox();
            this.imageListView = new System.Windows.Forms.ListView();
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.entryButton = new System.Windows.Forms.Button();
            this.refsImageFileButton = new System.Windows.Forms.Button();
            this.imageNameGroupBox = new System.Windows.Forms.GroupBox();
            this.imageNameTextBox = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            this.characterNameGroupBox.SuspendLayout();
            this.CharacterGroupBox.SuspendLayout();
            this.characterIdGroupBox.SuspendLayout();
            this.imageListGroupBox.SuspendLayout();
            this.imageGroupBox.SuspendLayout();
            this.imageNameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.defaultButton, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.characterNameGroupBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.CharacterGroupBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.characterIdGroupBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.imageListGroupBox, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.imageGroupBox, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.deleteButton, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.entryButton, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.refsImageFileButton, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.imageNameGroupBox, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 8;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(520, 651);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // defaultButton
            // 
            this.defaultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.defaultButton.Location = new System.Drawing.Point(263, 353);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(254, 44);
            this.defaultButton.TabIndex = 12;
            this.defaultButton.Text = "デフォルトにする";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // characterNameGroupBox
            // 
            this.characterNameGroupBox.Controls.Add(this.characterNameTextBox);
            this.characterNameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterNameGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.characterNameGroupBox.Location = new System.Drawing.Point(263, 53);
            this.characterNameGroupBox.Name = "characterNameGroupBox";
            this.characterNameGroupBox.Size = new System.Drawing.Size(254, 44);
            this.characterNameGroupBox.TabIndex = 2;
            this.characterNameGroupBox.TabStop = false;
            this.characterNameGroupBox.Text = "キャラクター名";
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.characterNameTextBox.Location = new System.Drawing.Point(3, 17);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(248, 23);
            this.characterNameTextBox.TabIndex = 1;
            // 
            // CharacterGroupBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.CharacterGroupBox, 2);
            this.CharacterGroupBox.Controls.Add(this.characterListComboBox);
            this.CharacterGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharacterGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.CharacterGroupBox.Location = new System.Drawing.Point(3, 3);
            this.CharacterGroupBox.Name = "CharacterGroupBox";
            this.CharacterGroupBox.Size = new System.Drawing.Size(514, 44);
            this.CharacterGroupBox.TabIndex = 0;
            this.CharacterGroupBox.TabStop = false;
            this.CharacterGroupBox.Text = "キャラクター";
            // 
            // characterListComboBox
            // 
            this.characterListComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterListComboBox.Font = new System.Drawing.Font("MS UI Gothic", 14.25F);
            this.characterListComboBox.FormattingEnabled = true;
            this.characterListComboBox.Location = new System.Drawing.Point(3, 17);
            this.characterListComboBox.Name = "characterListComboBox";
            this.characterListComboBox.Size = new System.Drawing.Size(508, 27);
            this.characterListComboBox.TabIndex = 0;
            this.characterListComboBox.SelectionChangeCommitted += new System.EventHandler(this.characterListComboBox_SelectionChangeCommitted);
            // 
            // characterIdGroupBox
            // 
            this.characterIdGroupBox.Controls.Add(this.characterIdTextBox);
            this.characterIdGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterIdGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.characterIdGroupBox.Location = new System.Drawing.Point(3, 53);
            this.characterIdGroupBox.Name = "characterIdGroupBox";
            this.characterIdGroupBox.Size = new System.Drawing.Size(254, 44);
            this.characterIdGroupBox.TabIndex = 1;
            this.characterIdGroupBox.TabStop = false;
            this.characterIdGroupBox.Text = "キャラクターID";
            // 
            // characterIdTextBox
            // 
            this.characterIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterIdTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.characterIdTextBox.Location = new System.Drawing.Point(3, 17);
            this.characterIdTextBox.Name = "characterIdTextBox";
            this.characterIdTextBox.Size = new System.Drawing.Size(248, 23);
            this.characterIdTextBox.TabIndex = 0;
            // 
            // imageListGroupBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.imageListGroupBox, 2);
            this.imageListGroupBox.Controls.Add(this.imageListView);
            this.imageListGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageListGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.imageListGroupBox.Location = new System.Drawing.Point(3, 103);
            this.imageListGroupBox.Name = "imageListGroupBox";
            this.imageListGroupBox.Size = new System.Drawing.Size(514, 194);
            this.imageListGroupBox.TabIndex = 3;
            this.imageListGroupBox.TabStop = false;
            this.imageListGroupBox.Text = "画像一覧";
            // 
            // imageListView
            // 
            this.imageListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageListView.HideSelection = false;
            this.imageListView.LargeImageList = this.imageList;
            this.imageListView.Location = new System.Drawing.Point(3, 16);
            this.imageListView.MultiSelect = false;
            this.imageListView.Name = "imageListView";
            this.imageListView.Size = new System.Drawing.Size(508, 175);
            this.imageListView.TabIndex = 0;
            this.imageListView.UseCompatibleStateImageBehavior = false;
            this.imageListView.SelectedIndexChanged += new System.EventHandler(this.imageListView_SelectedIndexChanged);
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.pictureBox);
            this.imageGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.imageGroupBox.Location = new System.Drawing.Point(3, 303);
            this.imageGroupBox.Name = "imageGroupBox";
            this.tableLayoutPanel.SetRowSpan(this.imageGroupBox, 4);
            this.imageGroupBox.Size = new System.Drawing.Size(254, 295);
            this.imageGroupBox.TabIndex = 4;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "画像";
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteButton.Location = new System.Drawing.Point(3, 604);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(254, 44);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // entryButton
            // 
            this.entryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.entryButton.Location = new System.Drawing.Point(263, 604);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(254, 44);
            this.entryButton.TabIndex = 9;
            this.entryButton.Text = "登録";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // refsImageFileButton
            // 
            this.refsImageFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refsImageFileButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.refsImageFileButton.Location = new System.Drawing.Point(263, 403);
            this.refsImageFileButton.Name = "refsImageFileButton";
            this.refsImageFileButton.Size = new System.Drawing.Size(254, 44);
            this.refsImageFileButton.TabIndex = 10;
            this.refsImageFileButton.Text = "画像を参照";
            this.refsImageFileButton.UseVisualStyleBackColor = true;
            this.refsImageFileButton.Click += new System.EventHandler(this.refsImageFileButton_Click);
            // 
            // imageNameGroupBox
            // 
            this.imageNameGroupBox.Controls.Add(this.imageNameTextBox);
            this.imageNameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageNameGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.imageNameGroupBox.Location = new System.Drawing.Point(263, 303);
            this.imageNameGroupBox.Name = "imageNameGroupBox";
            this.imageNameGroupBox.Size = new System.Drawing.Size(254, 44);
            this.imageNameGroupBox.TabIndex = 11;
            this.imageNameGroupBox.TabStop = false;
            this.imageNameGroupBox.Text = "画像名";
            // 
            // imageNameTextBox
            // 
            this.imageNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageNameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.imageNameTextBox.Location = new System.Drawing.Point(3, 16);
            this.imageNameTextBox.Name = "imageNameTextBox";
            this.imageNameTextBox.Size = new System.Drawing.Size(248, 23);
            this.imageNameTextBox.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(248, 276);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // CharacterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "CharacterUserControl";
            this.Size = new System.Drawing.Size(520, 651);
            this.Load += new System.EventHandler(this.CharacterUserControl_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.characterNameGroupBox.ResumeLayout(false);
            this.characterNameGroupBox.PerformLayout();
            this.CharacterGroupBox.ResumeLayout(false);
            this.characterIdGroupBox.ResumeLayout(false);
            this.characterIdGroupBox.PerformLayout();
            this.imageListGroupBox.ResumeLayout(false);
            this.imageGroupBox.ResumeLayout(false);
            this.imageNameGroupBox.ResumeLayout(false);
            this.imageNameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox CharacterGroupBox;
        private System.Windows.Forms.ComboBox characterListComboBox;
        private System.Windows.Forms.GroupBox characterNameGroupBox;
        private System.Windows.Forms.GroupBox characterIdGroupBox;
        private System.Windows.Forms.TextBox characterIdTextBox;
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.GroupBox imageListGroupBox;
        private System.Windows.Forms.ListView imageListView;
        private System.Windows.Forms.GroupBox imageGroupBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Button refsImageFileButton;
        private System.Windows.Forms.GroupBox imageNameGroupBox;
        private System.Windows.Forms.TextBox imageNameTextBox;
    }
}
