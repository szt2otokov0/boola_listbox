using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    partial class ExpenseViewModel : ObservableObject
    {

        [ObservableProperty] private List<SpendProfile> spendProfiles = new() { SpendProfile.Personal,SpendProfile.Work};
        [ObservableProperty] private List<Currency> currencies = new() { Currency.HUF,Currency.EUR,Currency.USD,Currency.XRD};
        [ObservableProperty] private List<RepeatUnit> repeatUnits = new() { RepeatUnit.Days,RepeatUnit.Weeks,RepeatUnit.Months,RepeatUnit.Years };

        [ObservableProperty] private Expense expense = new();
    }
}
