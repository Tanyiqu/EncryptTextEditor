using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace EncryptTextEditor.Forms.Dialogs
{
    public partial class AddExtDialog : Form
    {
        public string name;
        public string desc;

        public AddExtDialog()
        {
            InitializeComponent();
        }

        //确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtExtName.Text.Equals("") || txtExtDesc.Text.Equals(""))
            {
                return;
            }
            //检查扩展名合法性
            name = txtExtName.Text.Trim();
            desc = txtExtDesc.Text.Trim();

            this.DialogResult = DialogResult.OK;
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
