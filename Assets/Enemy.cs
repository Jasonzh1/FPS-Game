using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Renderer renderer;
    float timeSinceHit;
    Color originalColor;
    public int health;
    public GameObject deathParticles;
    


    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.GetColor("_Color");
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void OnHit(){
        Debug.Log("Enemy Hit");
        health -= 40;
        if(health <= 0){
            Destroy(gameObject);
            FindObjectOfType<GameMan>().point += 1;
            Instantiate(deathParticles, transform.position, Quaternion.identity);
        }
        StartCoroutine(ChangeColor());        
    }

    private IEnumerator ChangeColor(){
        renderer.material.SetColor("_Color", Color.red);
        yield return new WaitForSeconds(0.5f);
        renderer.material.SetColor("_Color", originalColor);
    }
}
