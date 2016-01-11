using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mlib;
namespace MP3_Player
{
    public static class MusicListFile
    {
        public static List<MusicList> readFile(string path)
        {
            List<MusicList> lists = new List<MusicList>();
            
            MFile m = new MFile(path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            List<string> readData = new List<string>();
            while (!m.eof)
                readData.Add(m.ReadLine());
            foreach (string str in readData)
            {
                if (str[0] == '<' && str[str.Length - 1] == '>')
                    lists.Add(new MusicList(str.Substring(1,str.Length - 2)));
                else if(str.Length != 0)
                    lists[lists.Count - 1].addMusic(str.Replace("\t",""));
            }
            m.Close();
            return lists;
        }

    }
}
