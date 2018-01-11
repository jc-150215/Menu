using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menu.sqlite;

namespace Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList;
            itemList = await itemDataBase.GetItemsAsync();

            if (itemList.Count < 1)
            {
                await storeInitialData(itemDataBase);
                itemList = await itemDataBase.GetItemsAsync();
            }

            // ListViewを生成する
            listView.ItemsSource = itemList;
        }

        private static async Task storeInitialData(TrainingDatabase itemDataBase)
        {
            Training pushup = new Training() { Menu = "アブドミナルマシンクランチ（マシン）", Load = "負荷度:☆☆", parts = "腹" };
            await itemDataBase.InsertItemAsync(pushup);
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ウェィテッドクランチ（プレート）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "サイドレイズ　　　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆", parts = "肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "サイドバイク（ダンベル）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルクランチ（ダンベル）　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ハンギングレッグレイズ（マシン）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "バーティカルベンチレッグレイズ（バーベル）　　　　　　", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "プルアップニーレイズ（マシン）　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ボールクランチ（ボール）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ボールバイク（ボール）　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "メディシンボールロシアンツイスト（ボール）　　　　　　", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "TRX　ニータック（ボール）　　　　　　　　　　　　　　 ", Load = "負荷度:☆☆", parts = "腹" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "アームカール（マシン）　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "インクラインダンベルカール（ダンベル）　　　　　　　　", Load = "負荷度:☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "インクランダンベルフライ（ダンベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ケーブルプレス（マシン）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "コンセントレーションカール（ダンベル）　　　　　　　　", Load = "負荷度:☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルベンチブレス（ダンベル）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "トライセプスキックバック　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ナロウベンチブレス（バーベル）　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "プリーチャーカール　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "腕" }); 
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ライイング　トライセプス　エクステンション（バーベル）", Load = "負荷度:☆☆", parts = "腕" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "懸垂（マシン）　　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "シーテッドローイング　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "スペインヒップリフト　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルアップライトロー（ダンベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルロウ　　　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "デッドリフト　　　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ベントオーバーロウ　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ベントバックエクステンション　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ラットブルダウン　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ワンハンドローイング（ダンベル）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "背中" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "アーノルドブレス（ダンベル）　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "インクラインベンチプレス（バーベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ケーブルクロスオーバー（マシン）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルアップライトロウ（ダンベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルフライ（ダンベル）　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "チェストブレス（マシン）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ディップス（自重）　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ブルオーバー　　　　　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });            
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ペッグデックフライ（マシン）　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ベンチプレス（バーベル）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "胸肩" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "カーフレイズ（自重）　　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ダンベルスクワット（ダンベル）　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ハックスクワット（マシン）　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ハックリフト（バーベル）　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "バーベルスクワット（バーベル）　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "バーベルランジ（バーベル）　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "ルーマニアンデッドリフト（バーベル）　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "レッグエクステンション（マシン）　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "レッグカール（マシン）　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
            await itemDataBase.InsertItemAsync(new Training() { Menu = "レッグプレス（マシン）　　　　　　　　　　　　　　　　", Load = "負荷度:☆☆", parts = "脚" });
        }

        //SearchBarを押した時のイベントハンドラ
        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("", Select.Text, "OK");

            /*if (0<=Select.Text.IndexOf(array1))
            {   
            }
            else
            {
                this.listView.ItemsSource = "データがありません";
            }*/

        }

        private async void 全部_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsync();
            listView.ItemsSource = itemList;

        }

        private async void 腹_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("腹");

            listView.ItemsSource = itemList;
        }

        private async void 腕_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("腕");

            listView.ItemsSource = itemList;

        }

        private async void 背中_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("背中");
            listView.ItemsSource = itemList;
        }

        private async void 胸肩_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("胸肩");
            listView.ItemsSource = itemList;
        }


        private async void 脚_Clicked(object sender, EventArgs e)
        {
            TrainingDatabase itemDataBase = TrainingDatabase.getDatabase();
            List<Training> itemList = await itemDataBase.GetItemsAsyncByParts("脚");
            listView.ItemsSource = itemList;
        }



        private void Sort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //int s = Sort.SelectedIndex;
            String si = (String)Sort.SelectedItem;
            //if (si==0)
            if (si.Equals("五十音順"))
            {
                // 配列に値を入れる
                int[] array1 = new int[] { 5, 4, 3, 2, 1 };

                // ListViewを生成する
                listView.ItemsSource = array1;
            }
            else
            {
                // 配列に値を入れる
                int[] array1 = new int[] { 5, 4, 3, 2, 1 };

                // ListViewを生成する
                listView.ItemsSource = array1;
            }
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            // DisplayAlert("", , "OK");

            Training training = (Training)listView.SelectedItem;
            String l = training.Menu;

            Navigation.PushAsync(new MenudetaliPage(l));
        }
    }
}