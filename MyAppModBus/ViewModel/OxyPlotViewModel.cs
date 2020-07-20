using MyAppModBus.Base.BaseViewModel;
using OxyPlot;
using System.Collections.ObjectModel;

namespace MyAppModBus.ViewModel
{
  internal class OxyPlotViewModel : BaseViewModel
  {


    private PlotModel _model;
    private ObservableCollection<DataPoint> _tempDatapPoints;

    public PlotModel Model {
      get => _model;
      set => Set(ref _model, value);
    }

    public ObservableCollection<DataPoint> TempDataPoints {
      get => _tempDatapPoints;
      set => Set(ref _tempDatapPoints, value);
    }

    private ObservableCollection<DataPoint> _humiDataPoint;

    public ObservableCollection<DataPoint> HumiDataPoints {
      get => _humiDataPoint;
      set => Set(ref _humiDataPoint, value);
    }

  }
}
