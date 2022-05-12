using Discss.Common.Accessor;
using Discss.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discss
{
    public partial class ServerUserControl : UserControl
    {
        #region コンストラクタ
        public ServerUserControl()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント
        /// <summary>
        /// コントロールロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerUserControl_Load(object sender, EventArgs e)
        {
            SetServerListCombobox();
            
        }

        /// <summary>
        /// サーバーコンボボックスが変更された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverListComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (serverListComboBox.SelectedValue.ToString() == "new")
            {
                serverIdTextBox.Text = "";
                serverNameTextBox.Text = "";
                serverIdTextBox.Enabled = true;
                SetChannelListCombobox("");
                return;
            }
            
            //テキストボックスに記載
            serverIdTextBox.Text = serverListComboBox.SelectedValue.ToString();
            serverNameTextBox.Text = serverListComboBox.Text;
            serverIdTextBox.Enabled = false;
            SetChannelListCombobox(serverIdTextBox.Text);
        }

        /// <summary>
        /// チャンネルコンボボックスが変更された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void channnelListComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (channnelListComboBox1.SelectedValue.ToString() == "brank" || channnelListComboBox1.SelectedValue.ToString() == "new")
            {
                channelIdTextBox.Text = "";
                channelNameTextBox.Text = "";
                channelIdTextBox.Enabled = true;
                return;
            }
            //検索
            channelIdTextBox.Text = channnelListComboBox1.SelectedValue.ToString();
            channelNameTextBox.Text = channnelListComboBox1.Text;
            channelIdTextBox.Enabled = false;
        }

        /// <summary>
        /// 削除ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string serverId = serverListComboBox.SelectedValue.ToString();
            if (channnelListComboBox1.SelectedValue.ToString() == "brank")
            {
                
                if (serverId == "new")
                {
                    //サーバー項目をクリア
                    serverIdTextBox.Text = "";
                    serverNameTextBox.Text = "";
                    serverIdTextBox.Enabled = true;
                    SetChannelListCombobox("");
                }
                else
                {
                    //サーバー情報を削除
                    DialogResult res = MessageBox.Show(serverListComboBox.Text + "のサーバー情報を削除します。よろしいですか？", "サーバー情報削除", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if(res == DialogResult.Yes)
                    {
                        int idx = -1;
                        for(int i = 0; i < ServerParamAccessor.Servers.server.Count; i++)
                        {
                            Server server = (Server)ServerParamAccessor.Servers.server[i];
                            if(server.server_id == serverId)
                            {
                                idx = i;
                                break;
                            }
                        }
                        if(idx != -1)
                        {
                            ServerParamAccessor.Servers.server.RemoveAt(idx);
                            ServerParamAccessor.SetServer();
                            SetServerListCombobox();
                        }
                    }

                }
            }
            else
            {
                if (channnelListComboBox1.SelectedValue.ToString() == "new")
                {
                    //チャンネル項目をクリア
                    channelIdTextBox.Text = "";
                    channelNameTextBox.Text = "";
                    channelIdTextBox.Enabled = true;
                }
                else
                {
                    //チャンネル情報を削除
                    string channelId = channnelListComboBox1.SelectedValue.ToString();
                    DialogResult res = MessageBox.Show(channnelListComboBox1.Text + "のチャンネル情報を削除します。よろしいですか？", "チャンネル情報削除", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.Yes)
                    {
                        int sidx = -1;
                        int cidx = -1;
                        for (int i = 0; i < ServerParamAccessor.Servers.server.Count; i++)
                        {
                            Server server = (Server)ServerParamAccessor.Servers.server[i];
                            if (server.server_id == serverId)
                            {
                                sidx = i;
                                break;
                            }
                        }
                        if (sidx != -1)
                        {
                            ChatChannel[] chatChannels = (ChatChannel[])((Server)ServerParamAccessor.Servers.server[sidx]).chat_channel.ToArray();
                            for(int i = 0; i < chatChannels.Length; i++)
                            {
                                ChatChannel ch = (ChatChannel)chatChannels[i];
                                if(ch.channel_id == channelId)
                                {
                                    cidx = i;
                                    break;
                                }
                            }
                            if (cidx != -1)
                            {
                                ((Server)ServerParamAccessor.Servers.server[sidx]).chat_channel.RemoveAt(cidx);
                                ServerParamAccessor.SetServer();
                                SetChannelListCombobox("");
                            }
                            
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 登録ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entryButton_Click(object sender, EventArgs e)
        {
            
            if (serverListComboBox.SelectedValue.ToString() == "new")
            {
                Server server = new Server(serverIdTextBox.Text, serverNameTextBox.Text, new System.Collections.ArrayList());
                ServerParamAccessor.Servers.server.Add(server);
            }

            if (channnelListComboBox1.SelectedValue.ToString() != "brank")
            {
                int idx = -1;
                for (int i = 0; i < ServerParamAccessor.Servers.server.Count; i++)
                {
                    Server server = (Server)ServerParamAccessor.Servers.server[i];
                    if (server.server_id == serverIdTextBox.Text)
                    {
                        if(serverListComboBox.SelectedValue.ToString() != "new" && server.server_name != serverNameTextBox.Text)
                        {
                            ((Server)ServerParamAccessor.Servers.server[i]).server_name = serverNameTextBox.Text;
                        }
                        idx = i;
                        break;
                    }
                }
                if(idx != -1)
                {
                    if (channnelListComboBox1.SelectedValue.ToString() == "new")
                    {
                        ((Server)ServerParamAccessor.Servers.server[idx]).AddChannel(new ChatChannel(channelIdTextBox.Text, channelNameTextBox.Text));
                    }
                    else
                    {
                        ChatChannel[] chatChannels = (ChatChannel[])((Server)ServerParamAccessor.Servers.server[idx]).chat_channel.ToArray();
                        for(int i=0; i<chatChannels.Length; i++)
                        {
                            if(channelIdTextBox.Text == chatChannels[i].channel_id)
                            {
                                if(chatChannels[i].channel_name != channelNameTextBox.Text)
                                {
                                    ((ChatChannel)((Server)ServerParamAccessor.Servers.server[idx]).chat_channel[i]).channel_id = channelNameTextBox.Text;
                                }
                                break;
                            }
                        }
                    }   
                }
            }

            ServerParamAccessor.SetServer();
            SetServerListCombobox();
            SetChannelListCombobox("");
        }
        #endregion

        #region プライべートメソッド
        /// <summary>
        /// サーバーコンボボックスの設定
        /// </summary>
        private void SetServerListCombobox()
        {
            //サーバーコンボボックスに値を設定
            Dictionary<string, string> serverDict = new Dictionary<string, string>();
            foreach (Server server in ServerParamAccessor.Servers.server)
            {
                if (server.server_id != "") serverDict.Add(server.server_id, server.server_name);
            }
            serverDict.Add("new", "(新規追加)");
            serverListComboBox.DataSource = serverDict.ToArray();
            serverListComboBox.DisplayMember = "value";
            serverListComboBox.ValueMember = "key";
            if(serverDict.Keys.ToArray()[0] != "new")
            {
                serverIdTextBox.Text = serverDict.Keys.ToArray()[0];
                serverNameTextBox.Text = serverDict[serverIdTextBox.Text];
                serverIdTextBox.Enabled = false;
                SetChannelListCombobox(serverIdTextBox.Text);
            }
            else
            {
                SetChannelListCombobox("");
            }
        }

        private void SetChannelListCombobox(string serverId)
        {
            channelNameTextBox.Clear();
            channelIdTextBox.Clear();
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
            channelrDict.Add("brank", "");
            if (channels != null)
            {
                foreach (ChatChannel ch in channels)
                {
                    if (ch.channel_id != "") channelrDict.Add(ch.channel_id, ch.channel_name);
                }
            }
            channelrDict.Add("new", "(新規追加)");
            channnelListComboBox1.DataSource = channelrDict.ToArray();
            channnelListComboBox1.DisplayMember = "value";
            channnelListComboBox1.ValueMember = "key";
        }


        #endregion

        
    }
}
