using UnityEngine;
using QFramework;

namespace QFramework.FlappyBird
{
	public partial class PipeGenerator : ViewController
	{
		//管道间隔时间
		private float mDuration = 0;
		public float DurationMin = 1;
		public float DurationMax = 2.5f;
		
		//管道间隔基准时间
		private float _mGenerateTime = 0;
		
		
		void Start()
		{
			// Code Here
			PipeTemplate.Hide();
			_mGenerateTime =  Time.time;
			mDuration = Random.Range(DurationMin, DurationMax);
		}

		void Update()
		{
			if (FlappyBird.GameState.Value == GameStates.NotStart)
			{
				return;
			}
			if (Time.time - _mGenerateTime >mDuration)
			{
				_mGenerateTime =  Time.time;
				mDuration = Random.Range(DurationMin, DurationMax);//每次生成之后，重新计算一次Duration
				PipeTemplate.Instantiate(PipeGeneratorPos.position,Quaternion.identity)
					.LocalPositionY(Random.Range(-3,4))
					.Show();
			}
		}
	}
}
