using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI
{
    class LaunchScan
    {
        public static string[] scan()
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Substring(Directory.GetCurrentDirectory().Length + 1);
            }
            return files;
        }
        public static string[] extension()
        {
            ArrayList extensionList = new ArrayList();
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetExtension(files[i]);
                if (files[i] == ".exe" || files[i] == ".exe.config" || files[i] == ".pdb" || files[i] == ".config") { }
                else if (!extensionList.Contains(files[i]))
                {
                    extensionList.Add(files[i]);
                }
            }
            string[] extensionArray = (string[])extensionList.ToArray(typeof(string));
            return extensionArray;
        }
    }
}
