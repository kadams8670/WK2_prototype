﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObj_Interactable : Interactable 
{
	[Tooltip("Drag in the GameObject that will be affected")]
	public GameObject obj; 

	public override void OnInteract()
	{
		obj.SetActive(!obj.activeSelf); 
	}
}
