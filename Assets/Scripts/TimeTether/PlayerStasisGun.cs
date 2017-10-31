﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStasisGun : MonoBehaviour 
{
	public KeyCode shootKey; 
	public bool resetWhenFull; 

	public KeyCode cancelKey; 
	public GameObject stasisBulletPrefab; 

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(shootKey))
		{
			if (SaveStateManager.inst.CanMakeStasisBubble())
			{
				Shoot(); 
			}
			else if (resetWhenFull)
			{
				SaveStateManager.inst.ResetStasisBubbles(); 
			}
		}

		if (Input.GetKeyDown(cancelKey))
		{
			SaveStateManager.inst.ResetStasisBubbles(); 
		}
	}

	void Shoot()
	{
		GameObject newBullet = Instantiate(stasisBulletPrefab, transform.position, Quaternion.identity, this.transform.parent);
		newBullet.transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z);  
	}
}