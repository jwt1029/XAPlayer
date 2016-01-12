using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_Player
{
    public class Fmanage
    {
        public FileInfo info;
        public int no;
        public int minutes;
        public int seconds;
        public Fmanage(FileInfo info, int no, int minutes, int seconds)
        {
            this.info = info;
            this.no = no;
            this.minutes = minutes;
            this.seconds = seconds;
        }
    }
}
