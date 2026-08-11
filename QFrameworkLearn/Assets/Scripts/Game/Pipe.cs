using UnityEngine;
using QFramework;

namespace QFramework.FlappyBird
{
	public partial class Pipe : ViewController
	{
		[SerializeField] private float _pipeSpeed = 2;
		
		void Start()
		{
			// Code Here
		}

		private void FixedUpdate()
		{
			transform.LocalPositionX(transform.localPosition.x - 1*_pipeSpeed * Time.fixedDeltaTime * _pipeSpeed);
		}
	}
}
