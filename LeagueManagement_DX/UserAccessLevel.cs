using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManagement_DX
{
    public sealed class UserAccessLevel
    {
        private static UserAccessLevel instance = null;
        private static readonly object padlock = new object();
        private static int AccessLevel;
        public static UserAccessLevel Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new UserAccessLevel();
                    }
                    return instance;
                }
            }
        }

        public int SetAccessLevel
        {
            set { AccessLevel = value; }
        }
        public int GetAccessLevel
        {
            get { return AccessLevel; }
        }
    }
}
