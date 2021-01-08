using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdPersonCharacterController : MonoBehaviour {
    public float Speed;

    //Recursos del jugador
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

        HealthBar.value = Health;
        ManaBar.value = Mana;

        //MANA
        if (Input.GetKey("left shift") & Mana > 0f)
        {
            transform.Translate((hor * 1.02f) * Speed * Time.deltaTime, 0f, (ver * 1.02f) * Speed * Time.deltaTime, Space.Self);
            Mana = Mana - 2.5f * Time.deltaTime;
        }
        else if (Mana < 100f)
        {
            Mana = Mana + 20f * Time.deltaTime;
        }

        //HEALTH
        if (Health <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy1")
        {
            Health = Health - 5f;
        }

        if (collision.transform.tag == "Enemy2")
        {
            Health = Health - 20f;
        }
    }
}