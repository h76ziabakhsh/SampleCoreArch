using System;
using System.Collections.Generic;
using System.Text;

namespace Paycompute.Services.Interfaces
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
