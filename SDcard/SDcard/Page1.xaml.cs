
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
            //(Path.Combine(Android.OS.Environment.ExternalStorageDirectory.Path, "testfile.xml"), "12345");

            //Java.IO.File dir = new Java.IO.File(Path.Combine(Android.OS.Environment.ExternalStorageDirectory.Path, "testfile.xml"));
            //try
            //{
            //    if (!dir.Exists())
            //        txt2.Text = dir.CreateNewFile().ToString();
            //    else
            //        txt2.Text = "12345";
            //}
            //catch (Exception ex)
            //{
            //    txt2.Text = ex.ToString();
            //}

            //Java.IO.File sdCard = Android.OS.Environment.ExternalStorageDirectory;
            //Java.IO.File dir = new Java.IO.File(sdCard.AbsolutePath + "/" + path);
            //dir.Mkdirs();
            //Java.IO.File[] ListFiles = dir.ListFiles();
            //for (int i = 0; i < ListFiles.Length; i++)
            //{
            //    txt2.Text = txt2.Text + (i + 1).ToString() + "." + ListFiles[i].Name;
            //}

            try
            {
                Java.IO.File sdCard = Android.OS.Environment.ExternalStorageDirectory;
                Java.IO.File dir = new Java.IO.File("/sdcard2/");

                Java.IO.File file = new Java.IO.File(Path.Combine(dir.Path, "testfile.xml"));
                try
                {
                    if (!file.Exists())
                        txt2.Text = file.CreateNewFile().ToString();
                    else
                        txt2.Text = "12345";
                }
                catch (Exception ex)
                {
                    txt2.Text = ex.ToString();
                }


                //Java.IO.File[] ListFiles = dir.ListFiles();
                //for (int i = 0; i < ListFiles.Length; i++)
                //{
                //    txt2.Text = txt2.Text + (i + 1).ToString() + "." + ListFiles[i].Name + "/r/n";
                //}

            }
            catch (Exception ex)
            {
                txt2.Text = ex.ToString();
            }
        }
       
    }
}
