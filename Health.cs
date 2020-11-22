using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;

    public int currentHealth;

    private Rigidbody2D rb;

    private Animator anim;

    public HealthBar healthBar;

    public ButtonVisible btnGameOver;

    public ButtonVisible btnRestart;

    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        anim = GetComponent<Animator>();
    }

    



    /* void Update()
     {
             if(Input.GetKeyDown(KeyCode.Space))

             {

                 TakeDamage(1);

             }

     }*/

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            FindObjectOfType<AudioManager>().Play("Caught");
            GetComponent<Movement>().enabled = false;
            anim.SetTrigger("IsCaught");
            Destroy(GameObject.FindGameObjectWithTag("Polizist"));
            btnGameOver.gameObject.SetActive(true);
            btnRestart.gameObject.SetActive(true);

        }

    }
}
