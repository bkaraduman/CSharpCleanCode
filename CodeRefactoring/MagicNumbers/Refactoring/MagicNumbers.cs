using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefactoring.MagicNumbers.Refactoring
{
    public class MagicNumbers
    {
        public void ApproveDocument(DocumentStatus status)
        {
            if (status == DocumentStatus.Draft)
            {
                // ...
            }
            else if (status == DocumentStatus.Lodged)
            {
                // ...
            }
        }

        public void RejectDoument(DocumentStatus status)
        {
            switch (status)
            {
                case DocumentStatus.Draft:
                    break;
                case DocumentStatus.Lodged:
                    break;
                default:
                    break;
            }
        }
    }
}
