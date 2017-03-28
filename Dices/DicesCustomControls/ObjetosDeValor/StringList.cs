using System;
using System.Collections;

namespace DicesCustomControls.ObjetosDeValor
{
    public class StringList
    {
        ArrayList m_alMain;

        public StringList()
        {
            m_alMain = new ArrayList();
        }

        ~StringList()
        {
            m_alMain.Clear();
        }

        public int Add(string s)
        {
            m_alMain.Add(s);

            return m_alMain.Count;
        }

        public StringList AddRange(StringList sl)
        {
            m_alMain.AddRange(sl.m_alMain);

            return null;
        }

        public int AddNoDuplicate(string s)
        {
            if (m_alMain.IndexOf(s) == -1)
                m_alMain.Add(s);

            return m_alMain.Count;
        }

        public int Insert(int index, string s)
        {
            m_alMain.Insert(index, s);

            return m_alMain.Count;
        }

        public int Remove(String s)
        {
            m_alMain.Remove(s);

            return m_alMain.Count;
        }

        public int Replace(string sFind, string sReplace)
        {
            int index = m_alMain.IndexOf(sFind);

            if (index > -1)
            {
                m_alMain.RemoveAt(index);
                m_alMain.Insert(index, sReplace);
            }

            return m_alMain.Count;
        }

        public void Clear()
        {
            m_alMain.Clear();
        }

        public String this[int index]
        {
            get
            {
                return (string)m_alMain[index];
            }
            set
            {
                if (index >= m_alMain.Count)
                    m_alMain.Add(value);
                else
                    m_alMain[index] = value;
            }
        }

        public override string ToString()
        {
            string sRHS = "";
            int index = 0;

            while (index < m_alMain.Count)
            {
                sRHS += (string)m_alMain[index++] + "\n";
            }

            return sRHS;
        }

        public String ToString(string sSeperator)
        {
            string sRHS = "";
            int index = 0;

            while (index < m_alMain.Count)
            {
                sRHS += (string)m_alMain[index++];
                if (index < m_alMain.Count)
                    sRHS += sSeperator;
            }

            return sRHS;
        }

        public void Sort()
        {
            m_alMain.Sort();
        }

        public int Count
        {
            get
            {
                return m_alMain.Count;
            }
        }

        public int IndexOf(string sFind)
        {
            return m_alMain.IndexOf(sFind);
        }

        public static implicit operator string[] (StringList sl)
        {
            string[] sLHS = new string[sl.m_alMain.Count];
            int index = 0;

            while (index < sl.m_alMain.Count)
            {
                sLHS[index] = (string)sl.m_alMain[index];
                index++;
            }

            return sLHS;
        }

        public static implicit operator StringList(string[] sa)
        {
            StringList sl = new StringList();

            for (int index = 0; index < sa.Length; index++)
            {
                sl.Add(sa[index]);
            }

            return sl;
        }

        public static implicit operator StringList(object[] sa)
        {
            StringList sl = new StringList();

            for (int index = 0; index < sa.Length; index++)
            {
                sl.Add(sa[index].ToString());
            }

            return sl;
        }
    }
}
