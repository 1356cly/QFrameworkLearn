using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;
using QFrameWork;

namespace  QFramework.FlappyBird
{
    public enum GameStates
    {
        NotStart,
        Started,
        GameOver,
    }
    public class FlappyBird : Architecture<FlappyBird>
    {
        public static BindableProperty<GameStates> GameState = new BindableProperty<GameStates>(GameStates.NotStart);
        
        protected override void Init()
        {
            throw new System.NotImplementedException();
        }
         
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void InitFramework()
        {
            ResKit.Init();
        }
    }
    
}

