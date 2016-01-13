using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Capers;

namespace Capers
{
    [Serializable]
    public class Database
    {
        [NonSerialized]
        static Database ActiveDatabase;
        List<Character> Characters;
        public static Database GetActiveDatabase()
        {
            if (ActiveDatabase == null)
            {
                ActiveDatabase = new Database();
                ActiveDatabase.Characters = new List<Character>();
            }
            return ActiveDatabase;
        }
        public static void LoadDatabase()
        {
            string path = "C:\\Users\\Telorath\\Heroes";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = path + "\\Database.txt";
            IFormatter formatter = new BinaryFormatter();
            FileStream _stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            ActiveDatabase = (Database)formatter.Deserialize(_stream);
            _stream.Close();
        }
        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            string path = "C:\\Users\\Telorath\\Heroes";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = path + "\\Database.txt";
            FileStream _stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(_stream, this);
            _stream.Close();
        }
        public Character FindCharacter(string name)
        {
            for (int i = 0; i < Characters.Count; i++)
            {
                if (string.Compare(name, Characters[i].Name) == 0)
                {
                    return Characters[i];
                }
            }
            return null;
        }
        public void AddCharacter(Character C)
        {
            Characters.Add(C);
        }
        public void RemoveCharacter(Character c)
        {
            Characters.Remove(c);
        }
        public void ReadCharacters()
        {
            foreach (Character C in Characters)
            {
                C.FullDisplay();
            }
        }
        public List<Character> CharList()
        {
            return Characters;
        }
    }
}