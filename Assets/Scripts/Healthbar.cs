using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    [SerializeField]
    private PlayerBehavior player;
    private float currenTHealth, maxHealth;
    private Vector3 scale;
    [SerializeField]
    private GameObject healthBarSprite, healthBar;
    void Start()
    {
        currenTHealth = player.Health;
        maxHealth = player.maxHealth;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        currenTHealth = player.Health;
        maxHealth = player.maxHealth;
        scale = new Vector3(currenTHealth / maxHealth, 1, 1);
        healthBar.GetComponent<Transform>().localScale = scale;
        if (currenTHealth < maxHealth * .3)
        {
            healthBarSprite.GetComponent<SpriteRenderer>().color = Color.red;

        }
        else if (currenTHealth < maxHealth * .75)
        {
            healthBarSprite.GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        else
        {
            healthBarSprite.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (currenTHealth <= 0)
        {
            currenTHealth = 0;
        }
        
    }
}
