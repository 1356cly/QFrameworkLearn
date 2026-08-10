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

        private CounterModel mModel;

        void Start()
        {
            mModel = this.GetModel<CounterModel>(); 
            BtnAdd.onClick.AddListener(() => 
            {   mModel.Count++;//交互逻辑
                UpdateView();//表现逻辑
            });
            BtnSub.onClick.AddListener(() => 
            {   mModel.Count--;//交互逻辑
                UpdateView();//表现逻辑
            });
            UpdateView();
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

