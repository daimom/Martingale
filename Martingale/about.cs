using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martingale
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            string aboutProgram;
            aboutProgram = string.Format(@"開源網址：{0}\r\n有發現bug請到此留言。", "https://github.com/daimom/Martingale");
            txtAbout.Text = aboutProgram;
        }
    }
}
