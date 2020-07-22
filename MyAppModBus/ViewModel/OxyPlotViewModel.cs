using MyAppModBus.ViewModel.BaseViewModel;
using OxyPlot;
using System.Collections.ObjectModel;

namespace MyAppModBus.ViewModel
{
  internal class OxyPlotViewModel : ViewModelBase
  {
    public OxyPlotViewModel()
    {
      
    }

    private string _titleMainWindow = "ModBus(RTU)";

    private ObservableCollection<DataPoint> _volltagePoints;
    private ObservableCollection<DataPoint> _currentPoints;
    private ObservableCollection<DataPoint> _torquePoints;


    public string TitleMainWindow {
      get => _titleMainWindow;
      set => Set(ref _titleMainWindow, value);
    }
    public ObservableCollection<DataPoint> VolltagePoints
    {
      get => _volltagePoints;
      set => Set(ref _volltagePoints, value);
    }
    public ObservableCollection<DataPoint> CurrentPoints
    {
      get => _currentPoints;
      set => Set(ref _currentPoints, value);
    }
    public ObservableCollection<DataPoint> TorquePoints
    {
      get => _torquePoints;
      set => Set(ref _torquePoints, value);
    }

  }
}
