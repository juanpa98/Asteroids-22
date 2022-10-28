using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    CircleCollider2D collider;
    SpriteRenderer sprite;
    public float speed = 200;
    public float rotationSpeed = -500;
    public GameObject bala;
    public GameObject bala2;
    public GameObject boquilla;
    public GameObject boquilla2;
    public GameObject ParticulasMuerte;
    bool muerto;

   


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        collider = GetComponent<CircleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();    

    }
    void Update()
    {
        if(muerto)
        { }
        else{ 
        float vertical = Input.GetAxis("Vertical");
        if (vertical > 0)
        {
            rb.AddForce(transform.up * vertical * speed * Time.deltaTime);
            anim.SetBool("Impulsing", true);
        }
        else
        {

            anim.SetBool("Impulsing", false);

        }
        float horizontal = Input.GetAxis("Horizontal");
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, horizontal * rotationSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            GameObject temp = Instantiate(bala, boquilla.transform.position, transform.rotation);
            Destroy(temp, 1.5f);

            GameObject temp2 = Instantiate(bala2, boquilla2.transform.position, transform.rotation);
            Destroy(temp, 1.5f);


        }

        }

    }
    public void Muerte()
    {

        GameObject temp = Instantiate(ParticulasMuerte, boquilla.transform.position, transform.rotation);
        Destroy(temp, 1.5f);
        
        GameManager.instance.vidas -= 1;
        transform.position = new Vector3(0, 0, 0);
        rb.velocity = new Vector2(0, 0);

        if (GameManager.instance.vidas <= 0)
        {
            Destroy(gameObject);

        }
        else
        {
        StartCoroutine(Respawn_Coroutine());

        }

    }

    IEnumerator Respawn_Coroutine()
    {
        muerto = true;
        collider.enabled = false;
        sprite.enabled = false;
        yield return new WaitForSeconds(1);
        collider.enabled = true;
        sprite.enabled = true;
       
        
        muerto = false;


    }

}