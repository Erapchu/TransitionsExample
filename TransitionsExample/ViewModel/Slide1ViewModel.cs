using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitionsExample.Helpers;

namespace TransitionsExample.ViewModel
{
    class Slide1ViewModel : ViewModelBase
    {
        MainViewModel mainViewModel;

        public Slide1ViewModel(MainViewModel mainVM)
        {
            mainViewModel = mainVM;
        }

        private void ShowHide(object obj)
        {
            mainViewModel.ShowHide1 = !mainViewModel.ShowHide1;
        }

        private RelayCommand _showHideCommand;
        public RelayCommand ShowHideCommand => _showHideCommand ?? (_showHideCommand = new RelayCommand(ShowHide));
    }
}
