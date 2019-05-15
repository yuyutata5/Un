using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherManager : MonoBehaviour {


		[SerializeField, Range(0, 10)]
		public float mTimeOut = 1;

		public int mItemCountMax = 10;
		float mTimeElapsed = 0;

		void Update()
		{
			mTimeElapsed += Time.deltaTime;
			if (mTimeElapsed >= mTimeOut)
			{
				foreach (Transform launcher in transform)
				{
					launcher.GetComponent<Launcher>().Fire();
					if (launcher.childCount > mItemCountMax)
					{
						Destroy(launcher.GetChild(0).gameObject);
					}
				}
				mTimeElapsed = -0.5f;
			}
		}
	}
