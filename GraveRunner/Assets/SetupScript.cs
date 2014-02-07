using UnityEngine;
using System.Collections;

public class SetupScript : MonoBehaviour {

	public Transform CellPrefab;
	public Vector3 foobar;

	// Use this for initialization
	void Start () {	
		for (int i = 0; i < 5; i++) {
			Instantiate(CellPrefab, new Vector3(0, 0, i* CellPrefab.renderer.bounds.size.z), Quaternion.identity);
		}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
