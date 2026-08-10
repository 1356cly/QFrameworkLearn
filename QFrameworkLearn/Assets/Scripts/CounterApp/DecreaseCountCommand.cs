using QFramework;

namespace CounterApp
{
    public class DecreaseCountCommand:AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<CounterModel>().Count--;
            this.SendEvent<CountChangedEvent>();
        }
    }
}