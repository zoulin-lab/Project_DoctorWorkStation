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
            this.StartPosition = FormStartPosition.CenterScreen; //本窗体启动位置设为屏幕中央；
            
        }
        public void OpenWord(string fileName)//病历模板打开word方法
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

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        //private void SaveWord(string fileName)

        //{

        //    MSWord.Application app = new MSWord.Application();

        //    MSWord.Document doc = null;

        //    object missing = System.Reflection.Missing.Value;

        //    object File = fileName;

        //    object readOnly = false;

        //    object isVisible = true;

        //    try

        //    {

        //        doc = app.Documents.Open(ref File, ref missing, ref readOnly,

        //         ref missing, ref missing, ref missing, ref missing, ref missing,

        //         ref missing, ref missing, ref missing, ref isVisible, ref missing,

        //         ref missing, ref missing, ref missing);

        //        doc.ActiveWindow.Selection.WholeStory();//全选

        //        rtbTamplate.SelectAll();

        //        Clipboard.SetData(DataFormats.Rtf, rtbTamplate.SelectedRtf);//复制RTF数据到剪贴板

        //        doc.ActiveWindow.Selection.Paste();

        //        //doc.Paragraphs.Last.Range.Text = richTextBox1.Text;//word文档赋值数据，不带格式

        //        doc.Save();

        //    }

        //    finally

        //    {

        //        if (doc != null)

        //        {

        //            doc.Close(ref missing, ref missing, ref missing);

        //            doc = null;

        //        }



        //        if (app != null)

        //        {

        //            app.Quit(ref missing, ref missing, ref missing);

        //            app = null;

        //        }

        //    }

        //}





    }
}

