using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustashe_ic
{
    public partial class gamePlayForm : Form
    {
        public gamePlayForm()
        {
            InitializeComponent();
            gamePlay game = new gamePlay(this);
        }
    }
}
