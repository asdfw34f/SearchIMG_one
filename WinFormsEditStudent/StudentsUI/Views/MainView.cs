using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsUI.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();

            this.CenterToScreen();
            this.Text = "Пример работы с привязками";
        }
    }
}
