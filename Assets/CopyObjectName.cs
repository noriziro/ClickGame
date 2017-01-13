using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopyObjectName : MonoBehaviour {

	public ClickObjectManager clickObjectManager;
	private Text text;
	private float holdcost = 0;

	[Header("同期させる項目")]
	[SerializeField]
	private bool isName;
	[SerializeField]
	private bool isCost;

	void Start () {
		text = gameObject.GetComponent<Text> ();
	}
	
	void Update () {
		
		if (isName) {
			if (clickObjectManager.myName != text.text) {
				text.text = clickObjectManager.myName;
			}
		}

		if (isCost) {
			if (holdcost != clickObjectManager.cost) {
				text.text = clickObjectManager.cost.ToString () + " pt";
			}
		}

	}
}
