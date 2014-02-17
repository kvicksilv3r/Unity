using UnityEngine;
using System.Collections;

public class JumperScript : MonoBehaviour {

	public static float height;
	private bool canMove = true;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("w")) {

			iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("jumPath"), "time", 1));
				}

		if (Input.GetKeyDown("s")) {

			iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("divePath"), "time", 1));
		}

		height = transform.position.y;

	}
}
