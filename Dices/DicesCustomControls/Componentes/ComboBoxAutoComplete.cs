using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DicesCustomControls.ObjetosDeValor;

namespace DicesCustomControls.Componentes
{
    public class ComboBoxAutoComplete : ComboBox
    {
        #region Propriedades Design

        [Category("Objetiva")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate(); // causes control to be redrawn
            }
        }

        [Category("Objetiva")]
        public ButtonBorderStyle BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }

        [Category("Objetiva")]
        public bool TrocaEnterPorTab { get; set; } = true;

        #endregion

        #region Propriedades

        private Color _borderColor = Color.Black;
        private ButtonBorderStyle _borderStyle = ButtonBorderStyle.Solid;
        private static int WM_PAINT = 0x000F;

        private StringList m_slSuggestions = new StringList();
        private Keys m_kcLastKey = Keys.Space;
        private int[] m_iaColWidths = new int[1];
        public uint ColumnSpacing = 4;
        private CCBColumnCollection m_Cols = new CCBColumnCollection();

        private DataTable m_dtData = null;
        private DataView m_dvView = null;

        //private bool m_bShowHeadings = true; 
        private int m_iViewColumn = 0;
        private bool m_bInitItems = true;
        private bool m_bInitDisplay = true;
        private bool m_bInitSuggestionList = true;

        private bool m_bTextChangedInternal = false;
        public bool DropDownOnSuggestion = true;
        public bool Suggest = true;
        private int m_iSelectedIndex = -1;

        private Container components = null;

        #endregion

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg != WM_PAINT) return;

            var g = Graphics.FromHwnd(Handle);
            var bounds = new Rectangle(0, 0, Width, Height);

            ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
        }

        public ComboBoxAutoComplete()
        {
            if (components == null)
                components = null;

            Data = new DataTable(); //Make sure the DataTable is not blank
            Init();
        }

        public ComboBoxAutoComplete(DataTable dtData)
        {
            Data = dtData;
            Init();
        }

        private void Init()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
        }

        #endregion

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (TrocaEnterPorTab)
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                {
                    SendKeys.Send("{TAB}");
                    return;
                }

            try
            {
                if (m_bInitSuggestionList)
                    InitSuggestionList();
                base.OnKeyDown(e);
                m_kcLastKey = e.KeyCode;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nEm ColumnComboBox.OnKeyDown(KeyEventArgs).");
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            try
            {
                if (m_bTextChangedInternal)
                {
                    m_bTextChangedInternal = false;
                    return;
                }

                if (!Suggest)
                    return;

                var length = this.Text == null ? 0 : this.Text.Length;

                if (SelectionStart < length)
                    return;

                int iOffset = 0;

                if ((m_kcLastKey == Keys.Back) || (m_kcLastKey == Keys.Delete))
                {
                    UpdateIndex();
                    return;
                }

                if (m_slSuggestions == null || length < 1)
                    return;

                string sText;
                sText = this.Text ?? string.Empty;
                string sOriginal = sText;
                sText = sText.ToUpper();
                int iLength = sText.Length;
                string sFound = null;
                int index = 0;

                for (index = 0; index < m_slSuggestions.Count; index++)
                {
                    string sTemp = m_slSuggestions[index].ToUpper();
                    if (sTemp.Length >= sText.Length)
                    {
                        if (sTemp.IndexOf(sText, 0, sText.Length) > -1)
                        {
                            sFound = m_slSuggestions[index];
                            break;
                        }
                    }
                }

                if (sFound != null)
                {
                    m_bTextChangedInternal = true;
                    if (DropDownOnSuggestion && !DroppedDown)
                    {
                        m_bTextChangedInternal = true;
                        string sTempText = Text;
                        this.DroppedDown = true;
                        Text = sTempText;
                        m_bTextChangedInternal = false;
                    }
                    if (this.Text != sFound)
                    {
                        this.Text += sFound.Substring(iLength);
                        this.SelectionStart = iLength + iOffset;
                        this.SelectionLength = this.Text.Length - iLength + iOffset;
                        m_iSelectedIndex = index;
                        SelectedIndex = index;
                        base.OnSelectedIndexChanged(new EventArgs());
                    }
                    else
                    {
                        UpdateIndex();
                        this.SelectionStart = iLength;
                        this.SelectionLength = 0;
                    }
                }
                else
                {
                    m_bTextChangedInternal = true;
                    m_iSelectedIndex = -1;
                    SelectedIndex = -1;
                    Text = sOriginal;
                    m_bTextChangedInternal = false;
                    base.OnSelectedIndexChanged(new EventArgs());
                    this.SelectionStart = sOriginal.Length;
                    this.SelectionLength = 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nEm ColumnComboBox.OnTextChanged(EventArgs).");
            }
        }

        protected override void OnDropDown(EventArgs e)
        {
            try
            {
                //Initialize as required.
                if (m_bInitItems)
                    InitItems();

                if (m_bInitDisplay)
                    InitDisplay();

                base.OnDropDown(e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nEm ColumnComboBox.OnDropDown(EventArgs).");
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            try
            {
                m_iSelectedIndex = base.SelectedIndex;
                base.OnSelectedIndexChanged(e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nEm ColumnComboBox.OnSelectedIndexChanged(EventArgs).");
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            try
            {
                int iIndex = e.Index;

                if (iIndex > -1)
                {
                    int iXPos = 0;
                    int iYPos = 0;

                    DataRow dr = m_dvView[iIndex].Row;
                    e.DrawBackground();
                    for (int index = 0; index < m_Cols.Count; index++)
                    {
                        if (m_Cols[index].Display == false)
                            continue;
                        e.Graphics.DrawString(dr[index].ToString(), Font, new SolidBrush(e.ForeColor), new RectangleF(iXPos, e.Bounds.Y, m_Cols[index].CalculatedWidth, ItemHeight));
                        iXPos += m_Cols[index].CalculatedWidth - 4;
                    }
                    iXPos = 0;
                    iYPos += ItemHeight;
                    e.DrawFocusRectangle();
                    base.OnDrawItem(e);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nEm ColumnComboBox.OnDrawItem(DrawItemEventArgs).");
            }
        }

        private void InitItems()
        {
            try
            {
                m_Cols.Clear();

                foreach (DataColumn dc in m_dtData.Columns)
                {
                    m_Cols.Add(new CCBColumn(dc.Caption));
                }

                if (m_iViewColumn > m_Cols.Count - 1)
                    m_iViewColumn = m_Cols.Count - 1;
                if (m_iViewColumn < 0)
                    m_iViewColumn = 0;

                for (int index = 0; index < m_Cols.Count; index++)
                {
                    m_Cols[index].OnColumnDisplayChanged += new ChangeColumnDisplayHandler(ColumnComboBox_OnColumnDisplayChanged);
                }

                base.Items.Clear();

                foreach (DataRowView drv in m_dvView)
                {
                    string sTemp = drv[m_iViewColumn].ToString();
                    base.Items.Add(sTemp);
                }
                m_bInitItems = false;

                m_bInitDisplay = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nEm ColumnComboBox.InitItems().");
            }
        }

        private void InitDisplay()
        {
            try
            {
                int[] m_iaColWidths = new int[m_Cols.Count];
                SizeF size = new SizeF(10000, ItemHeight);
                Graphics g = CreateGraphics();
                m_iaColWidths = new int[m_Cols.Count];

                foreach (DataRowView drv in m_dvView)
                {
                    for (int index = 0; index < m_Cols.Count; index++)
                    {
                        string sTemp = drv[index].ToString();
                        int iTempWidth = (int)g.MeasureString(sTemp, Font, size).Width;
                        if (iTempWidth > m_iaColWidths[index])
                            m_iaColWidths[index] = iTempWidth;
                    }
                }

                DropDownWidth = 1;
                for (int index = 0; index < m_iaColWidths.Length; index++)
                {
                    if (m_Cols[index].Width < 0)
                        m_Cols[index].CalculatedWidth = m_iaColWidths[index] + (int)ColumnSpacing;
                    else
                        m_Cols[index].CalculatedWidth = m_Cols[index].Width + (int)ColumnSpacing;
                    int a = 0;
                    a++;
                    if (m_Cols[index].Display)
                        DropDownWidth += m_Cols[index].CalculatedWidth;
                }

                DropDownWidth += 16;
                m_bInitDisplay = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nEm ColumnComboBox.InitDisplay().");
            }
        }

        private void InitSuggestionList()
        {
            m_slSuggestions.Clear();

            foreach (DataRowView drv in m_dvView)
            {
                string sTemp = drv[m_iViewColumn].ToString();
                m_slSuggestions.Add(sTemp);
            }
        }

        public void UpdateIndex()
        {
            try
            {
                if (m_bInitItems)
                    InitItems();

                if (m_bInitSuggestionList)
                    InitSuggestionList();

                string sText = Text;
                int index = 0;
                for (index = 0; index < m_dvView.Count; index++)
                {
                    if (m_dvView[index][ViewColumn].ToString().ToLower() == sText.ToLower())
                    {
                        if (SelectedIndex != index)
                        {
                            m_bTextChangedInternal = true;
                            m_iSelectedIndex = index;
                            SelectedIndex = index;
                            base.OnSelectedIndexChanged(new EventArgs());
                            m_bTextChangedInternal = false;
                        }
                        break;
                    }
                }

                if (index >= m_dvView.Count)
                {
                    m_bTextChangedInternal = true;
                    m_iSelectedIndex = -1;
                    SelectedIndex = -1;
                    base.OnSelectedIndexChanged(new EventArgs());
                    m_bTextChangedInternal = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nEm ColumnComboBox.UpdateIndex().");
            }
        }

        public int GetIndexOf(string id)
        {
            try
            {
                var value = string.Empty;
                int index = 0;

                for (index = 0; index < Data.Rows.Count; index++)
                {
                    string sTemp = Data.Rows[index][0].ToString();
                    if (sTemp == id)
                    {
                        value = Data.Rows[index][ViewColumn].ToString();
                        break;
                    }
                }

                if (index >= Data.Rows.Count)
                {
                    value = string.Empty;
                    index = -1;
                }
                else
                {
                    if (this.Text != value && !string.IsNullOrEmpty(value))
                        try
                        {
                            Text = value;
                        }
                        catch
                        {
                            //Ignored
                        }
                }

                return index;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "\r\nEm ColumnComboBox.SetToIndexOf(string).");
            }
        }

        public override string Text
        {
            get
            {
                try
                {
                    return base.Text;
                }
                catch
                {
                    return string.Empty;
                }
            }
            set
            {
                if (base.Text != value && !string.IsNullOrEmpty(value))
                {
                    try
                    {
                        base.Text = value;
                    }
                    catch
                    {
                        base.Text = string.Empty;
                    }
                }
            }
        }

        public override int SelectedIndex
        {
            get
            {
                return m_iSelectedIndex;
            }
            set
            {
                m_iSelectedIndex = value;
                base.SelectedIndex = value;
                base.OnSelectedIndexChanged(new EventArgs());
            }
        }

        public DataTable Data
        {
            get
            {
                return m_dtData;
            }
            set
            {
                if (value == null)
                    throw new Exception("A propriedade \"Data\" não pode ser NULO.\r\n ColumnComboBox.Data (set)");
                m_dtData = value;
                m_dvView = new DataView(m_dtData);
                m_bInitItems = true;
                m_bInitSuggestionList = true;
                Invalidate();
            }
        }

        public new DataView Items
        {
            get
            {
                return m_dvView;
            }
        }

        public CCBColumnCollection Columns
        {
            get
            {
                if (m_bInitItems)
                    InitItems();
                if (m_bInitDisplay)
                    InitDisplay();
                return m_Cols;
            }
        }

        public void SortBy(string sCol, SortOrder so)
        {
            m_dvView.Sort = sCol + " " + so.ToString();
            m_bInitItems = true;
        }

        public int ViewColumn
        {
            get
            {
                return m_iViewColumn;
            }
            set
            {
                if (value < 0)
                    throw new Exception("ViewColumn precisa ser MAIOR que ZERO\r\n(set)ColumnComboBox.ViewColumn");
                m_iViewColumn = value;
                m_bInitItems = true;
                m_bInitDisplay = true;
                m_bInitSuggestionList = true;
            }
        }

        public new bool Sorted
        {
            get
            {
                return false;
            }
        }

        public object this[string sCol]
        {
            get
            {
                try
                {
                    if (m_iSelectedIndex < 0)
                        return null;
                    object o = Data.Rows[m_iSelectedIndex][sCol];
                    return o;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message + "\r\nEm ColumnComboBox[string](get).");
                }
            }
            set
            {
                try
                {
                    Data.Rows[SelectedIndex][sCol] = value;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message + "\r\nEm ColumnComboBox[string](set).");
                }
            }
        }

        private void ColumnComboBox_OnColumnDisplayChanged(object sender, CCBColumnEventArgs e)
        {
            m_bInitDisplay = true;
        }
    }

    #region Supporting classes and enum

    public enum SortOrder
    {
        DESC,
        ASC
    }

    public class CCBColumnEventArgs : EventArgs
    {
        public CCBColumn Column;

        public CCBColumnEventArgs(CCBColumn col)
        {
            Column = col;
        }
    }

    public delegate void ChangeColumnDisplayHandler(object sender, CCBColumnEventArgs e);

    public class CCBColumn
    {
        private string m_sName;
        //public object Value;
        public int Width = -1;
        private bool m_Display = true;
        public int CalculatedWidth = 0;

        public event ChangeColumnDisplayHandler OnColumnDisplayChanged;

        public CCBColumn(string sName)
        {
            m_sName = sName;
        }

        public CCBColumn(string sName, int iWidth)
        {
            m_sName = sName;
            Width = iWidth;
        }

        public CCBColumn(string sName, bool bDisplay)
        {
            m_sName = sName;
            Display = bDisplay;
        }

        #region Properties

        public string Name
        {
            get
            {
                return m_sName;
            }
            set
            {
                if (m_sName != value)
                {
                    m_sName = value;
                    if (OnColumnDisplayChanged != null)
                        OnColumnDisplayChanged(this, new CCBColumnEventArgs(this));
                }
            }
        }

        public bool Display
        {
            get
            {
                return m_Display;
            }
            set
            {
                if (m_Display != value)
                {
                    m_Display = value;
                    if (OnColumnDisplayChanged != null)
                        OnColumnDisplayChanged(this, new CCBColumnEventArgs(this));
                }
            }
        }

        #endregion
    }

    public class CCBColumnCollectionEventArgs : EventArgs
    {
        public int Count;
        public CCBColumn DO;

        public CCBColumnCollectionEventArgs(int count, CCBColumn dO)
        {
            Count = count;
            DO = dO;
        }
    }

    public delegate void AddCCBColumnHandler(object sender, CCBColumnCollectionEventArgs e);

    public delegate void RemoveCCBColumnHandler(object sender, CCBColumnCollectionEventArgs e);

    //CCBColumn collection is similar to an ArrayList but deals only with CCBColumns.
    //Sure would be nice to have class templates for classes like this one.
    public class CCBColumnCollection : IEnumerator, IEnumerable
    {
        CCBColumn[] m_DOA = new CCBColumn[16];
        int m_iSize = 16;
        int m_iCount = 0;
        int m_iEnumeratorPos;
        bool m_bFireEvents = true;
        public event AddCCBColumnHandler AddColumnEvent;
        public event RemoveCCBColumnHandler RemoveColumnEvent;

        public CCBColumnCollection()
        {
        }

        public void ItemAdded(object sender, CCBColumnCollectionEventArgs e)
        {
        }

        private void CheckGrow()
        {
            if (m_iCount >= m_iSize)
            {
                m_iSize *= 2;
                CCBColumn[] doTemp = new CCBColumn[m_iSize];
                m_DOA.CopyTo(doTemp, 0);
                m_DOA = doTemp;
            }
        }

        public void Add(CCBColumn DO)
        {
            if (Contains(DO))
                throw new Exception("Já existe uma coluna com o nome \"" + DO.Name + "\" na coleção...");
            CheckGrow();
            m_DOA[m_iCount] = DO;
            m_iCount++;
            if (AddColumnEvent != null && m_bFireEvents)
            {
                CCBColumnCollectionEventArgs args = new CCBColumnCollectionEventArgs(m_iCount, DO);
                AddColumnEvent(this, args);
            }
        }

        public bool Contains(CCBColumn DO)
        {
            for (int index = 0; index < Count; index++)
            {
                if (m_DOA[index].Name == DO.Name)
                    return true;
            }
            return false;
        }

        public bool AddNoDuplicate(CCBColumn DO)
        {
            bool bRHS = true;
            if (Contains(DO))
            {
                Remove(DO);
                bRHS = false;
            }
            Add(DO);
            return bRHS;
        }

        public void Insert(CCBColumn DO, int iPos)
        {
            CheckGrow();
            if (iPos < 0)
                Insert(DO, 0);
            if (iPos >= m_iCount && iPos != 0)
                Insert(DO, m_iCount - 1);
            CCBColumn[] doTemp = new CCBColumn[m_iSize];
            int index = 0;
            for (; index < iPos; index++)
            {
                doTemp[index] = m_DOA[index];
            }
            doTemp[index] = DO;
            for (; index < m_iCount; index++)
            {
                doTemp[index + 1] = m_DOA[index];
            }
            m_DOA = doTemp;
            m_iCount++;
        }

        public void Remove(CCBColumn DO)
        {

            int index = 0;
            for (; index < m_iCount; index++)
            {
                if (m_DOA[index].Name == DO.Name)
                    break;
            }
            if (index == m_iCount)
                return;
            for (; index < m_iCount - 1; index++)
            {
                m_DOA[index] = m_DOA[index + 1];
            }
            m_iCount--;
            Remove(DO);
            if (RemoveColumnEvent != null && m_bFireEvents)
            {
                CCBColumnCollectionEventArgs args = new CCBColumnCollectionEventArgs(m_iCount, DO);
                RemoveColumnEvent(this, args);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= m_iCount)
                return;
            for (; index < m_iCount - 1; index++)
            {
                m_DOA[index] = m_DOA[index + 1];
            }
            m_iCount--;
        }

        public void MoveToFront(CCBColumn DO)
        {
            m_bFireEvents = false;
            Remove(DO);
            Insert(DO, 0);
            m_bFireEvents = true;
        }

        public void Clear()
        {
            m_iSize = 16;
            m_iCount = 0;
            m_DOA = new CCBColumn[m_iSize];
        }

        #region Properties

        public int Count
        {
            get
            {
                return m_iCount;
            }
        }

        public CCBColumn this[int index]
        {
            get
            {
                return m_DOA[index];
            }
        }

        public CCBColumn this[string sName]
        {
            get
            {
                for (int index = 0; index < m_iCount; index++)
                {
                    if (m_DOA[index].Name == sName)
                        return m_DOA[index];
                }
                throw new Exception("Coluna \"" + sName + "\" não é uma COLUNA válida!");
            }
        }

        #endregion

        #region IEnumerator Members

        public IEnumerator GetEnumerator()
        {
            m_iEnumeratorPos = -1;
            return (IEnumerator)this;
        }

        public void Reset()
        {
            m_iEnumeratorPos = -1;
        }

        public object Current
        {
            get
            {
                return m_DOA[m_iEnumeratorPos];
            }
        }

        public bool MoveNext()
        {
            if (m_iEnumeratorPos >= m_iCount - 1)
                return false;
            else
            {
                m_iEnumeratorPos++;
                return true;
            }
        }

        #endregion
    }

    #endregion
}
