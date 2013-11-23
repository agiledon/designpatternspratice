using System;
using System.Collections.Generic;
using System.Text;

namespace DonOfDesign.PracticePatterns.SetupWizard
{
    public interface ISetupCommand
    {
        void SetupForward();
        void SetupBackward();
    }
}
