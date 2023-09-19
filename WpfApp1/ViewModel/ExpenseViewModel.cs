using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    internal partial class ExpenseViewModel : ObservableObject
    {

        [ObservableProperty] private ObservableCollection<SpendProfile> spendProfiles = new() { SpendProfile.Personal, SpendProfile.Work };
        [ObservableProperty] private ObservableCollection<Currency> currencies = new() { Currency.HUF, Currency.EUR, Currency.USD, Currency.XRD };
        [ObservableProperty] private ObservableCollection<RepeatUnit> repeatUnits = new() { RepeatUnit.Days, RepeatUnit.Weeks, RepeatUnit.Months, RepeatUnit.Years };
        [ObservableProperty] private ObservableCollection<Expense> expenses = new();

        private SpendProfile selectedSpendProfile;
        public SpendProfile SelectedSpendProfile
        {
            get => selectedSpendProfile;
            set {
                SetProperty(ref selectedSpendProfile, value);
                SelectedExpense = SelectedExpense with { Profile = selectedSpendProfile};
            }
        }

        private Currency selectedCurrency;
        public Currency SelectedCurrency
        {
            get => selectedCurrency;
            set {
                SetProperty(ref selectedCurrency, value);
                SelectedExpense = SelectedExpense with { Currency = selectedCurrency};
            }
        }

        [ObservableProperty] private Expense selectedExpense = new();

        public ExpenseViewModel()
        {
            selectedExpense = new();
            expenses.Add(new Expense());
        }

        [RelayCommand]
        public void Save(Expense expenseToSave)
        {
            Expenses.Add(expenseToSave);
            OnPropertyChanged(nameof(Expenses));
        }

        [RelayCommand]
        public void Create()
        {
            SelectedExpense = new();
        }

        [RelayCommand]
        public void Delete(Expense expenseToDelete)
        {
            Expenses.Remove(expenseToDelete);
            OnPropertyChanged(nameof(Expenses));
        }
    }
}
