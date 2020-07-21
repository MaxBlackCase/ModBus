using MyAppModBus.ViewModel.BaseViewModel;
using System.Threading.Tasks;

namespace MyAppModBus.Models
{
  internal class OxyPlotModel : BaseViewModel
  {

    public OxyPlotModel()
    {
      SetCountTime(1000);
    }

    public void SetCountTime(int seconds)
    {

      Task.Factory.StartNew(() => {

        while (true)
        {
          Task.Delay(seconds).Wait();

          CountTime++;
        }
      
      });
      
    }

  }
}
