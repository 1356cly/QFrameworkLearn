using QFramework;

namespace CounterApp
{
    public class CounterAPP1:Architecture<CounterAPP1>
    {
        protected override void Init()
        {
           this.RegisterModel(new CounterModel());
        }
    }
}