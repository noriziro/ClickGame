using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ClickObjectからWaitTimeを可視化
/// </summary>
public class WaitTimeGraph : MonoBehaviour {

	[SerializeField]
	private ClickObjectManager clickObjectManager;
	private Image _GraphImage;
	//private float time;

	void Start () {
		
		_GraphImage = gameObject.GetComponent<Image> ();
	
	}
	
	void Update () {
		//clickObjectManager.time += Time.deltaTime;
		_GraphImage.fillAmount = clickObjectManager.time/clickObjectManager.waitTime;
		/*
		if (time >= clickObjectManager.waitTime) {
			time = 0;
		}
		 */

	}
}
