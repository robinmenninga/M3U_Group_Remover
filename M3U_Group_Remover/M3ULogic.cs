using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace M3U_Group_Remover
{
    class M3ULogic
    {
        static string fileName;
        static string[] m3ufile;
        static List<string> groups = new List<string>();

        public static List<string> Groups
        {
            get
            {
                return groups;
            }
        }

        public static void Save(string saveName)
        {
            File.WriteAllLines(saveName, m3ufile);
        }

        public static void Init(string filename)
        {
            fileName = filename;
            m3ufile = File.ReadAllLines(fileName);
            UpdateGroups();
        }

        public static void UpdateGroups()
        {
            groups.Clear();
            foreach (string line in m3ufile)
            {
                if (line.Contains("#EXTINF"))
                {
                    string groupName = GetGroupName(line);
                    if (!groups.Contains(groupName) && groupName != "")
                    {
                        groups.Add(groupName);
                    }
                }
            }
            groups.Sort();
        }

        public static string GetGroupName(string line)
        {
            string firstsubstring = line[(line.IndexOf("group-title=") + 13)..];
            return firstsubstring.Substring(0, firstsubstring.IndexOf("\""));
            //line.Substring()
        }

        public static void RemoveGroup(List<string> groupNames)
        {
            bool addnext = false;
            bool skipnext = false;
            List<string> linesToKeep = new List<string>();

            foreach (string line in m3ufile)
            {
                if (addnext)
                {
                    linesToKeep.Add(line);
                    addnext = false;
                    continue;
                }

                if (skipnext)
                {
                    skipnext = false;
                    continue;
                }

                if (line.Contains("#EXTINF"))
                {
                    if (!groupNames.Contains(GetGroupName(line)))
                    {
                        linesToKeep.Add(line);
                        addnext = true;
                    }
                    if (groupNames.Contains(GetGroupName(line)))
                    {
                        skipnext = true;
                    }
                }

                if (line.Contains("#EXTM3U"))
                {
                    linesToKeep.Add(line);
                }
            }

            m3ufile = linesToKeep.ToArray();
            UpdateGroups();
        }
    }
}
