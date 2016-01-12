using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    [Serializable]
    public class Database
    {
        [NonSerialized]
        static Database ActiveDatabase;
        Dictionary<string,Character> Characters;
        public static Database GetActiveDatabase()
        {
            if (ActiveDatabase == null)
            {
                ActiveDatabase = new Database();
                ActiveDatabase.Characters = new Dictionary<string, Character>();
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
            if (Characters.ContainsKey(name))
            {
                return Characters[name];
            }
            else return null;
        }
        public void AddCharacter(Character C)
        {
            Characters.Add(C.Name, C);
        }
        public void ReadCharacters()
        {
            foreach (KeyValuePair<string,Character> KVP in Characters)
            {
                KVP.Value.FullDisplay();
            }
        }
    }
}