using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_Player
{
    public class MusicList
    {
        public string name;
        public List<string> list = new List<string>();

        public MusicList(string name)
        {
            this.name = name;
        }
        public void addMusic(string path)
        {
            list.Add(path);
        }

        public void removeMusic(int index)
        {
            list.RemoveAt(index);
        }
    }
}
