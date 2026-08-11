using QFramework;
using UnityEngine;

namespace CounterApp
{
    public class CounterAPP1:Architecture<CounterAPP1>
    {
        protected override void Init()
        {
           this.RegisterModel<ICounterModel>(new CounterModel());
           this.RegisterUtility<IStorage>(new Storage());
           this.RegisterSystem<IAchievementSystem>(new AchievementSystem());
        }

        protected override void ExecuteCommand(ICommand command)
        {
            Debug.Log("Before Command Execute:"+ command.GetType().Name);
            base.ExecuteCommand(command);
            Debug.Log("After Command Execute:"+ command.GetType().Name);
        }
    }
}