using MyAppModBus.Base.BaseViewModel;
using System.Collections.ObjectModel;
using OxyPlot;
using OxyPlot.Series;
using System.Threading.Tasks;
using System;
using OxyPlot.Axes;
using System.Threading;

namespace MyAppModBus.ViewModel
{
  public class OxyPlotViewModel : BaseViewModel
  {

    public OxyPlotViewModel()
    {
      TempDataPoints = new ObservableCollection<DataPoint>();
      HumiDataPoints = new ObservableCollection<DataPoint>();

      var rd = new Random();

      Task.Run(() =>
      {
        while (true)
        {
          var date = DateTime.Now;
          App.Current.Dispatcher.BeginInvoke(new Action(() => {

            TempDataPoints.Add(DateTimeAxis.CreateDataPoint(date, (double)(rd.Next(100, 500) / 10.0)));
            HumiDataPoints.Add(DateTimeAxis.CreateDataPoint(date, (double)(rd.Next(500, 800) / 10.0)));
            if (TempDataPoints.Count > 300)
            {
              TempDataPoints.RemoveAt(0);
              HumiDataPoints.RemoveAt(0);
            }
          }));

          Thread.Sleep(100);
        }
      });


    }


    private PlotModel _model;
    private ObservableCollection<DataPoint> _tempDatapPoints;
    private ObservableCollection<DataPoint> _humiDataPoint;

    public PlotModel Model {
      get => _model;
      set => Set(ref _model, value);
    }

    public ObservableCollection<DataPoint> TempDataPoints {
      get => _tempDatapPoints;
      set => Set(ref _tempDatapPoints, value);
    }


    public ObservableCollection<DataPoint> HumiDataPoints {
      get => _humiDataPoint;
      set => Set(ref _humiDataPoint, value);
    }

  }
}
