using System.Collections;
using UnityEngine;
using QFramework;

namespace QFramework.FlappyBird
{
	public partial class Player : ViewController
	{
		private Rigidbody2D _mRigidbody2D;
		
		[SerializeField,Header("小鸟蹦跶速率")] private float _jumpSpeed =7.5f;
		
		private SpriteRenderer _mSpriteRenderer;

		private bool _mCheckPlayerInScreen = false;
		IEnumerator Start()
		{
			_mRigidbody2D = GetComponent<Rigidbody2D>();	
			_mSpriteRenderer = GetComponent<SpriteRenderer>();
			
			yield return new WaitForEndOfFrame();
			//等一帧再设置为true，避免一开始就触发_mSpriteRenderer.isVisible导致游戏失败
			_mCheckPlayerInScreen = true;
			
			FlappyBird.GameState.RegisterWithInitValue(state=>
			{
				if (state == GameStates.NotStart)
				{
					_mRigidbody2D.bodyType = RigidbodyType2D.Static;
				}
				else
				{
					_mRigidbody2D.bodyType = RigidbodyType2D.Dynamic;
				}
			}).UnRegisterWhenGameObjectDestroyed(gameObject);
		}



		private void Update()
		{
			//点击鼠标给小鸟提供一个向上的速率
			if (Input.GetMouseButtonDown(0))
			{
				if (FlappyBird.GameState.Value == GameStates.NotStart)
				{
					FlappyBird.GameState.Value = GameStates.Started;
				}
				_mRigidbody2D.velocity = Vector2.up * _jumpSpeed;
			}

			if (!_mSpriteRenderer.isVisible && _mCheckPlayerInScreen)
			{

					GameOver();
				
				
			}
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
	
				GameOver();
			
		}

		public void GameOver()
		{
			if (FlappyBird.GameState.Value == GameStates.Started)
			{
				FlappyBird.GameState.Value = GameStates.GameOver;
				UIKit.OpenPanel<UIGameOver>();
				Debug.Log("Game Over");
				Time.timeScale = 0;
			}
			
		}
	}
}
