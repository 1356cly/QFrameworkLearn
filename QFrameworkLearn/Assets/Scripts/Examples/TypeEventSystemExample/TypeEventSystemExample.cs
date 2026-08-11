using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace QFramework.Example
{
    public class TypeEventSystemExample : MonoBehaviour
    {
        public interface IEvent
        {
            
        }
        public struct EventA: IEvent
        {
            public int Count;
        }

        void Start()
        {
            TypeEventSystem.Global.Register<IEvent>(e =>
            {
                if (e is EventA)
                {
                    Debug.Log("event a received");
                }
                
            }).UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                TypeEventSystem.Global.Send<IEvent>(new EventA()
                {
                    Count = 10
                });
            }
        }
    }
}

