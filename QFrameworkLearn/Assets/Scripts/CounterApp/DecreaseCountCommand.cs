using QFramework;

namespace CounterApp
{
    public class DecreaseCountCommand:AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<ICounterModel>().Count.Value--;
        }
    }
}