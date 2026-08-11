using QFramework;
using UnityEngine;

namespace CounterApp
{
    public class IncreaseCountCommand:AbstractCommand
    {
        protected override void OnExecute()
        {
            var counterModel = this.GetModel<ICounterModel>();
            counterModel.Count.Value++;
            
        }
    }
}