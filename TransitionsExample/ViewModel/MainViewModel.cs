using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TransitionsExample.Helpers;
using TransitionsExample.View;

namespace TransitionsExample.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private static readonly Lazy<MainViewModel> _lazyDesignTime = new Lazy<MainViewModel>(() => new MainViewModel());
        public static MainViewModel DesignTimeInstance => _lazyDesignTime.Value;

        private ObservableCollection<UserControl> _slides;
        public ObservableCollection<UserControl> Slides => _slides;

        private int _selectedIndex;
        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                _selectedIndex = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            _slides = new ObservableCollection<UserControl>
            {
                new Slide1(),
                new Slide2()
            };
            _selectedIndex = 0;
        }

        private void Next(object obj)
        {
            SelectedIndex++;
        }

        private void Previous(object obj)
        {
            SelectedIndex--;
        }

        private void Add(object obj)
        {
            Slides.Add(new Slide1());
        }

        private void Insert(object obj)
        {
            Slides.Insert(0, new Slide2());
        }

        private RelayCommand _nextCommand;
        public RelayCommand NextCommand => _nextCommand ??
            (_nextCommand = new RelayCommand(Next));

        private RelayCommand _previousCommand;
        public RelayCommand PreviousCommand => _previousCommand ??
            (_previousCommand = new RelayCommand(Previous));

        private RelayCommand _addCommand;
        public RelayCommand AddCommand => _addCommand ??
            (_addCommand = new RelayCommand(Add));

        private RelayCommand _insertCommand;
        public RelayCommand InsertCommand => _insertCommand ??
            (_insertCommand = new RelayCommand(Insert));
    }
}
