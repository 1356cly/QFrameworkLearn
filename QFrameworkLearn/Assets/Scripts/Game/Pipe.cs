using UnityEngine;
using QFramework;

namespace QFramework.FlappyBird
{
	public partial class Pipe : ViewController
	{
		[SerializeField] private float _pipeSpeed = 2;

		
		void Start()
		{

		}

		private void FixedUpdate()
		{
			transform.LocalPositionX(transform.localPosition.x - 1*_pipeSpeed * Time.fixedDeltaTime * _pipeSpeed);
			if (transform.position.x < 0 )
			{
				Debug.Log("积分+1");
			}
			if (transform.position.x < -20)
			{
				gameObject.DestroySelf();
			}
		}
	}
}
