using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardController : MonoBehaviour {

	private GameObject scoreText;

	private int score = 0;




	// Use this for initialization
	void Start () {
		//シーン中のscoreTextオブジェクトを取得（追加）
		this.scoreText = GameObject.Find("ScoreText");
		
	}
	
	// Update is called once per frame
	void Update () {
		//ScoreText獲得した点数を表示
		this.scoreText.GetComponent<Text> ().text = "Score " + this.score + "pt";

	}
		


}
