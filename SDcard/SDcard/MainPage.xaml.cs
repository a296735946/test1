using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SDcard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnPage1.Clicked += BtnPage1_Clicked;
            btnPage2.Clicked += BtnPage1_Clicked;
            btnPage3.Clicked += BtnPage2_Clicked;
            btnPage4.Clicked += BtnPage2_Clicked;
            btnPage5.Clicked += BtnPage3_Clicked;
            btnPage6.Clicked += BtnPage3_Clicked;
            btnPage7.Clicked += BtnPage4_Clicked;
            btnPage8.Clicked += BtnPage4_Clicked;

        }

        private void BtnPage4_Clicked(object sender, EventArgs e)
        {
            //刪除
        }

        private void BtnPage3_Clicked(object sender, EventArgs e)
        {
            //搬移
        }

        private async void BtnPage1_Clicked(object sender, EventArgs e)
        {
            //查詢
            var foo = new Page1();
            Button btn = (Button)sender;
            if (btn.Text.Equals("查詢A資料夾"))
            {
                foo.SetLabel("A資料夾");
                foo.FindSDcard("A");
            }
            else
            {
                foo.SetLabel("B資料夾");
                foo.FindSDcard("B");
            }
            //Application.Current.MainPage = foo;
            
            await Navigation.PushAsync(foo);
        }


        private void BtnPage2_Clicked(object sender, EventArgs e)
        {
            //新增

        }
    }
}
