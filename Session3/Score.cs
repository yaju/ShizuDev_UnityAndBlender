using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	// スコアを表示するGUIText
	public Text scoreGUIText;
	
	// スコア
	private int score;
	
	void Start ()
	{
		Initialize ();
	}
	
	void Update ()
	{
		// スコア・ハイスコアを表示する
		scoreGUIText.text = "Score : " + score.ToString ();
	}
	
	// ゲーム開始前の状態に戻す
	private void Initialize ()
	{
		// スコアを0に戻す
		score = 0;
	}
	
	// ポイントの追加
	public void AddPoint (int point)
	{
		score = score + point;
	}
}
