using UnityEngine;
using System.Collections;

public class BlockMap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject obj;
		int count = this.transform.childCount;
		for (int i=0; i<count; i++) {
			GameObject child = this.transform.GetChild (i).gameObject;
			for (int j=1; j<13; j++) {
				float x = j*16 + child.transform.position.x;
				float y = child.transform.position.y;
				obj = (GameObject)Instantiate (child, new Vector3 (x, y, 0), Quaternion.identity);
				obj.name = child.name;
				obj.transform.parent = this.transform;
			}
		}
	}
}
