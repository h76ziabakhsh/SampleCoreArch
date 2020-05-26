using System;
using System.Collections.Generic;
using System.Text;

namespace Paycompute.Services.Interfaces
{
    public interface INationalInsuranceContributionService
    {
        decimal NIContribution(decimal totalAmount);
    }
}
