using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Particle : MonoBehaviour {

    // Use this for initialization

	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider c) {
        if (c.tag=="Tile") {
            Destroy(this.gameObject);
            c.gameObject.SetActive(false);
            c.gameObject.GetComponent<Renderer>().material.SetColor("_TintColor",Color.blue);
                
        }
        if (c.name=="Player")
        {
            SceneManager.LoadScene("Start");
        }
    }
}
