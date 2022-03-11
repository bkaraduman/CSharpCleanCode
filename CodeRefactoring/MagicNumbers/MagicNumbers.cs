using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefactoring.MagicNumbers
{
    public class MagicNumbers
    {
        public void ApproveDocument(int status)
        {
            if (status == 1)
            {
                // ...
            }
            else if (status == 2)
            {
                // ...
            }
        }

        public void RejectDoument(string status)
        {
            switch (status)
            {
                case "1":
                    // ...
                    break;
                case "2":
                    // ...
                    break;
            }
        }
    }
}
