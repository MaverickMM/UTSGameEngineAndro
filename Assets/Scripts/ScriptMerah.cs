using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMerah : MonoBehaviour
{
    private Collider2D merah_collider;
    private Renderer merah_renderer;

    // Start is called before the first frame update
    void Start()
    {
        this.merah_renderer = GetComponent<Renderer>();
        this.merah_collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void handlekuningCollision() {
        ScoreManager.instance.MinPointk();

    }
    private void handlebiruCollision() {
        ScoreManager.instance.MinPointb();
        
    }

    private void handlemerahCollision() {
        ScoreManager.instance.AddPointm();

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