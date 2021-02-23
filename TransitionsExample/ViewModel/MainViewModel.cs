using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitionsExample.Helpers;

namespace TransitionsExample.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        // 0 - your first frame
        // 1 - second frame, etc.

        private int _selectedTransitionIndex;
        public int SelectedTransitionIndex
        {
            get => _selectedTransitionIndex;
            set
            {
                _selectedTransitionIndex = value;
                RaisePropertyChanged();
            }
        }

        private RelayCommand _switchToSecondFrameCommand;
        public RelayCommand SwitchToSecondFrameCommand => _switchToSecondFrameCommand ?? (_switchToSecondFrameCommand = new RelayCommand((o) => SwitchToSecond(o)));
        private void SwitchToSecond(object obj)
        {
            SelectedTransitionIndex = 1;
        }

        private RelayCommand _switchToFirstFrameCommand;
        public RelayCommand SwitchToFirstFrameCommand => _switchToFirstFrameCommand ?? (_switchToFirstFrameCommand = new RelayCommand((o) => SwitchToFirst(o)));
        private void SwitchToFirst(object obj)
        {
            SelectedTransitionIndex = 0;
        }
    }
}
