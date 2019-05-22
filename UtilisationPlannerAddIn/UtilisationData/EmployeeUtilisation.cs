using System;
using System.Collections.Generic;
using System.Text;

namespace UtilisationData
{
    public class EmployeeUtilisation
    {
        private List<UtilisationItem> employeeUtilisation;
        public List<UtilisationItem> EmployeeUtilisations { get => employeeUtilisation; set => employeeUtilisation = value; }
    }
}
