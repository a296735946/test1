
using Java.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace SDcard
{
    public partial class Page1 : ContentPage
    {

        public Page1()
        {
            InitializeComponent();


        }

        public void SetLabel(string foo)
        {
            txt1.Text = foo;
        }


        public void FindSDcard(string path)
        {
            try
            {
                var bat = DependencyService.Get<ExternalStorage>();

                txt2.Text = bat.writetosdcard(path).ToString();




                //Java.IO.File dir = new Java.IO.File("/storage/");
                //string ss = getSdcard(dir);

                //Java.IO.File dir2 = new Java.IO.File(ss);

                //Java.IO.File dir = new Java.IO.File(Filepath);

                ////dir2.(true);
                ////txt1.Text = dir2.Exists().ToString();
                ////txt2.Text = dir2.CanRead().ToString();

                //Java.IO.File[] ListFiles = dir.ListFiles();

                //for (int i = 0; i < ListFiles.Length; i++)
                //{
                //    txt2.Text = txt2.Text + (i + 1).ToString() + "." + ListFiles[i].Name + "\r\n";
                //}
            }
            catch (Exception ex)
            {
                txt2.Text = ex.ToString();
            }

            //try
            //{
            //    Java.IO.File sdCard = Android.OS.Environment.ExternalStorageDirectory;
            //    Java.IO.File dir = new Java.IO.File("/sdcard2/");

            //    Java.IO.File file = new Java.IO.File(Path.Combine(dir.Path, "testfile.xml"));
            //    try
            //    {
            //        if (!file.Exists())
            //            txt2.Text = file.CreateNewFile().ToString();
            //        else
            //            txt2.Text = "12345";
            //    }
            //    catch (Exception ex)
            //    {
            //        txt2.Text = ex.ToString();
            //    }


            //}
            //catch (Exception ex)
            //{
            //    txt2.Text = ex.ToString();
            //}
        }
       
    }
}
