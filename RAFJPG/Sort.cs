using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSI
{
    class Sort
    {
        public static string[] byExtension(string extension)
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());
            ArrayList arrayExtension = new ArrayList();

            foreach (string item in files)
            {
                if (item.EndsWith(extension))
                {
                    arrayExtension.Add(item);
                }
            }

            string[] extensionArray = (string[])arrayExtension.ToArray(typeof(string));
            return extensionArray;
        }

        private static string[] copy(string[] array)
        {
            string[] copyArray = new string[array.Length];

            for (int i = 0; i < copyArray.Length; i++)
            {
                copyArray[i] = array[i];
            }
            return copyArray;
        }

        public static string[] byName(string extension1, string extension2)
        {
            string[] array1 = copy(byExtension(extension1));
            string[] array2 = copy(byExtension(extension2));
            ArrayList singleFiles = new ArrayList();

            for (int i = 0; i < array1.Length; i++)
            {
                int extensionLength = Path.GetExtension(array1[i]).Length;
                array1[i] = array1[i].Remove(array1[i].Length - extensionLength);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                int extensionLength = Path.GetExtension(array2[i]).Length;
                array2[i] = array2[i].Remove(array2[i].Length - extensionLength);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                if (!array1.Contains(array2[i]))
                {
                    singleFiles.Add(array2[i]);
                }
            }
            string[] finalArray = (string[])singleFiles.ToArray(typeof(string));

            return finalArray;
        }

        public static void deleteFile(string[] files, string extension2)
        {
            string[] array = copy(files);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] + extension2;
                File.Delete(array[i]);
            }
        }
    }
}
