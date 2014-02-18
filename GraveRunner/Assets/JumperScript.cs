using UnityEngine;
using System.Collections;

public class JumperScript : MonoBehaviour {

	public static float height;
	private bool canMove = true;
	public float jumpTime = 3;
	public float diveTime = 3;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("w")) {

			iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("jumPath"), "time", jumpTime/(GlobalVariables.speed + 0.5f), "transition", "linear"));
				}

		if (Input.GetKeyDown("s")) {

			iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("divePath"), "time", diveTime/(GlobalVariables.speed + 0.5f)));
		}

		height = transform.position.y;

	}
}
