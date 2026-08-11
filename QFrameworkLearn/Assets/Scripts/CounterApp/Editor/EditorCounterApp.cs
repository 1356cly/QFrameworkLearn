using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEditor;
using UnityEngine;

namespace CounterApp
{
    public class EditorCounterApp : EditorWindow,IController
    {
        [MenuItem("CounterApp/Window")]
        public static void Open()
        {
            var counterApp = GetWindow<EditorCounterApp>();
            counterApp.Show();
        }

        private ICounterModel mModel;
        private void OnEnable()
        {
            mModel = this.GetModel<ICounterModel>();
        }

        private void OnDisable()
        {
            mModel = null;
        }

        private void OnGUI()
        {
            if (GUILayout.Button("+"))
            {
                this.SendCommand<IncreaseCountCommand>();
            }
            GUILayout.Label(mModel.Count.Value.ToString());
            if (GUILayout.Button("-"))
            {
                this.SendCommand<DecreaseCountCommand>();
            }
        }

        public IArchitecture GetArchitecture()
        {
            return CounterAPP1.Interface;
        }
    }
}

