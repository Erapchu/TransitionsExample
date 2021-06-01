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

        private bool _showHide1;
        public bool ShowHide1
        {
            get => _showHide1;
            set
            {
                _showHide1 = value;
                RaisePropertyChanged();
            }
        }

        private bool _showHide2;
        public bool ShowHide2
        {
            get => _showHide2;
            set
            {
                _showHide2 = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            _slides = new ObservableCollection<UserControl>
            {
                new Slide1(this),
                new Slide2(this)
            };
            _selectedIndex = 0;
        }

        private void Next(object obj)
        {
            if (SelectedIndex < Slides.Count - 1)
                SelectedIndex++;
        }

        private void Previous(object obj)
        {
            if (SelectedIndex > 0)
                SelectedIndex--;
        }

        private void Add(object obj)
        {
            Slides.Add(new Slide1(this));
        }

        private void Insert(object obj)
        {
            Slides.Insert(0, new Slide2(this));
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
