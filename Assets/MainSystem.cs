using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSystem : MonoBehaviour{

	// メインスコア
	public static float score;
	// 表示用のスコア
	public int myScore;
	[SerializeField]
	private Text scoreText;

	// Update is called once per frame
	void Update () {

		// 表示用スコア
		if (myScore != score) {
			myScore = (int)score;
			scoreText.text = score.ToString();
		}

	}
}
