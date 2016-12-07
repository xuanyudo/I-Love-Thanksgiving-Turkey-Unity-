using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {
    public GameObject player;
    private float OffsetX,OffsetY,OffsetZ;
    
	// Use this for initialization
	void Start () {
        OffsetX = player.transform.position.x - transform.position.x;
        OffsetY = player.transform.position.y - transform.position.y;
        OffsetZ = player.transform.position.z - transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x - OffsetX,player.transform.position.y -OffsetY, player.transform.position.z-OffsetZ);
	}
}
