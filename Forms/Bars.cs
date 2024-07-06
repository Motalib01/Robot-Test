using RobotOM;
using System;
using System.Windows.Forms;

namespace TestRobotApp.Forms
{
    public partial class Bars : Form
    {
        IRobotApplication robApp;
        IRobotStructure str;

        public Bars()
        {
            InitializeComponent();
            InitializeRobot();
        }

        private void InitializeRobot()
        {
            robApp = new RobotApplication();

            if (robApp.Visible == 0)
            {                
                robApp.Interactive = 1;
                robApp.Visible = 1;
            }

            string projectFilePath = @"C:\Users\chemo\Documents\work\ROBOT COMPLETE\project in roboto\BLOC A.rtd";

            robApp.Project.Open(projectFilePath); 
            str = robApp.Project.Structure;
        }

        private void GetBarData(int barNumber)
        {
            
            IRobotBar bar = (IRobotBar)str.Bars.Get(barNumber);

            string barSectionLabel = bar.GetLabel(IRobotLabelType.I_LT_BAR_SECTION).Name;

            string barMaterialLabel = bar.GetLabel(IRobotLabelType.I_LT_MATERIAL).Name;

            dynamic barForces = str.Results.Bars.Forces.Value(barNumber, 1, 0.5);

            string barData = $"Bar {barNumber} Data:\n" +
                             $"Section: {barSectionLabel}\n" +
                             $"Material: {barMaterialLabel}\n" +
                             $"Forces at midpoint:\n" +
                             $"  Axial Force (Fx): {barForces.FX} N\n" +
                             $"  Shear Force Y (Fy): {barForces.FY} N\n" +
                             $"  Shear Force Z (Fz): {barForces.FZ} N\n" +
                             $"  Torsional Moment (Mx): {barForces.MX} N*m\n" +
                             $"  Bending Moment Y (My): {barForces.MY} N*m\n" +
                             $"  Bending Moment Z (Mz): {barForces.MZ} N*m";

            MessageBox.Show(barData, "Bar Data");
        }

        private void GetBarDataBtn_Click(object sender, EventArgs e)
        {
            int barNumber = 1; 
            GetBarData(barNumber);
        }
    }
}
