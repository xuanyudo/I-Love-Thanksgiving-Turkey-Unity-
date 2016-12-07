using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    // Use this for initialization
    public GameObject star;
    public AudioClip sound;
    public float vol=1;
    private AudioSource source;
	void Start () {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        InvokeRepeating("generateStar", 0.0f, 0.1f);
        source = GetComponent<AudioSource>();
        source.PlayOneShot(sound,vol);
    }
	
	// Update is called once per frame
	void Update () {
        

    }
    void generateStar()
    {
        Vector3 starposition = new Vector3(Random.Range(-10,10), Random.Range(0,50), Random.Range(-5,10));
        Object temp  = Instantiate(star, starposition, transform.rotation);
        Destroy(temp, 3.0f);
        
    }
}
