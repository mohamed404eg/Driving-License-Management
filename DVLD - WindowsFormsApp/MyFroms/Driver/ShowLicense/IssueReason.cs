using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD___WindowsFormsApp.MyFroms.Driver.ShowLicense
{
    internal class IssueReason
    {
       static public string GetIssueReasonName(byte Id)
        {
            switch (Id)
            {

                case 1:
                    return "first time";
                    break;
                    case 2: return "Re-inspection service";
                    break ;
                case 3: return "license renewal";
                    break;
                case 4: return "lost license";

                    break;
                case 5: return "damaged license";
                        break;
                case 6: return "license cancellation";
                    break;
                case 7: return "International license";
                    break;


            }

            return "Not Found";
        }
    }
}
