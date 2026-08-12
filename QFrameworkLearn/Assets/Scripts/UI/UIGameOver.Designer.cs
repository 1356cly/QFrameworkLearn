using System;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

namespace QFramework.Example
{
	// Generate Id:dd2f7c7d-96e4-4279-b21f-9af4f4434074
	public partial class UIGameOver
	{
		public const string Name = "UIGameOver";
		
		[SerializeField]
		public UnityEngine.UI.Button BtnRestart;
		
		private UIGameOverData mPrivateData = null;
		
		protected override void ClearUIComponents()
		{
			BtnRestart = null;
			
			mData = null;
		}
		
		public UIGameOverData Data
		{
			get
			{
				return mData;
			}
		}
		
		UIGameOverData mData
		{
			get
			{
				return mPrivateData ?? (mPrivateData = new UIGameOverData());
			}
			set
			{
				mUIData = value;
				mPrivateData = value;
			}
		}
	}
}
