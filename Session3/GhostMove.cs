using UnityEngine;
using System.Collections;

public class GhostMove : MonoBehaviour {
	public GameObject ghostWaypoints;

	Transform[] waypoints = null;
	int cur = 0;
	
	public float speed = 0.3f;

	// Use this for initialization
	void Start () {
		switch (this.name) {
		case "blinky":
			AddWaypointsBlinky ();
			break;
		case "clyde":
			AddWaypointsClyde ();
			break;
		case "inky":
			AddWaypointsInky ();
			break;
		case "pinky":
			AddWaypointsPinky ();
			break;
		}
	}

	void FixedUpdate () {
		// Waypoint not reached yet? then move closer
		if (transform.position != waypoints[cur].position) {
			Vector2 p = Vector2.MoveTowards(transform.position,
			                                waypoints[cur].position,
			                                speed);
			rigidbody2D.MovePosition(p);
		}
		// Waypoint reached, select next one
		else cur = (cur + 1) % waypoints.Length;
		
		// Animation
		Vector2 dir = waypoints[cur].position - transform.position;
		GetComponent<Animator>().SetFloat("DirX", dir.x);
		GetComponent<Animator>().SetFloat("DirY", dir.y);
	}
	
	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "pacman")
			Destroy(co.gameObject);
	}

	void AddWaypointsBlinky() {
		ArrayList data = new ArrayList ();
		data.Add (new Vector2 (15f, 20f));
		data.Add (new Vector2 (10f, 20f));
		data.Add (new Vector2 (10f, 14f));
		data.Add (new Vector2 (19f, 14f));
		data.Add (new Vector2 (19f, 11f));
		data.Add (new Vector2 (16f, 11f));
		data.Add (new Vector2 (16f, 8f));
		data.Add (new Vector2 (19f, 8f));
		data.Add (new Vector2 (19f, 5f));
		data.Add (new Vector2 (16f, 5f));
		data.Add (new Vector2 (16f, 2f));
		data.Add (new Vector2 (22f, 2f));
		data.Add (new Vector2 (22f, 11f));
		data.Add (new Vector2 (25f, 11f));
		data.Add (new Vector2 (25f, 14f));
		data.Add (new Vector2 (27f, 14f));
		data.Add (new Vector2 (27f, 20f));
		data.Add (new Vector2 (25f, 20f));
		data.Add (new Vector2 (25f, 23f));
		data.Add (new Vector2 (27f, 23f));
		data.Add (new Vector2 (27f, 26f));
		data.Add (new Vector2 (16f, 26f));
		data.Add (new Vector2 (16f, 30f));
		data.Add (new Vector2 (22f, 30f));
		data.Add (new Vector2 (22f, 20f));
		
		CreateWaypoints ("Blinky_Waypoint", data);
	}
	
	void AddWaypointsClyde() {
		ArrayList data = new ArrayList ();
		data.Add (new Vector2 (14f, 20f));
		data.Add (new Vector2 (13f, 20f));
		data.Add (new Vector2 (13f, 23f));
		data.Add (new Vector2 (10f, 23f));
		data.Add (new Vector2 (10f, 26f));
		data.Add (new Vector2 (13f, 26f));
		data.Add (new Vector2 (13f, 30f));
		data.Add (new Vector2 (7f, 30f));
		data.Add (new Vector2 (7f, 26f));
		data.Add (new Vector2 (2f, 26f));
		data.Add (new Vector2 (2f, 30f));
		data.Add (new Vector2 (7f, 30f));
		data.Add (new Vector2 (7f, 26f));
		data.Add (new Vector2 (13f, 26f));
		data.Add (new Vector2 (13f, 28f));
		data.Add (new Vector2 (16f, 28f));
		data.Add (new Vector2 (16f, 26f));
		data.Add (new Vector2 (22f, 26f));
		data.Add (new Vector2 (22f, 20f));
		data.Add (new Vector2 (7f, 20f));
		data.Add (new Vector2 (7f, 11f));
		data.Add (new Vector2 (2f, 11f));
		data.Add (new Vector2 (2f, 8f));
		data.Add (new Vector2 (4f, 8f));
		data.Add (new Vector2 (4f, 5f));
		data.Add (new Vector2 (7f, 5f));
		data.Add (new Vector2 (7f, 8f));
		data.Add (new Vector2 (13f, 8f));
		data.Add (new Vector2 (13f, 11f));
		data.Add (new Vector2 (10f, 11f));
		data.Add (new Vector2 (10f, 14f));
		data.Add (new Vector2 (19f, 14f));
		data.Add (new Vector2 (19f, 20f));
		
		CreateWaypoints ("Clyde_Waypoint", data);
	}
	
	void AddWaypointsInky() {
		ArrayList data = new ArrayList ();
		data.Add (new Vector2 (16f, 20f));
		data.Add (new Vector2 (19f, 20f));
		data.Add (new Vector2 (19f, 11f));
		data.Add (new Vector2 (27f, 11f));
		data.Add (new Vector2 (7f, 11f));
		data.Add (new Vector2 (7f, 5f));
		data.Add (new Vector2 (7f, 2f));
		data.Add (new Vector2 (2f, 2f));
		data.Add (new Vector2 (2f, 5f));
		data.Add (new Vector2 (7f, 4f));
		data.Add (new Vector2 (7f, 2f));
		data.Add (new Vector2 (13f, 2f));
		data.Add (new Vector2 (13f, 5f));
		data.Add (new Vector2 (10f, 5f));
		data.Add (new Vector2 (10f, 8f));
		data.Add (new Vector2 (13f, 8f));
		data.Add (new Vector2 (13f, 11f));
		data.Add (new Vector2 (4f, 11f));
		data.Add (new Vector2 (4f, 14f));
		data.Add (new Vector2 (2f, 14f));
		data.Add (new Vector2 (2f, 20f));
		data.Add (new Vector2 (4f, 20f));
		data.Add (new Vector2 (4f, 23f));
		data.Add (new Vector2 (7f, 23f));
		data.Add (new Vector2 (7f, 17f));
		data.Add (new Vector2 (2f, 17f));
		data.Add (new Vector2 (7f, 17f));
		data.Add (new Vector2 (7f, 26f));
		data.Add (new Vector2 (10f, 26f));
		data.Add (new Vector2 (10f, 23f));
		data.Add (new Vector2 (13f, 23f));
		data.Add (new Vector2 (13f, 20f));
		
		CreateWaypoints ("Inky_Waypoint", data);
	}
	
	void AddWaypointsPinky() {
		ArrayList data = new ArrayList ();
		data.Add (new Vector2 (13f, 20f));
		data.Add (new Vector2 (13f, 23f));
		data.Add (new Vector2 (10f, 23f));
		data.Add (new Vector2 (10f, 26f));
		data.Add (new Vector2 (13f, 26f));
		data.Add (new Vector2 (13f, 28f));
		data.Add (new Vector2 (16f, 28f));
		data.Add (new Vector2 (16f, 30f));
		data.Add (new Vector2 (22f, 30f));
		data.Add (new Vector2 (22f, 26f));
		data.Add (new Vector2 (16f, 26f));
		data.Add (new Vector2 (27f, 26f));
		data.Add (new Vector2 (27f, 30f));
		data.Add (new Vector2 (27f, 23f));
		data.Add (new Vector2 (22f, 23f));
		data.Add (new Vector2 (22f, 11f));
		data.Add (new Vector2 (16f, 11f));
		data.Add (new Vector2 (16f, 8f));
		data.Add (new Vector2 (22f, 8f));
		data.Add (new Vector2 (22f, 2f));
		data.Add (new Vector2 (22f, 5f));
		data.Add (new Vector2 (27f, 5f));
		data.Add (new Vector2 (27f, 2f));
		data.Add (new Vector2 (13f, 2f));
		data.Add (new Vector2 (13f, 5f));
		data.Add (new Vector2 (10f, 5f));
		data.Add (new Vector2 (10f, 8f));
		data.Add (new Vector2 (13f, 8f));
		data.Add (new Vector2 (13f, 11f));
		data.Add (new Vector2 (7f, 11f));
		data.Add (new Vector2 (7f, 20f));

		CreateWaypoints ("Pinky_Waypoint", data);
	}

	void CreateWaypoints(string name, ArrayList data) {
		GameObject obj;
		GameObject child = ghostWaypoints.transform.GetChild (0).gameObject;
		Vector2 dt = (Vector2)data[0];
		waypoints = new Transform[1];
		waypoints[0] = child.transform;
		waypoints[0].TransformPoint(new Vector3 (dt.x, dt.y, 0));
		System.Array.Resize (ref waypoints, data.Count);
		for (int i=1; i<data.Count; i++) {
			dt = (Vector2)data[i];
			obj = (GameObject)Instantiate (child, new Vector3 (dt.x, dt.y, 0), Quaternion.identity);
			obj.name = name + i.ToString();
			obj.transform.parent = ghostWaypoints.transform;
			waypoints[i] = obj.transform;
		}
	}
}
