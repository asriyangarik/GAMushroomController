using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyМushroomController
{
    public partial class Sections : ParentFormGLOBAL
    {
        MyController _myController;

        public Sections()
        {
            InitializeComponent();
        }

        public Sections(MyController myController)
        {
            InitializeComponent();
            _myController = myController;


            if (_myController.SectionsCount == -1 ) { return; }
            Sections1RB.Checked = _myController.SectionsCount == 1;
            Sections2RB.Checked = _myController.SectionsCount == 2;
            Sections3RB.Checked = _myController.SectionsCount == 3;
            Sections4RB.Checked = _myController.SectionsCount == 4;

        }

        private void Sections_FormClosed(object sender, FormClosedEventArgs e)
        {

            Task sectionsSet = new Task(() =>
            {
                if (Sections1RB.Checked)
                {
                    _myController.SectionsCount = 1;
                }
                else if (Sections2RB.Checked)
                {
                    _myController.SectionsCount = 2;
                }
                else if (Sections3RB.Checked)
                {
                    _myController.SectionsCount = 3;
                }
                else if (Sections4RB.Checked)
                {
                    _myController.SectionsCount = 4;
                }
            });
            sectionsSet.Start();
            sectionsSet.Wait();


            _myController.EnableSections();
          
        }
    }
}
