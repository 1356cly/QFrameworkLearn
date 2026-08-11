using QFramework;
using UnityEngine;

namespace CounterApp
{
    public interface ICounterModel : IModel
    {
        BindableProperty<int> Count { get; }
    }
    public class CounterModel:AbstractModel, ICounterModel
    {
        
        public BindableProperty<int> Count{ get; } = new BindableProperty<int>(0);
      
        private IStorage mStorage;
        protected override void OnInit()
        {
            mStorage = this.GetUtility<IStorage>();
            Count.Value = mStorage.LoadInt(nameof(Count),0);

            Count.Register(count =>
            {
                mStorage.SaveInt(nameof(Count), count);
            });
        }
    }
}