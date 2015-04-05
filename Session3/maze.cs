using UnityEngine;
using System.Collections;

public class maze : MonoBehaviour {

	public GameObject pacdot;

	// Use this for initialization
	void Start () {
		AddBoxColider2D ();
		AddPacdot ();
	}

	void AddBoxColider2D() {
		ArrayList data = new ArrayList();
		data.Add(new Rect(14.5f, 31.25f, 27f, 0.5f));
		data.Add(new Rect(14.5f, 30f, 1f, 2f));
		data.Add(new Rect(0.75f, 16f, 0.5f, 31f));
		data.Add(new Rect(28.25f, 16f, 0.5f, 31f));
		data.Add(new Rect(14.5f, 0.75f, 27f, 0.5f));
		data.Add(new Rect(4.5f, 28f, 3f, 2f));
		data.Add(new Rect(24.5f, 28f, 3f, 2f));
		data.Add(new Rect(10f, 28f, 4f, 2f));
		data.Add(new Rect(19f, 28f, 4f, 2f));
		data.Add(new Rect(4.5f, 24.5f, 3f, 1f));
		data.Add(new Rect(24.5f, 24.5f, 3f, 1f));
		data.Add(new Rect(14.5f, 24.5f, 7f, 1f));
		data.Add(new Rect(14.5f, 24f, 1f, 6f));
		data.Add(new Rect(8.5f, 23f, 1f, 4f));
		data.Add(new Rect(20.5f, 23f, 1f, 4f));
		data.Add(new Rect(10.5f, 21.5f, 3f, 1f));
		data.Add(new Rect(18.5f, 21.5f, 3f, 1f));
		data.Add(new Rect(2f, 21.5f, 2f, 1f));
		data.Add(new Rect (27f, 21.5f, 2f, 1f));
		data.Add(new Rect(4.5f, 18.5f, 3f, 1f));
		data.Add(new Rect(24.5f, 18.5f, 3f, 1f));
		data.Add(new Rect(4.5f, 15.5f, 3f, 1f));
		data.Add(new Rect(24.5f, 15.5f, 3f, 1f));
		data.Add(new Rect(2f, 12.5f, 2f, 1f));
		data.Add(new Rect(27f, 12.5f, 2f, 1f));
		data.Add(new Rect(5.5f, 20.5f, 1f, 3f));
		data.Add(new Rect(23.5f, 20.5f, 1f, 3f));
		data.Add(new Rect(5.5f, 13.5f, 1f, 3f));
		data.Add(new Rect(23.5f, 13.5f, 1f, 3f));
		data.Add(new Rect(8.5f, 15.5f, 1f, 7f));
		data.Add(new Rect(20.5f, 15.5f, 1f, 7f));
		data.Add(new Rect(11.25f, 17f, 0.5f, 4f));
		data.Add(new Rect(17.75f, 17f, 0.5f, 4f));
		data.Add(new Rect(14.5f, 18.75f, 6f, 0.5f));
		data.Add(new Rect(14.5f, 15.25f, 6f, 0.5f));
		data.Add(new Rect(14.5f, 12.5f, 7f, 1f));
		data.Add(new Rect(10f, 9.5f, 4f, 1f));
		data.Add(new Rect(19f, 9.5f, 4f, 1f));
		data.Add(new Rect(2f, 6.5f, 2f, 1f));
		data.Add(new Rect(27f, 6.5f, 2f, 1f));
		data.Add(new Rect(4.5f, 9.5f, 3f, 1f));
		data.Add(new Rect(24.5f, 9.5f, 3f, 1f));
		data.Add(new Rect(5.5f, 7.5f, 1f, 3f));
		data.Add(new Rect(23.5f, 7.5f, 1f, 3f));
		data.Add(new Rect(4.5f, 3.5f, 3f, 1f));
		data.Add(new Rect(24.5f, 3.5f, 3f, 1f));
		data.Add(new Rect(8.5f, 5f, 1f, 4f));
		data.Add(new Rect(20.5f, 5f, 1f, 4f));
		data.Add(new Rect(14.5f, 6.5f, 1f, 7f));
		data.Add(new Rect(14.5f, 6.5f, 7f, 1f));
		data.Add(new Rect(10.5f, 3.5f, 3f, 1f));
		data.Add(new Rect(18.5f, 3.5f, 3f, 1f));

		for (int i=0; i<data.Count; i++) {
			BoxCollider2D boxCollider2D = this.gameObject.AddComponent<BoxCollider2D> ();
			Rect rt = (Rect)data[i];
			boxCollider2D.center = new Vector2(rt.x, rt.y);
			boxCollider2D.size = new Vector2(rt.width, rt.height);
		}
	}

	void AddPacdot() {
		ArrayList data = new ArrayList ();
		data.Add ("3,4,5,6,7,8,9,10,11,12,13,16,17,18,19,20,21,22,23,24,25,26,27");	//30
		data.Add ("27,22,16,13,7,2");	//29
		data.Add ("2,7,13,14,15,16,22,27");	//28
		data.Add ("27,22,16,13,7,2");	//27
		data.Add ("2,3,4,5,6,7,8,9,10,11,12,13,16,17,18,19,20,21,22,23,24,25,26,27");	//26
		data.Add ("27,22,19,10,7,2");	//25
		data.Add ("2,7,10,19,22,27");	//24
		data.Add ("27,26,25,24,23,22,19,18,17,16,13,12,11,10,7,6,5,4,3,2");	//23
		data.Add ("4,7,13,16,22,25");	//22
		data.Add ("25,22,16,13,7,4");	//21
		data.Add ("2,3,4,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,25,26,27");	//20
		data.Add ("27,22,19,10,7,2");	//19
		data.Add ("2,7,10,19,22,27");	//18
		data.Add ("27,26,25,24,23,22,19,10,7,6,5,4,3,2");	//17
		data.Add ("2,7,10,19,22,27");	//16
		data.Add ("2,7,10,19,22,27");	//15
		data.Add ("2,3,4,7,10,11,12,13,14,15,16,17,18,19,22,25,26,27");	//14
		data.Add ("25,22,19,10,7,4");	//13
		data.Add ("4,7,10,19,22,25");	//12
		data.Add ("27,26,25,24,23,22,21,20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2");	//11
		data.Add ("2,7,13,16,22,27");	//10
		data.Add ("27,22,16,13,7,2");	//9
		data.Add ("2,3,4,7,8,9,10,11,12,13,16,17,18,19,20,21,22,25,26,27");	//8
		data.Add ("25,22,19,10,7,4,4,7,10");	//7
		data.Add ("19,22,25");	//6
		data.Add ("27,26,25,24,23,22,19,18,17,16,13,12,11,10,7,6,5,4,3,2");	//5
		data.Add ("2,7,13,16,22,27");	//4
		data.Add ("27,22,16,13,7,2");	//3
		data.Add ("2,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27");	//2

		GameObject obj;
		pacdot.transform.position = new Vector3(2, 30, 0);	//先頭は座標変更のみ
		for (int i=0; i<data.Count; i++) {
			var xs = data [i].ToString().Split (',');
			for (int j=0; j<xs.Length; j++) {
				obj = (GameObject)Instantiate (pacdot, new Vector3 (float.Parse(xs [j]),30 - i, 0), Quaternion.identity);
				obj.name = pacdot.name;
				obj.transform.parent = this.transform;
			}
		}
	}
}
