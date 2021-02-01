using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject snowBall;
	public float repeatRate;
	
	
	private void Start()
	{
		InvokeRepeating(nameof(LaunchProjectile), 0, repeatRate);
	}
	void LaunchProjectile()
	{
		GameObject go = Instantiate(snowBall, transform.position, Quaternion.identity);
		Destroy(go, 5f);
	}
}
