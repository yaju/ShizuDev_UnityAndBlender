using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collisionInfo) {
		int sc = 0;

		switch (this.name) {
			case "block_red":
				sc = 30;
				break;
			case "block_yellow":
				sc = 20;
				break;
			case "block_blue":
				sc = 15;
				break;
			case "block_pink":
				sc = 10;
				break;
			case "block_green":
				sc = 5;
				break;
		}

		// スコアコンポーネントを取得してポイントを追加
		FindObjectOfType<Score>().AddPoint(sc);
		// Destroy the whole Block
		Destroy(gameObject);
	}
}
