using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessTheTune
{
    static class Quiz
    {
        static public List<string> allMusicList = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 10;
        static public bool randomStartMusic = false;
        static public string lastFolderPath = "";
        static public bool searchInSubfolders = false;
        static string regKeyName = "Software\\C-sharpGames\\Quiz";
        static public string songName = "";
        public static void ReadMusic()
        {
            try
            {
                string[] musicList = Directory.GetFiles(lastFolderPath, "*.mp3",
                    searchInSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                allMusicList.Clear();
                allMusicList.AddRange(musicList);
            }
            catch
            {
                
            }
        }
        public static void WriteParams()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("LastFolderPath", lastFolderPath);
                rk.SetValue("RandomStartMusic", randomStartMusic);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("SearchInSubfolders", searchInSubfolders);
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
        public static void ReadParams()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    lastFolderPath = (string)rk.GetValue("LastFolderPath");
                    randomStartMusic = Convert.ToBoolean(rk.GetValue("RandomStartMusic",false));
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    searchInSubfolders = Convert.ToBoolean(rk.GetValue("SearchInSubfolders", false));
                }
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }






    }
}
