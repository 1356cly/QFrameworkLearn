using QFramework;
using Unity.VisualScripting;
using UnityEngine;

namespace CounterApp
{


    public interface IAchievementSystem : ISystem
    {
        
    }
    public class AchievementSystem:AbstractSystem, IAchievementSystem
    {
        
        protected override void OnInit()
        {
            var model = this.GetModel<ICounterModel>();
            model.Count.Register(count =>
            {
                if (count == 10)
                {
                    Debug.Log("你是点击达人！");
                }
                else if (count == 20)
                {
                    Debug.Log("你是点击专家！");
                }
                else if (count == -10)
                {
                    Debug.Log("你是点击菜鸟~");
                }
            });

        }
    }
}