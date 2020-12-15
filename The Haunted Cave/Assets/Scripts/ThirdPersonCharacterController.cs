using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdPersonCharacterController : MonoBehaviour {
    public float Speed;

    //Recursos
    public float Health;
    public float Mana;

    public Slider HealthBar;
    public Slider ManaBar;

    void Update(){
        playerMovement();
    }
    void playerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        //MANA
        if (Input.GetKey("left shift") & Mana > 0f)
        {
            transform.Translate((hor * 1.02f) * Speed * Time.deltaTime, 0f, (ver * 1.02f) * Speed * Time.deltaTime, Space.Self);
            Mana = Mana - 5f * Time.deltaTime;
        }
        else if (Mana < 100f)
        {
            Mana = Mana + 20f * Time.deltaTime;
        }

        //HEALTH
        if (Input.GetKey("space"))
        {
            Health = Health - 10f * Time.deltaTime;
        }

        HealthBar.value = Health;
        ManaBar.value = Mana;

        if (Health <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(" Si detecta colision");
        //Enemigo chico
        if (collision.transform.tag == "Enemy1")
        {
            Health = Health - 5f;
        }

        //Enemigo grande
        if (collision.transform.tag == "Enemy2")
        {
            Health = Health - 20f;
        }
    }
}
