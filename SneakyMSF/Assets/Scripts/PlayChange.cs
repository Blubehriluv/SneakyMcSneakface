using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayChange : MonoBehaviour
{
    private BoxCollider2D bc;
    private Rigidbody2D rb;
    private SpriteRenderer rend;

    //public const string LAYER_NAME = "TopLayer";
    public int startOrder = 0;
    public int changeOrder = 7;
    //public int secondOrder = 3;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.sortingOrder = startOrder;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("TOUCHIN' THIS");
            ChangeButton();
        }
    }
    void ChangeButton()
    {
        sprite.sortingOrder = changeOrder;
        Invoke("ChangeAgain", 1);
    }

    public void ChangeAgain()
    {
        sprite.sortingOrder = startOrder;
        Invoke("ChangeScene", 1);
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("LevelOne");
    }
}