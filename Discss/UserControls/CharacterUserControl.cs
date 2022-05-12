using Discss.Common.Accessor;
using Discss.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discss.UserControls
{
    public partial class CharacterUserControl : UserControl
    {
        #region プライベートメンバ
        private List<string> imageId = new List<string>();
#endregion
        #region コンストラクタ
        public CharacterUserControl()
        {
            InitializeComponent();
        }
        #endregion

        #region　イベント
        /// <summary>
        /// 画面読み込みイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharacterUserControl_Load(object sender, EventArgs e)
        {
            SetCharacterListCombobox();
        }

        /// <summary>
        /// コンボボックス変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void characterListComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string charId = (string)characterListComboBox.SelectedValue;
            if(charId == "new")
            {
                characterIdTextBox.Clear();
                characterNameTextBox.Clear();
                characterIdTextBox.Enabled = true;
                SetImageListView("");
            }
            else
            {
                characterIdTextBox.Text = charId;
                characterNameTextBox.Text = characterListComboBox.Text;
                characterIdTextBox.Enabled = false;
                SetImageListView(charId);
            }
        }

        /// <summary>
        /// リストビュー選択変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (imageListView.SelectedItems.Count > 0)
            {
                pictureBox.Visible = true;
                ListViewItem lvi = (ListViewItem)imageListView.SelectedItems[0];
                string targetId = imageId[lvi.ImageIndex];
                //新規作成以外を選択時
                if (targetId != "new")
                {
                    foreach (Objects.Character chara in CharacterParamAccessor.Characters.character)
                    {
                        if (chara.char_id == (string)characterListComboBox.SelectedValue)
                        {
                            foreach(CharacterImage characterImage in chara.char_image)
                            {
                                if(characterImage.image_id == targetId)
                                {
                                    imageNameTextBox.Text = characterImage.image_name;
                                    imageNameTextBox.Enabled = false;
                                    defaultButton.Enabled = !characterImage.is_use;
                                    pictureBox.Image = Image.FromFile(Path.Combine(DirectoryAccessor.ImageDir,targetId+".png"));
                                    refsImageFileButton.Enabled = false;
                                    break;
                                }
                                
                            }
                            break;
                        }
                    }
                }
                else
                {
                    imageNameTextBox.Text = "";
                    imageNameTextBox.Enabled = true;
                    defaultButton.Enabled = false;
                    refsImageFileButton.Enabled = true;
                    pictureBox.Image = Properties.Resources.message;
                }
            }
            else
            {
                imageNameTextBox.Text = "";
                imageNameTextBox.Enabled = false;
                defaultButton.Enabled = false;
                pictureBox.Visible = false;
                refsImageFileButton.Enabled = false;
            }
        }

        /// <summary>
        /// デフォルトにするボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void defaultButton_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = (ListViewItem)imageListView.SelectedItems[0];
            string targetId = imageId[lvi.ImageIndex];
            foreach (Objects.Character chara in CharacterParamAccessor.Characters.character)
            {
                if (chara.char_id == (string)characterListComboBox.SelectedValue)
                {
                    foreach (CharacterImage characterImage in chara.char_image)
                    {
                        if (characterImage.image_id == targetId)
                        {
                            characterImage.is_use = true;
                        }
                        else
                        {
                            characterImage.is_use = false;
                        }

                    }
                    break;
                }
            }
            CharacterParamAccessor.SetCharacter();
        }

        /// <summary>
        /// 画像を参照ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refsImageFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "透過画像(.png) | *.png";
            DialogResult res = ofd.ShowDialog();
            if(res == DialogResult.OK)
            {
                string name = Path.GetFileNameWithoutExtension(ofd.FileName);
                imageNameTextBox.Text = name;
                
                pictureBox.Image = ResizeImage(Image.FromFile(ofd.FileName), 1000);
            }
        }

        /// <summary>
        /// 削除ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string charId = (string)characterListComboBox.SelectedValue;
            //画像の削除
            if (imageListView.SelectedItems.Count > 0)
            {
                ListViewItem lvi = (ListViewItem)imageListView.SelectedItems[0];
                string targetId = imageId[lvi.ImageIndex];
                if(targetId == "new")
                {
                    //新規の場合 入力をクリアするだけ
                    imageNameTextBox.Text = "";
                    imageNameTextBox.Enabled = true;
                    defaultButton.Enabled = false;
                    refsImageFileButton.Enabled = true;
                    pictureBox.Image = Properties.Resources.message;
                }
                else
                {
                    //登録済みの画像の場合
                    DialogResult res = MessageBox.Show(imageNameTextBox.Text + "のキャラクター画像を削除します。よろしいですか？", "キャラクター画像削除", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if(res == DialogResult.Yes)
                    {
                        for (int i = 0; i < CharacterParamAccessor.Characters.character.Count; i++)
                        {
                            if (((Character)CharacterParamAccessor.Characters.character[i]).char_id == charId)
                            {
                                CharacterImage[] characterImage = (CharacterImage[])((Character)CharacterParamAccessor.Characters.character[i]).char_image.ToArray(typeof(CharacterImage));
                                for (int j = 0; j < characterImage.Length; j++)
                                {
                                    if (characterImage[j].image_id == targetId)
                                    {
                                        ((Character)CharacterParamAccessor.Characters.character[i]).char_image.RemoveAt(j);
                                        if (File.Exists(Path.Combine(DirectoryAccessor.ImageDir, targetId + ".png")))
                                        {
                                            File.Delete(Path.Combine(DirectoryAccessor.ImageDir, targetId + ".png"));
                                        }
                                        CharacterParamAccessor.SetCharacter();
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        SetImageListView(charId);
                    }
                    
                }
            }
            else
            {
                //新規追加の場合
                if (charId == "new")
                {
                    //キャラクターが新規作成の場合 パラメータをクリアするだけ
                    characterIdTextBox.Clear();
                    characterNameTextBox.Clear();

                }
                else
                {
                    //登録済みのキャラクターの場合
                    DialogResult res = MessageBox.Show(characterListComboBox.Text + "のキャラクター情報を削除します。よろしいですか？", "キャラクター情報削除", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if(res == DialogResult.Yes)
                    {
                        for (int i = 0; i < CharacterParamAccessor.Characters.character.Count; i++)
                        {
                            if (((Character)CharacterParamAccessor.Characters.character[i]).char_id == charId)
                            {
                                foreach(CharacterImage image in ((Character)CharacterParamAccessor.Characters.character[i]).char_image)
                                {
                                    if (File.Exists(Path.Combine(DirectoryAccessor.ImageDir, image.image_id + ".png")))
                                    {
                                        File.Delete(Path.Combine(DirectoryAccessor.ImageDir, image.image_id + ".png"));
                                    }
                                }
                                CharacterParamAccessor.Characters.character.RemoveAt(i);
                                CharacterParamAccessor.SetCharacter();
                                break;
                            }
                        }
                        SetCharacterListCombobox();
                    }
                }
            }

                
        }

        /// <summary>
        /// 登録ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entryButton_Click(object sender, EventArgs e)
        {
            string charId = (string)characterListComboBox.SelectedValue;
            
            if (charId == "new")
            {
                //キャラクター新規追加の場合
                if (CharacterParamAccessor.Characters.character == null)
                {
                    CharacterParamAccessor.Characters.character = new System.Collections.ArrayList();
                }
                Character character = new Character();
                character.char_id = characterIdTextBox.Text;
                character.char_name = characterNameTextBox.Text;
                if (imageListView.SelectedItems.Count > 0)
                {
                    //画像を追加する場合
                    CharacterImage ci = new CharacterImage(imageNameTextBox.Text, true);
                    pictureBox.Image.Save(Path.Combine(DirectoryAccessor.ImageDir, ci.image_id + ".png"));
                    character.char_image.Add(ci);
                }
                CharacterParamAccessor.Characters.character.Add(character);
                CharacterParamAccessor.SetCharacter();
                SetCharacterListCombobox();
            }
            else
            {
                //画像の追加の場合
                if (imageListView.SelectedItems.Count > 0)
                {
                    Character character = null;
                    foreach(Character chara in CharacterParamAccessor.Characters.character)
                    {
                        if (chara.char_id == charId) character = chara;
                    }
                    ListViewItem lvi = (ListViewItem)imageListView.SelectedItems[0];
                    if(imageId[lvi.ImageIndex] == "new")
                    {
                        for(int i=0; i < CharacterParamAccessor.Characters.character.Count; i++)
                        {
                            if(((Character)CharacterParamAccessor.Characters.character[i]).char_id == charId)
                            {
                                CharacterImage ci = new CharacterImage(imageNameTextBox.Text);
                                pictureBox.Image.Save(Path.Combine(DirectoryAccessor.ImageDir, ci.image_id + ".png"));
                                ((Character)CharacterParamAccessor.Characters.character[i]).char_image.Add(ci);
                                CharacterParamAccessor.SetCharacter();
                                break;
                            }
                        }
                        SetImageListView(charId);
                    }
                }
                else
                {
                    for(int i = 0; i < CharacterParamAccessor.Characters.character.Count; i++)
                    {
                        if(((Character)CharacterParamAccessor.Characters.character[i]).char_id == charId)
                        {
                            ((Character)CharacterParamAccessor.Characters.character[i]).char_name = characterNameTextBox.Text;
                            CharacterParamAccessor.SetCharacter();
                            break;
                        }
                    }
                    SetCharacterListCombobox();
                }
                
            }
        }
        #endregion

        #region プライベートメソッド
        /// <summary>
        /// キャラクターコンボボックスに値を設定
        /// </summary>
        private void SetCharacterListCombobox()
        {
            Dictionary<string, string> charDict = new Dictionary<string, string>();
            if(CharacterParamAccessor.Characters.character != null)
            {
                foreach (Objects.Character chara in CharacterParamAccessor.Characters.character)
                {
                    if (chara.char_id != "") charDict.Add(chara.char_id, chara.char_name);
                }
            }
            
            charDict.Add("new", "(新規追加)");
            characterListComboBox.DataSource = charDict.ToArray();
            characterListComboBox.DisplayMember = "value";
            characterListComboBox.ValueMember = "key";
            if (charDict.Keys.ToArray()[0] != "new")
            {
                characterIdTextBox.Text = charDict.Keys.ToArray()[0];
                characterNameTextBox.Text = charDict[characterIdTextBox.Text];
                characterIdTextBox.Enabled = false;
                SetImageListView(characterIdTextBox.Text);
            }
            else
            {
                SetImageListView("");
            }
        }

        private void SetImageListView(string charId)
        {
            //初期化
            imageNameTextBox.Clear();
            imageListView.Items.Clear();
            //取得
            CharacterImage[] images = null;
            if(CharacterParamAccessor.Characters.character != null)
            {
                foreach (Character chara in CharacterParamAccessor.Characters.character)
                {
                    if (chara.char_id == charId)
                    {
                        images = (CharacterImage[])chara.char_image.ToArray(typeof(CharacterImage));
                        break;
                    }
                }
            }
            
            //リスト初期化
            imageList.Images.Clear();
            imageId.Clear();
            int count = 0;
            ListViewItem lvi = null;
            if (images != null)
            {
                foreach(CharacterImage charImage in images)
                {
                    Image img = Image.FromFile(Path.Combine(DirectoryAccessor.ImageDir,charImage.image_id+".png"));
                    imageList.Images.Add(GetIconImage(img));
                    imageId.Add(charImage.image_id);
                    lvi = new ListViewItem(charImage.image_name);
                    lvi.ImageIndex = count;
                    imageListView.Items.Add(lvi);
                    count++;
                }
            }
            imageList.Images.Add(Properties.Resources._new);
            imageId.Add("new");
            lvi = new ListViewItem("(新規追加)");
            lvi.ImageIndex = count;
            imageListView.Items.Add(lvi);

            imageListView.Refresh();
            pictureBox.Visible = false;
        }

        /// <summary>
        /// データURLからImage型に変換
        /// 画像は必ずアルファ付き（png）
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private Image ConvertDataURL2Image(string data)
        {
            string header = "data:image/png;base64,";
            string base64 = data.Replace(header, "");
            byte[] bytes = Convert.FromBase64String(base64);
            Image result;
            using(MemoryStream memStream = new MemoryStream(bytes))
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                result = (Image)binFormatter.Deserialize(memStream);
            }
            return result;
        }



        /// <summary>
        /// 正方形の画像を返す
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private Image GetIconImage(Image image)
        {
            int w = image.Width;
            int h = image.Height;
            Image result = (Image)image.Clone();
            if (w > h)
            {
                //正方形に整形
                Rectangle rect = new Rectangle((w-h)/2, 0, h, h);
                result = ((Bitmap)image).Clone(rect, image.PixelFormat);
            }
            else if (h > w)
            {
                //正方形に整形
                Rectangle rect = new Rectangle(0, 0, w, w);
                result = ((Bitmap)image).Clone(rect, image.PixelFormat);
            }
            return result;
        }

        private Image ResizeImage(Image image, int height)
        {
            double scale = (double)height / (double)image.Height;
            int width = (int)(image.Width * scale);

            Bitmap result = new Bitmap(width, height);
            using(Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return result;
        }


        #endregion

        
    }
}
