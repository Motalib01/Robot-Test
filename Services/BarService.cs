using RobotOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RobotOM;

namespace TestRobotApp.Services
{
    public class BarService
    {
        private readonly IRobotStructure _structure;

        public BarService(IRobotStructure structure)
        {
            _structure = structure;
        }
        

        public string GetBarData(int barNumber)
        {

            // Get the bar object and cast it to IRobotBar
            IRobotBar bar = (IRobotBar)_structure.Bars.Get(barNumber);

            // Get bar section label
            string barSectionLabel = bar.GetLabel(IRobotLabelType.I_LT_BAR_SECTION).Name;

            // Get bar material label
            string barMaterialLabel = bar.GetLabel(IRobotLabelType.I_LT_MATERIAL).Name;

            // Get bar forces for a specific load case (e.g., 1) at the bar's midpoint
            dynamic barForces = _structure.Results.Bars.Forces.Value(barNumber, 1, 0.5);

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

            return barData;
        }
    }
}
