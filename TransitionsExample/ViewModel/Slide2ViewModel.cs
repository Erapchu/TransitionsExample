using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitionsExample.Helpers;

namespace TransitionsExample.ViewModel
{
    class Slide2ViewModel : ViewModelBase
    {
        MainViewModel mainViewModel;

        public Slide2ViewModel(MainViewModel mainVM)
        {
            mainViewModel = mainVM;
        }

        private void ShowHide(object obj)
        {
            mainViewModel.ShowHide2 = !mainViewModel.ShowHide2;
        }

        private RelayCommand _showHideCommand;
        public RelayCommand ShowHideCommand => _showHideCommand ?? (_showHideCommand = new RelayCommand(ShowHide));
    }
}
