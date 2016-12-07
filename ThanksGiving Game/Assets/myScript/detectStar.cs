using UnityEngine;
using System.Collections;

public class detectStar : MonoBehaviour {
    public GameObject star;
    public GameObject bonus;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void setActive()
    {
        this.gameObject.SetActive(true);
    }
    public void mark()
    {
        Vector3 starposition = new Vector3(this.gameObject.transform.position.x, gameObject.transform.position.y + 10, gameObject.transform.position.z);
        Instantiate(star, starposition, transform.rotation);
        this.gameObject.GetComponent<Renderer>().material.SetColor("_TintColor", Color.red);
    }
    public void make()
    {
        Vector3 starposition = new Vector3(this.transform.position.x, transform.position.y + 0.5f, transform.position.z);
        Instantiate(bonus, starposition, transform.rotation);
        
    }
}
