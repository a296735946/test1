using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SDcard.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(DoInSDcard))]
namespace SDcard.Droid
{
    public class DoInSDcard : ExternalStorage
    {
        public DoInSDcard()
        {
        }

        public bool writetosdcard(string path)
        {
            Java.IO.File dir = new Java.IO.File("/storage/ext_sd/" + path);
            if (dir.Mkdirs().Equals(true))
                return true;
            else
                return false;
        }

        public string getSdcard(Java.IO.File dir)
        {
            Java.IO.File[] ListFiles = dir.ListFiles();
            string getpath = "";
            foreach (Java.IO.File dir2 in ListFiles)
            {
                Java.IO.File[] ListFiles2 = dir2.ListFiles();
                foreach (Java.IO.File dir3 in ListFiles2)
                {
                    if (dir3.Name.ToUpper() == "LOST.DIR")
                        return getpath = dir3.ParentFile.Path;
                }
            }
            return "";
        }
    }
}