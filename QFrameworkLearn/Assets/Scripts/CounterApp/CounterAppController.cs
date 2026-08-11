using QFramework;
using UnityEngine;
using UnityEngine.UI;

namespace CounterApp
{
    //Controller
    public class CounterAppController : MonoBehaviour,IController
    {
        //view
        public Button BtnAdd;
        public Button BtnSub;
        public Text CountText;
        
        //Model

        private ICounterModel mModel;

        void Start()
        {
            mModel = this.GetModel<ICounterModel>(); 
            BtnAdd.onClick.AddListener(() => 
            {   
                this.SendCommand<IncreaseCountCommand>();//交互逻辑
            });
            BtnSub.onClick.AddListener(() => 
            {   this.SendCommand<DecreaseCountCommand>();//交互逻辑
            });
            
            //表现逻辑
            mModel.Count.RegisterWithInitValue(count =>
            {
                UpdateView();
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
            
        }

        void UpdateView()
        {
            CountText.text = mModel.Count.ToString();
        }

        public IArchitecture GetArchitecture()
        {
            return CounterAPP1.Interface;
        }
    }
}

