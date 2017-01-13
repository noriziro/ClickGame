using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickObjectManager : MonoBehaviour , IPointerClickHandler  {

	[Header("名前")]
	public string myName;
	[Header("単価")]
	public float cost;
	[Header("出力"),SerializeField]
	private float power;
	[Header("待ち時間")]
	public float waitTime;
	[Header("購入数")]
	public int buyNumber = 0;

	public float time;
	private bool isBuy;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (buyNumber != 0) {
			time += Time.deltaTime;
			if (time >= waitTime) {
				time = 0;
				MainSystem.score += power;

			}
		}

	}

	//もしレイキャストがあたっており
	//マウスにくりっくされたら実行
	public void OnPointerClick (PointerEventData eventData)
	{
		if (cost < MainSystem.score) {
			
			MainSystem.score-= cost;
			cost *= 1.5f;
			power *= 1.2f;
			time = 0;
			buyNumber++;
			isBuy = true;

			cost = Mathf.Floor (cost);
			power = Mathf.Floor (power);


		}


		//購入したら確認
		if(isBuy){
			if (buyNumber == 5 || buyNumber == 25 || buyNumber == 50 || buyNumber == 100 || buyNumber == 250) {
				waitTime /= 2;
				waitTime = Mathf.CeilToInt (waitTime);
			}
		}

		isBuy = false;

	}

}
