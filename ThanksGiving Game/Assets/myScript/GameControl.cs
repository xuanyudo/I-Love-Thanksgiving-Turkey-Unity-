using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {
    public GameObject tileboard;
    private detectStar[] tiles;
    public GameObject star;
    public Text txt;
    public Player player;
    public GameObject cam;
    private Queue obs,skill;
    public AudioClip sound;
    public float vol = 0.5f;
    private AudioSource source;
    
    
	// Use this for initialization
	void Start () {
        tiles = tileboard.GetComponentsInChildren<detectStar>();
        obs = new Queue();
        skill = new Queue();
        txt.text = "Score: " + player.getScore() ;
        Renderer[] r = tileboard.GetComponentsInChildren<Renderer>();
        foreach (Renderer re in r)
        {
            re.material.SetColor("_TintColor", Color.blue);
        }
        source = GetComponent<AudioSource>();
        source.PlayOneShot(sound,vol);
        InvokeRepeating("generateStar", 2.0f, 0.1f);
        InvokeRepeating("reset", 4.0f, 0.1f);
        InvokeRepeating("generateBonus", 2.0f, 1.5f);
        InvokeRepeating("generateEven", 5.0f, 5.0f);
        InvokeRepeating("reset1", 7.5f, 5.0f);
    }
	
	// Update is called once per frame
	void Update () {
        txt.text = "Score: " + player.getScore();
        if (player.getScore()==52)
        {
            DestroyGame();
        }
    }
    void generateStar()
    {
        detectStar ob = tiles[Random.Range(0, 100)];
        obs.Enqueue(ob);
        ob.mark();
    }
    void generateEven()
    {
        int i = 0;
        int c = Random.Range(0,2);
        while(i <100)
        {
            if (i%2==c)
            {
                tiles[i].mark();
                skill.Enqueue(tiles[i]); 
            }
            i++;
        }
    }
    void DestroyGame()
    {
        foreach (detectStar dt in tiles)
        {
            dt.mark();
            skill.Enqueue(dt);
        }
    }
    void generateBonus()
    {
        tiles[Random.Range(0, 100)].make();
    }
    void reset()
    {

        detectStar dt = (detectStar)obs.Dequeue();
        dt.setActive();
    }
    void reset1()
    {
        foreach (detectStar dt in skill)
        {
            dt.setActive();
        }
    }
        
}
