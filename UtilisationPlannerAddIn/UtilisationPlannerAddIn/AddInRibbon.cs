using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace UtilisationPlannerAddIn
{
    public partial class AddInRibbon
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, RibbonControlEventArgs e)
        {
            FileForm fileForm = new FileForm();
            fileForm.ShowDialog();

            if (fileForm.DialogResult != System.Windows.Forms.DialogResult.Cancel)
            {
                
            }
        }
    }
}
