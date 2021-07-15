using System;
using VisitorProject.Models;

namespace VisitorProject.Visitors
{
    public class ReportPastDueVisitor : IVisitor
    {
        private bool isReportPastedOnClinical;
        private bool isReportPastedOnInventory;


        public void VisitClinical(Clinical clinical)
        {
            clinical.IsPastedClinicalReport = true;
            isReportPastedOnClinical = true;
            //Save on DB
            //else
                //isReportPastedOnClinical = false;
        }

        public void VisitInventory(Inventory inventory)
        {
            inventory.IsPastedOnInventory = true;
            isReportPastedOnInventory = true;
            //Save on DB
            //else
                //isReportPastedOnInventory = false;
        }

        public bool IsTotallyPast()
        {
            return isReportPastedOnClinical && isReportPastedOnInventory;
        }
    }
}
