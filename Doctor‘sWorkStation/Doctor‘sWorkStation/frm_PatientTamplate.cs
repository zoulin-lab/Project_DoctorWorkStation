using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office;
using MSWord = Microsoft.Office.Interop.Word;

namespace Doctor_sWorkStation
{
    public partial class frm_PatientTamplate : Form
    {
        public frm_PatientTamplate()
        {
            InitializeComponent();
            OpenWord("病历模板一");
        }
        public void OpenWord(string fileName)//患者病历信息详情打开word方法
        {
            MSWord.Application app = new MSWord.Application();
            MSWord.Document doc = null;
            object missing = System.Reflection.Missing.Value;
            object File = fileName;
            object readOnly = false;
            object isVisible = true;
            object unknow = Type.Missing;
            try
            {
                doc = app.Documents.Open(ref File, ref missing, ref readOnly, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing,
                    ref missing, ref missing, ref missing);
                doc.ActiveWindow.Selection.WholeStory();
                doc.ActiveWindow.Selection.Copy();
                rtbTamplate.Paste();
            }
            finally
            {
                if (doc != null)
                {
                    doc.Close(ref missing, ref missing, ref missing);
                    doc = null;
                }

                if (app != null)
                {
                    app.Quit(ref missing, ref missing, ref missing);
                    app = null;
                }
            }
        }
    }
}
