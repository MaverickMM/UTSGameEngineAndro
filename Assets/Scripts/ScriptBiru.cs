using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBiru : MonoBehaviour
{
    private Collider2D biru_collider;
    private Renderer biru_renderer;

    // Start is called before the first frame update
    void Start()
    {
        this.biru_renderer = GetComponent<Renderer>();
        this.biru_collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void handlekuningCollision() {
        ScoreManager.instance.MinPointk();

    }
    private void handlebiruCollision() {
        ScoreManager.instance.AddPointb();
        
    }

    private void handlemerahCollision() {
        ScoreManager.instance.MinPointm();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    switch (collision.gameObject.tag)
    {
        case "biru":
            Debug.Log("biru");
            this.handlebiruCollision();
            Destroy(collision.gameObject);
            break;

        case "merah":
            Debug.Log("merah");
            this.handlemerahCollision();
            Destroy(collision.gameObject);
            break;

        case "kuning":
            Debug.Log("kuning");
            this.handlekuningCollision();
            Destroy(collision.gameObject);
            break;
    }
    }
}