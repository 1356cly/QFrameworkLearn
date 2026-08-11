using QFramework;

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
    }
}