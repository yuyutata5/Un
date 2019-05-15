using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LaunchUtil
{
	public static void LaunchItem(ref Transform item, float power, Vector2 vector, float rotation = 0, float torquePower = 0)
	{
		//発射方向を設定
		Vector2 launchVector = Quaternion.Euler(0, 80, rotation) * vector.normalized;

		//Rigidbody取り出す
		Rigidbody2D r = item.gameObject.GetComponent<Rigidbody2D>();
		if (r == null)
		{
			r = item.gameObject.AddComponent<Rigidbody2D>();
		}

		//力を加える
		r.AddForce(launchVector * power, ForceMode2D.Impulse);

		//回転を加える
		r.AddTorque(torquePower, ForceMode2D.Impulse);
	}
}


