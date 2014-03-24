using UnityEngine;
using System.Collections;

public class LivingTreeScript : MonoBehaviour {

    public float z;
    public float x;
    public float y;
    public GameObject CellPrefab;
    public float speed = 0.75f;
    float despawnPoint;
    
    // Use this for initialization
    void Start () {
        z = transform.position.z;
        x = transform.position.x;
        y = -5;
        despawnPoint = -CellPrefab.renderer.bounds.size.z;  
    }
    
    // Update is called once per frame
    void Update () {
        z -= CellPrefab.renderer.bounds.size.z * Time.deltaTime * GlobalVariables.speed;
        transform.position = new Vector3 (x, y, z);

        if (z < 65 && y <= 0)
        {
            y += 0.20f;
        }

        if(z <= despawnPoint){
            Destroy(gameObject);
        }
    }
}
