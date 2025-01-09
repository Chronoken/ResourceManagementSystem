using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResourceManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {

        private ResourceManager _resourceManager;

        private ListBox _resourceList;

        private TextBox _resourceNameBox;
        private TextBox _resourceLocationBox;
        private TextBox _userNameBox;

        private Button _addResourceButton;
        private Button _allocateButton;
        private Button _releaseButton;

        public MainForm()
        {
            _resourceManager = new ResourceManager();

            Text = "System Zarządzania Zasobami";
            Width = 600;
            Height = 400;

            _resourceList = new ListBox { Top = 10, Left = 10, Width = 560, Height = 200 };
            Controls.Add(_resourceList);

            var resourceNameLabel = new Label { Text = "Nazwa zasobu:", Top = 220, Left = 10, Width = 100 };
            Controls.Add(resourceNameLabel);

            _resourceNameBox = new TextBox { Top = 220, Left = 120, Width = 200 };
            Controls.Add(_resourceNameBox);

            var resourceLocationLabel = new Label { Text = "Lokalizacja zasobu:", Top = 250, Left = 10, Width = 100 };
            Controls.Add(resourceLocationLabel);

            _resourceLocationBox = new TextBox { Top = 250, Left = 120, Width = 200 };
            Controls.Add(_resourceLocationBox);

            var userNameLabel = new Label { Text = "Użytkownik:", Top = 280, Left = 10, Width = 100 };
            Controls.Add(userNameLabel);

            _userNameBox = new TextBox { Top = 280, Left = 120, Width = 200 };
            Controls.Add(_userNameBox);

            _addResourceButton = new Button { Text = "Dodaj zasób", Top = 310, Left = 10, Width = 100 };
            Controls.Add(_addResourceButton);

            _allocateButton = new Button { Text = "Przydziel", Top = 310, Left = 120, Width = 100 };
            Controls.Add(_allocateButton);

            _releaseButton = new Button { Text = "Zwolnij", Top = 310, Left = 230, Width = 100 };
            Controls.Add(_releaseButton);

        }


    }
}
