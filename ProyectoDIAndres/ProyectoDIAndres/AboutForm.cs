using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoDIAndres
{
    public partial class AboutForm : Form
    {
        public AboutForm(string language)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            InitializeComponent();
        }
    }
}
