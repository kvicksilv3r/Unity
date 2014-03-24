using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CellScript : MonoBehaviour {

	public float z;
	public GameObject CellPrefab;
	public GameObject GravePrefab;
	public GameObject EyePrefab;
	public GameObject TreePrefab;
	public GameObject LampPrefab;
    public GameObject GhostPrefab;
    public GameObject LivingTreePrefab;
    public GameObject FencePrefab;
    public float leftLane;
    public float rightLane;
    public float close;
    public float far;
    public int thisCell;
    public int lastCell;

	public GameObject HangTreePrefab;

	public float speed = 0.75f;
	public static Vector3 cellSize;
	float despawnPoint;
	float offset;

	// Use this for initialization
	void Start () {
		z = transform.position.z;

		despawnPoint = -CellPrefab.renderer.bounds.size.z;

		cellSize = CellPrefab.renderer.bounds.size;
		despawnPoint = -cellSize.z;

        leftLane = GlobalVariables.leftLane;
        rightLane = GlobalVariables.rightLane;

        if(z > cellSize.z * 2){
            close = z - (float)(0.33f * cellSize.z);
            far = z + (float)(0.33f * cellSize.z);
            
            lastCell = GlobalVariables.lastCell;
            
            thisCell = Mathf.RoundToInt(Random.Range(0, 5));
            
            GlobalVariables.lastCell = thisCell;
            
            switch(thisCell){
                case 0:
                    Instantiate(LivingTreePrefab, new Vector3(leftLane, 0, close), LivingTreePrefab.transform.rotation);
                    Instantiate(HangTreePrefab, new Vector3(0, 0, close), Quaternion.Euler(0,180,0));
                    Instantiate(GravePrefab, new Vector3(rightLane, 0, close), Quaternion.identity);
                    
                    Instantiate(EyePrefab, new Vector3(leftLane, 0, far), Quaternion.identity);
                    Instantiate(GravePrefab, new Vector3(0, 0, far), Quaternion.identity);
                    Instantiate(LampPrefab, new Vector3(rightLane, 0, far), Quaternion.Euler(0,-90,0));
                    
                    break;
                    
                    
                case 1:
                    
                    Instantiate(GravePrefab, new Vector3(leftLane, 0, close), Quaternion.identity);
                    Instantiate(GhostPrefab, new Vector3(0, 0, close ), Quaternion.Euler(0,180,0));
                    Instantiate(GravePrefab, new Vector3(rightLane, 0, close), Quaternion.identity);
                    
                    Instantiate(HangTreePrefab, new Vector3(leftLane, 0, far), Quaternion.identity);
                    Instantiate(HangTreePrefab, new Vector3(rightLane, 0, far), Quaternion.identity);
                    
                    break;
                    
                case 2:
                    
                    Instantiate(GhostPrefab, new Vector3(leftLane, 0, close), Quaternion.Euler(0,180,0));
                    Instantiate(GravePrefab, new Vector3(0, 0, close ), Quaternion.identity);
                    Instantiate(GhostPrefab, new Vector3(rightLane, 0, close), Quaternion.Euler(0,180,0));

                    Instantiate(HangTreePrefab, new Vector3(0, 0, far), Quaternion.identity);
                    Instantiate(HangTreePrefab, new Vector3(0, 0, far), Quaternion.Euler(0,180,0));
                    
                    break;

                case 3:

                    Instantiate(GhostPrefab, new Vector3(leftLane / 2, 0, close), Quaternion.Euler(0,180,0));
                    Instantiate(LivingTreePrefab, new Vector3(rightLane, 0, close), LivingTreePrefab.transform.rotation);

                    Instantiate(LivingTreePrefab, new Vector3(leftLane, 0, far), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(0, 0, far), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(rightLane, 0, far), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(leftLane, 0, far + 0.1f * cellSize.z), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(rightLane, 0, far + 0.1f * cellSize.z), LivingTreePrefab.transform.rotation);

                    break;

                case 4:

                    Instantiate(HangTreePrefab, new Vector3(leftLane, 0, close), Quaternion.identity);
                    Instantiate(LivingTreePrefab, new Vector3(0, 0, close), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(rightLane, 0, close), LivingTreePrefab.transform.rotation);

                    Instantiate(FencePrefab, new Vector3(leftLane, 0, far), Quaternion.identity);
                    Instantiate(HangTreePrefab, new Vector3(rightLane, 0, far), Quaternion.identity);

                    break;
            }
        }

        /*
        Instantiate(LivingTreePrefab, new Vector3(0, 0, z), LivingTreePrefab.transform.rotation);
		
		//Instantiate(EyePrefab, new Vector3(6, 0, z), Quaternion.identity);
		//Instantiate(GravePrefab, new Vector3(-6, 0, z), Quaternion.identity);
		
		Instantiate(GravePrefab, new Vector3(
			GlobalVariables.rightLane, 0, z), Quaternion.identity);
		
        Instantiate(EyePrefab, new Vector3(
			GlobalVariables.leftLane, 0, z), Quaternion.identity);
   */         
	}

	// Update is called once per frame
	void Update () {


		z -= cellSize.z * Time.deltaTime * GlobalVariables.speed;

		transform.position = new Vector3 (0,0, z);

		if(z <= despawnPoint){

			offset = z - despawnPoint;

			z = 4*CellPrefab.renderer.bounds.size.z + offset;

            close = z - (float)(0.33f * cellSize.z);
            far = z + (float)(0.33f * cellSize.z);

            lastCell = GlobalVariables.lastCell;

            thisCell = Mathf.RoundToInt(Random.Range(0, 6));

            GlobalVariables.lastCell = thisCell;

            switch(thisCell){
                case 0:
                    Instantiate(LivingTreePrefab, new Vector3(leftLane, 0, close), LivingTreePrefab.transform.rotation);
                    Instantiate(HangTreePrefab, new Vector3(0, 0, close), Quaternion.Euler(0,180,0));
                    Instantiate(GravePrefab, new Vector3(rightLane, 0, close), Quaternion.identity);
                    
                    Instantiate(EyePrefab, new Vector3(leftLane, 0, far), Quaternion.identity);
                    Instantiate(GravePrefab, new Vector3(0, 0, far), Quaternion.identity);
                    Instantiate(LampPrefab, new Vector3(rightLane, 0, far), Quaternion.Euler(0,-90,0));
                    
                    break;
                    
                    
                case 1:
                    
                    Instantiate(GravePrefab, new Vector3(leftLane, 0, close), Quaternion.identity);
                    Instantiate(GhostPrefab, new Vector3(0, 0, close ), Quaternion.Euler(0,180,0));
                    Instantiate(GravePrefab, new Vector3(rightLane, 0, close), Quaternion.identity);
                    
                    Instantiate(HangTreePrefab, new Vector3(leftLane, 0, far), Quaternion.identity);
                    Instantiate(HangTreePrefab, new Vector3(rightLane, 0, far), Quaternion.identity);
                    
                    break;
                    
                case 2:
                    
                    Instantiate(GhostPrefab, new Vector3(leftLane, 0, close), Quaternion.Euler(0,180,0));
                    Instantiate(GravePrefab, new Vector3(0, 0, close ), Quaternion.identity);
                    Instantiate(GhostPrefab, new Vector3(rightLane, 0, close), Quaternion.Euler(0,180,0));
                    
                    Instantiate(HangTreePrefab, new Vector3(0, 0, far), Quaternion.identity);
                    Instantiate(HangTreePrefab, new Vector3(0, 0, far), Quaternion.Euler(0,180,0));
                    
                    break;
                    
                case 3:
                    
                    Instantiate(GhostPrefab, new Vector3(leftLane / 2, 0, close), Quaternion.Euler(0,180,0));
                    Instantiate(LivingTreePrefab, new Vector3(rightLane, 0, close), LivingTreePrefab.transform.rotation);
                    
                    Instantiate(LivingTreePrefab, new Vector3(leftLane, 0, far), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(0, 0, far), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(rightLane, 0, far), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(leftLane, 0, far + 0.1f * cellSize.z), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(rightLane, 0, far + 0.1f * cellSize.z), LivingTreePrefab.transform.rotation);
                    
                    break;
                    
                case 4:
                    
                    Instantiate(HangTreePrefab, new Vector3(leftLane, 0, close), Quaternion.identity);
                    Instantiate(LivingTreePrefab, new Vector3(0, 0, close), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(rightLane, 0, close), LivingTreePrefab.transform.rotation);
                    
                    Instantiate(GravePrefab, new Vector3(leftLane, 0, far), Quaternion.identity);
                    Instantiate(EyePrefab, new Vector3(0, 0, far), Quaternion.identity);
                    Instantiate(HangTreePrefab, new Vector3(rightLane, 0, far), Quaternion.identity);
                    
                    break;
                    
                case 5:
                    
                    Instantiate(LivingTreePrefab, new Vector3(leftLane, 0, close), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(0, 0, close), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(0, 0, z), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(rightLane, 0, z), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(leftLane, 0, far), LivingTreePrefab.transform.rotation);
                    Instantiate(LivingTreePrefab, new Vector3(leftLane, 0, far + 0.1f * cellSize.z), LivingTreePrefab.transform.rotation);
                    
                    break;
                    /*

			Instantiate(GravePrefab, new Vector3(0, 0, z), Quaternion.identity);

			//Instantiate(EyePrefab, new Vector3(6, 0, z), Quaternion.identity);
			//Instantiate(GravePrefab, new Vector3(-6, 0, z), Quaternion.identity);

			Instantiate(EyePrefab, new Vector3(
				(float)(transform.position.x + (0.25 * cellSize.x)), 0, z), Quaternion.identity);

			Instantiate(GravePrefab, new Vector3(
				(float)(transform.position.x - (0.25 * cellSize.x)), 0, z), Quaternion.identity);

			Instantiate(TreePrefab, new Vector3(
				(float)(transform.position.x + (0.5 * cellSize.x)), 0, z), Quaternion.identity);

			Instantiate(TreePrefab, new Vector3(
				(float)(transform.position.x - (0.5 * cellSize.x)), 0, z), Quaternion.identity);

                */

            }
		}

        if (Input.GetKeyDown("q"))
        {
            Instantiate(GhostPrefab, new Vector3(0,0,50), Quaternion.identity);
        }

	}
}
