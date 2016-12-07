using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // Use this for initialization
    private int score=0;
    public bool Ground = true;
    private Rigidbody rb;
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
	    if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0,0,5*Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0, 0, -5 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));
        }
        if (Mathf.Abs(transform.position.y-0.3f)<0.01)
        {
            Ground = true;
        }
        Vector3 v = new Vector3(0.0f, 50.0f, 0.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Ground==true)
            {
                rb.AddForce(v*5);
                Ground = false;
            }

        }

    }
    
    void OnTriggerEnter(Collider c)
    {

        if (c.tag == "Bonus")
        {
            Destroy(c.gameObject);
            score+=1;
        }
    }
    public int getScore()
    {
        return score;
    }
}
