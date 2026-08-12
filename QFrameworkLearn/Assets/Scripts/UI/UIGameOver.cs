using UnityEngine;
using UnityEngine.UI;
using QFramework;
using QFramework.FlappyBird;
using UnityEngine.SceneManagement;

namespace QFramework.Example
{
	public class UIGameOverData : UIPanelData
	{
	}
	public partial class UIGameOver : UIPanel
	{
		protected override void OnInit(IUIData uiData = null)
		{
			mData = uiData as UIGameOverData ?? new UIGameOverData();
			// please add init code here
			BtnRestart.onClick.AddListener (() =>
			{
				CloseSelf();
				FlappyBird.FlappyBird.GameState.Value = GameStates.NotStart;
				//当前的场景重新加载一遍
				Time.timeScale = 1;
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			});
		}
		
		protected override void OnOpen(IUIData uiData = null)
		{
		}
		
		protected override void OnShow()
		{
		}
		
		protected override void OnHide()
		{
		}
		
		protected override void OnClose()
		{
		}
	}
}
