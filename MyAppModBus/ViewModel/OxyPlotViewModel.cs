using System.Collections.ObjectModel;
using MyAppModBus.Models;
using OxyPlot;

namespace MyAppModBus.ViewModel
{
  internal class OxyPlotViewModel : OxyPlotModel
  {


    public OxyPlotViewModel()
    {
       
    }


    private PlotModel _model;
    private ObservableCollection<DataPoint> _volltagePoints;
    private ObservableCollection<DataPoint> _currentPoints;
    private ObservableCollection<DataPoint> _torquePoints;
    private double _countTime;

    public PlotModel Model {
      get => _model;
      set => Set(ref _model, value);
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

    public double CountTime
    {
      get => _countTime;
      set => Set(ref _countTime, value);
    }

  }
}
