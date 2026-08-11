using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace QFrameWork.Example
{
    public class EasyEventExample : MonoBehaviour
    {
        
        public EasyEvent EventA= new EasyEvent();
        public EasyEvent<int> OnCountChangedEvent = new EasyEvent<int>();
        
        
        // Start is called before the first frame update
        void Start()
        {
            EventA.Register(() =>
            {
                Debug.Log("EasyEvent Triggered");
            }).UnRegisterWhenGameObjectDestroyed(gameObject);//比委托更好用的地方是支持简便注销事件

            OnCountChangedEvent.Register(count =>
            {
               Debug.Log(count);
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
            
            EasyEvents.Register<EasyEvent<int,string,int>>();
            EasyEvents.Get<EasyEvent<int,string,int>>().Register((count,name,count2)=>
            {
                
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
        }
           
            
        
        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                EventA.Trigger();
                OnCountChangedEvent.Trigger(10);
            }
        }
        
    }
}
        

