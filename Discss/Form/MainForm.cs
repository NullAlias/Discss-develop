using Discss.Common.Accessor;
using Discss.Objects;
using Discss.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discss
{
    public partial class MainForm : Form
    {
        #region プライベートメンバ
        bool isImageServerRunning = false;
        Process imageServerProcess = null;
        #endregion
        #region コンストラクタ
        public MainForm()
        {
            InitializeComponent();

        }
        #endregion

        #region イベント
        /// <summary>
        /// メイン画面読み込みイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            mainPanel.Controls.Add( new SettingUserControl());
        }
        private void serverButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new ServerUserControl());
        }

        private void characterButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new CharacterUserControl());
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new SettingUserControl());
        }

        private void DSOButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://streamkit.discord.com/overlay");
        }

        private void imageServerToggleButton_Click(object sender, EventArgs e)
        {
            ToggleServerRunning();


            if (isImageServerRunning)
            {
                this.imageServerToggleButton.BackColor = Color.OrangeRed;
                this.imageServerToggleButton.Text = "画像公開停止";
            }
            else
            {
                this.imageServerToggleButton.BackColor = Color.SeaGreen;
                this.imageServerToggleButton.Text = "画像公開開始";

            }
        }

        private void colseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isImageServerRunning)
            {
                MessageBox.Show("画像を公開中です。停止してから終了してください", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                imageServerToggleButton.Focus();
                e.Cancel = true;
            }
        }
        #endregion

        #region プライベートメソッド
        private void ToggleServerRunning()
        {
            string root = System.Environment.CurrentDirectory;
            try
            {
                if(imageServerProcess != null)
                {
                    if (!imageServerProcess.HasExited)
                    {
                        imageServerProcess.Kill();
                    }
                    imageServerProcess = null;
                    isImageServerRunning = false;
                }
                else
                {
                    System.Environment.CurrentDirectory = DirectoryAccessor.ImageDir;
                    bool isDisplay = false;
                    imageServerProcess = Process.Start(new ProcessStartInfo() { 
                                                        FileName="python",
                                                        Arguments= "-m http.server "+ Properties.Settings.Default.Port.ToString(),
                                                        UseShellExecute=isDisplay,
                                                        CreateNoWindow=!isDisplay
                    });
                    isImageServerRunning = true;
                }
            }
            catch
            {
                imageServerProcess = null;
                isImageServerRunning = false;
            }
            finally
            {
                System.Environment.CurrentDirectory = root;
            }
        }


        #endregion

        
    }
}
