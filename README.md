# Discss[ディスカス]
ストリーミングソフトウェアのブラウザパーツ内に記載するURLとカスタムCSSを出力するアプリケーションです。  
[Discord Streamkit Overlay][1]の利用が前提となります。  
※超開発中なのでバグが沢山あります。修正、使い方の更新などは順次やります。  

## インストール方法
Releaseから最新版をダウンロードし、インストーラを実行してください。

## 画面の説明
### サーバー設定画面
![サーバー設定画面](https://user-images.githubusercontent.com/77207872/169364861-a9845e7e-8546-4578-b6f7-c6e47cdd5851.PNG)
`サーバー設定`ボタンをクリックすると、サーバー設定画面が開かれます。  
サーバー設定画面では、DiscordのサーバーのIDと名称、サーバー内のボイスチャットチャンネルのIDと名称を登録、削除できます。   
以下、機能ごとの説明を記載します。   

--- 
#### サーバーの登録
1. `サーバー`項目を`(新規追加)`に設定
1. `サーバーID`にDiscordから取得したサーバーのIDを貼り付け　　  
→IDの取得方法は[こちら](#idの取得方法)
1. `サーバー名`を入力(自由入力)
1. `登録`ボタンをクリック

---
#### サーバーの削除
1. `サーバー`項目を削除したいサーバーに設定
1. `ボイスチャンネル`項目を**空白**に設定
1. `削除`ボタンをクリック

---
#### チャンネルの登録
1. `ボイスチャンネル`項目を`(新規追加)`に設定
1. `チャンネルID`にDiscordから取得したチャンネルのIDを貼り付け　　  
→IDの取得方法は[こちら](#idの取得方法)
1. `チャンネル名`を入力(自由入力)
1. `登録`ボタンをクリック

---
#### チャンネルの削除
1. `ボイスチャンネル`項目を削除したいチャンネルに設定
1. `削除`ボタンをクリック

---
- サーバーの新規追加とチャンネルの新規追加は同時に行うことができます。
- サーバーが削除されると、サーバーに追加されているチャンネルも全て削除されます。

### キャラ設定画面
![キャラ設定画面](https://user-images.githubusercontent.com/77207872/169365000-b842cc35-3c95-416a-b8f8-e27babf0f4a0.PNG)
`キャラ設定`ボタンをクリックすると、キャラ設定画面が開かれます。  
キャラ設定画面では、ボイスチャット参加者のIDと名称、立ち絵画像とその名称を登録、削除できます。   
以下、機能ごとの説明を記載します。   

--- 
#### キャラクターの登録
1. `キャラクター`項目を`(新規追加)`に設定
1. `キャラクターID`にDiscordから取得したユーザーのIDを貼り付け　　  
→IDの取得方法は[こちら](#idの取得方法)
1. `キャラクター名`を入力(自由入力)
1. `登録`ボタンをクリック

--- 
#### キャラクターの削除
1. `キャラクター`項目を削除したいキャラクターに設定
1. `画像一覧`項目の選択を解除（画像が何も選ばれていない状態にする）
1. `削除`ボタンをクリック

--- 
#### 立ち絵画像のデフォルトの変更
1. `キャラクター`項目を参照したいキャラクターに設定
1. `画像一覧`項目から、配信画面で表示したい画像を選択
1. `デフォルトにする`ボタンをクリック    
→クリックできない状態になっているときは既にデフォルトに設定済みです

--- 
#### 立ち絵画像の登録
1. `画像一覧`項目から`(新規追加)`を選択
1. `画像を参照`ボタンをクリックして画像を選択(PNG画像のみ)
1. `画像名`を変更(任意)
1. `登録`ボタンをクリック

※登録する前に`画像一覧`の選択を変更すると保存が行われません

--- 
#### 立ち絵画像の削除
1. `画像一覧`項目から、削除したい画像を選択
1. `削除`ボタンをクリック

--- 
- キャラクターの新規追加と立ち絵画像の新規追加は同時に行うことができます。
- キャラクターが削除されると、キャラクターに追加されている立ち絵画像も全て削除されます。

### 出力設定画面
![出力設定画面](https://user-images.githubusercontent.com/77207872/169365083-799a4376-b4eb-4880-8039-fbec35a0cdb2.PNG)
`出力設定`ボタンをクリックすると、出力設定画面が開かれます。  
出力設定画面では、カスタムCSSを出力するための設定と、配信用ソフトウェアのブラウザパーツに貼り付けるためのURL、カスタムCSSを出力できます。   
※出力するためにはサーバー、チャンネル、キャラクター全てが1つ以上登録されている必要があります。    
以下、出力の手順を順番に記載します。

---
1. `サーバー`項目を選択
1. `チャンネル`項目を選択
1. `キャラ一覧`項目で、表示させたい参加者のチェックボックスをＯＮにする    
→チェックボックスがついていない参加者は表示されません
1. `出力`ボタンをクリックする

---
出力が完了すると、`URL`項目と`カスタムＣＳＳ`項目に文字が出力されます。    
項目横の`クリップボードに貼り付け`ボタンをクリックすると、それぞれの項目の内容をコピーできます。

## 操作方法
### Discordの設定
画面項目を入力するためにはDiscordを開発者モードに変更し、IDを取得できるようにする必要があります。
#### 開発者モードの設定方法
1. Discordアプリの左下にある歯車マークをクリックして`ユーザー設定`を開きます
![歯車](https://user-images.githubusercontent.com/77207872/169365142-ab70970e-8866-4d53-9bf7-68443e9ad9e2.PNG)

1. `ユーザー設定`画面左側にある項目から`詳細設定`画面を開きます。
1. `開発者モード`をONにします
![詳細設定](https://user-images.githubusercontent.com/77207872/169365198-6be92b66-1aea-4a00-bd16-f326b6e69cea.PNG)
↑この状態になればOK！

1. Discordアプリを再起動します

---
#### IDの取得方法
Discordアプリを開発者モードにすると、サーバー・チャンネル・ユーザーのアイコンを右クリックした際にメニューストリップの一番下に`IDをコピー`が表示されるようになります    
![メニューストリップ](https://user-images.githubusercontent.com/77207872/169365253-c3eb0eb8-d8a7-4a56-8da7-a4dfe3a6fc02.PNG)

`IDをコピー`をクリックすると、貼り付けができる状態になります。    
※ユーザーのIDを取得する際は必ず***サーバー内のユーザーのアイコン***から取得してください。

### 開始方法
1. Discssの`出力設定画面`で出力の設定を行い、URLとカスタムCSSを出力します
1. 配信ソフトウェアのブラウザパーツのURL、カスタムCSSに出力したURLとカスタムCSSをコピーします
1. Discssの`Discord Streamkit Overlay`ボタンをクリックしてDiscord Streamkit Overlayをブラウザで開きます
1. Discord Streamkit Overlayの画面下にある`Install for ***`ボタンをクリックします    
※OBSを使用している場合は`Install for OBS`、XSplitを使用している場合は`Install for XSplit`をクリック
1. Discssの`画像公開開始`ボタンをクリックします

# あいさつ
Hello World!
YouTubeで活動しているバーチャル作業ライバーのNull Aliasです。
Twitterのフォロー、チャンネルのサブスクライブよろしくね！

- [Youtubeチャンネル](https://www.youtube.com/channel/UCY3-zWConDmu7s_esQ_2Dyw)
- [Twitter](https://twitter.com/null_alias)

[1]:https://streamkit.discord.com/overlay