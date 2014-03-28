using UnityEngine;
using System.Collections;

public class CosmeticScript : MonoBehaviour {

    public float z;
    public GameObject CellPrefab;
    public static Vector3 cellSize;
    float despawnPoint;
    float offset;
    public GameObject GravePrefab;
    public GameObject EyePrefab;
    public GameObject TreePrefab;
    public GameObject LampPrefab;
    public GameObject GhostPrefab;
    public GameObject LivingTreePrefab;
    public GameObject FencePrefab;

    public float left;
    public float right;

    public int thisCell;
    public int lastCell;

    
    public GameObject HangTreePrefab;

	// Use this for initialization
	void Start () {
	
        z = transform.position.z;
        
        despawnPoint = -CellPrefab.renderer.bounds.size.z;        
        cellSize = CellPrefab.renderer.bounds.size;
        despawnPoint = -renderer.bounds.size.z;
        left = -this.renderer.bounds.size.x/4;
        right = this.renderer.bounds.size.x * 1.25f;

	}
	
	// Update is called once per frame
	void Update () {

        z -= cellSize.z * Time.deltaTime * GlobalVariables.speed;
        
        transform.position = new Vector3 (0,0, z);
        
        if(z <= despawnPoint){
            
            offset = z - despawnPoint;
            
            z = 2*CellPrefab.renderer.bounds.size.z + offset;
	
	}
}
}