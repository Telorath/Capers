using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capers
{
    public enum Tag
    {

    }
    public abstract class Entity
    {
        string mName;
//        Dictionary<Tag,bool> Tags;
       public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public override string ToString()
        {
            return mName;
        }
    }
}
