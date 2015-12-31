using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XGamepadDemo;
using stageclr;
using System.Windows.Threading;
namespace XBoxJoyStick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XGamepadDemo.XBoxJoyStick _JoyStick;
        CStage _myStage;
        StageControl myStageControl = new StageControl();
        DispatcherTimer timer;
        // Timer and event
        public MainWindow()
        {
            InitializeComponent();
            myStageControl.Initialize();
            _myStage = myStageControl.Stage;

            _JoyStick = new XGamepadDemo.XBoxJoyStick();
            _JoyStick.Initialize(0);
            _JoyStick.Stage = _myStage;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Tick += new EventHandler(OnTick);
            timer.Start();
        }
        // Add Update Method
        private void OnTick(object sender, EventArgs evt)
        {
            try
            {
                Update();
            }
            catch (Exception e)
            {
                timer.Stop();
//                Text = "Error: " + e;
            }
        }

        public void Update()
        {
            UpdateDRO();
        }
        public void UpdateDRO()
        {
            double X = 0.0, Y = 0.0, Z = 0.0;
            _myStage.GetPos(out X, out Y, out Z);
            txtBoxXAxis.Text = X.ToString();
            txtBoxYAxis.Text = Y.ToString();
            txtBoxZAxis.Text = Z.ToString();

        }
        private void txtBoxXAxis_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtBoxXYZAxis_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtBoxXAxis_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
