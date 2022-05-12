using Discss.Common.Accessor;
using Discss.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discss.UserControls
{
    public partial class SettingUserControl : UserControl
    {
        #region コンストラクタ
        public SettingUserControl()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント
        /// <summary>
        /// 画面ロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingUserControl_Load(object sender, EventArgs e)
        {
            SetServerCombobox();
            SetCharacterList();

        }

        /// <summary>
        /// サーバー選択変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetChannelCombobox((string)serverComboBox.SelectedValue);
        }

        /// <summary>
        /// 出力ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputButton_Click(object sender, EventArgs e)
        {
            //検証
            if(serverComboBox.Items.Count == 0)
            {
                MessageBox.Show("サーバー情報が登録されていません。サーバー設定画面でサーバーを登録してください。", "出力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(channelComboBox.Items.Count == 0)
            {
                MessageBox.Show("チャンネル情報が登録されていません。サーバー設定画面でサーバーを登録してください。", "出力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (characterCheckedListBox.Items.Count == 0)
            {
                MessageBox.Show("キャラクター情報が登録されていません。キャラクター設定画面でキャラクターを登録してください。", "出力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(characterCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("キャラクターが選択されていません。必ず1人以上のキャラクターを選択してください。", "出力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //URL作成
            CreateURL();
            //Css作成
            CreateCss();
        }

        private void urlButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(urlTextBox.Text);
            MessageBox.Show("クリップボードにURLをコピーしました。", "コピー", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cssButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(cssTextBox.Text);
            MessageBox.Show("クリップボードにカスタムCSSをコピーしました。", "コピー", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region プライベートメソッド
        /// <summary>
        /// サーバーコンボボックス設定
        /// </summary>
        private void SetServerCombobox()
        {
            //サーバーコンボボックスに値を設定
            Dictionary<string, string> serverDict = new Dictionary<string, string>();
            foreach (Server server in ServerParamAccessor.Servers.server)
            {
                if (server.server_id != "") serverDict.Add(server.server_id, server.server_name);
            }
            serverComboBox.DataSource = serverDict.ToArray();
            serverComboBox.DisplayMember = "value";
            serverComboBox.ValueMember = "key";

            if(serverDict.Count != 0)
            {
                SetChannelCombobox((string)serverDict.Keys.ToArray()[0]);
            }
        }

        /// <summary>
        /// チャンネルコンボボックス設定
        /// </summary>
        /// <param name="serverId"></param>
        private void SetChannelCombobox(string serverId)
        {
            ChatChannel[] channels = null;
            foreach (Server server in ServerParamAccessor.Servers.server)
            {
                if (server.server_id == serverId)
                {
                    channels = (ChatChannel[])server.chat_channel.ToArray(typeof(ChatChannel));
                    break;
                }
            }
            //サーバーコンボボックスに値を設定
            Dictionary<string, string> channelrDict = new Dictionary<string, string>();
            if (channels != null)
            {
                foreach (ChatChannel ch in channels)
                {
                    if (ch.channel_id != "") channelrDict.Add(ch.channel_id, ch.channel_name);
                }
            }
            channelComboBox.DataSource = channelrDict.ToArray();
            channelComboBox.DisplayMember = "value";
            channelComboBox.ValueMember = "key";
        }

        /// <summary>
        /// キャラクターチェックリスト設定
        /// </summary>
        private void SetCharacterList()
        {
            Dictionary<string, string> charDict = new Dictionary<string, string>();
            if (CharacterParamAccessor.Characters.character != null)
            {
                foreach (Objects.Character chara in CharacterParamAccessor.Characters.character)
                {
                    if (chara.char_id != "") charDict.Add(chara.char_id, chara.char_name);
                }
            }

            characterCheckedListBox.DataSource = charDict.ToArray();
            characterCheckedListBox.DisplayMember = "value";
            characterCheckedListBox.ValueMember = "key";
        }

        /// <summary>
        /// サーバーとチャンネルの情報からURLを作成する
        /// </summary>
        private void CreateURL()
        {
            string urlFormat = "https://streamkit.discord.com/overlay/voice/{0}/{1}";
            urlTextBox.Text = string.Format(urlFormat, serverComboBox.SelectedValue, channelComboBox.SelectedValue);
        }

        private void CreateCss()
        {
            //選択されているキャラクタの辞書を作成する
            Dictionary<string, string> chraDict = new Dictionary<string, string>();
            foreach(object item in characterCheckedListBox.CheckedItems)
            {
                string id = item.ToString().Replace("[", "").Split(',')[0];

                foreach(Character chara in CharacterParamAccessor.Characters.character)
                {
                    if(chara.char_id == id)
                    {
                        if(chara.char_image.Count > 0)
                        {
                            foreach (CharacterImage image in chara.char_image)
                            {
                                if (image.is_use)
                                {
                                    chraDict.Add(chara.char_id, string.Format("http://localhost:{0}/{1}.png", Properties.Settings.Default.Port, image.image_id));
                                    break;
                                }
                            }
                        }
                        else
                        {
                            chraDict.Add(chara.char_id, string.Format("http://localhost:{0}/{1}.png", Properties.Settings.Default.Port, "default.png"));
                        }
                    }
                    break;
                }
            }

            //CSSの作成
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("body { background-color: rgba(0, 0, 0, 0); overflow: hidden;}");
            sb.AppendLine("ul.voice-states { list-style: none; display: flex; justify-content: center; width: 100vw; height: 100vh;}");
            sb.Append("li.voice-state");
            foreach(string key in chraDict.Keys) sb.Append($":not([data-reactid*=\"{key}\"])");
            sb.AppendLine("{display:none; }");
            foreach(string key in chraDict.Keys)
            {
                sb.AppendLine("img.avatar[data-reactid *= \""+key+"\"] { content:url(\""+ chraDict[key] + "\");}");
            }
            sb.AppendLine("li.voice-state { position: relative; text-align: center;}");
            sb.AppendLine("img.avatar{ height: auto !important; width: 100% !important; border-radius:0 !important; }");
            sb.AppendLine("div.user{ position: absolute; right: 0; left: 0; top: 20px; bottom:0; margin: auto;}");
            sb.AppendLine(".speaking {border-color:rgba(0,0,0,0) !important; position:relative; animation-name: speak-now; animation-duration: 300ms; nimation-fill-mode:forwards;}");
            sb.AppendLine("@keyframes speak-now { 0% { bottom:0px; } 50% { bottom:10px; } 100% { bottom:0px; }}");
            cssTextBox.Text = sb.ToString();



        }

        #endregion

        
    }
}
