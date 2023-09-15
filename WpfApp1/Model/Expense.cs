using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    record Expense(SpendProfile Profile, string Title, string AmountText, Currency Currency, string Description,
        DateTime Date, bool Repeats, byte? RepeatRate, RepeatUnit? RepeatUnit
        )
    {
        public Expense() : this(SpendProfile.Personal, "New expense", "0", Currency.HUF, "something", DateTime.UnixEpoch, false, null, null)
        {
        }

        public double Amount => Convert.ToDouble(AmountText);
    }

    enum SpendProfile
    {
        Personal,
        Work
    }

    enum Currency
    {
        HUF,
        EUR,
        USD,
        XRD
    }

    enum RepeatUnit
    {
        Days,
        Weeks,
        Months,
        Years
    }
}
