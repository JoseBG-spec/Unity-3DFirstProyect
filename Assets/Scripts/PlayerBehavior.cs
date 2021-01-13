using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private Vector3 initialPos;
    public int Health;
    public int maxHealth;
    [SerializeField]
    private Counter counter;
    void Start()
    {
        initialPos = new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (Health <= 0)
        {
            resetPos();
        }
    }
    public void resetPos()
    {
        GetComponent<Transform>().position = initialPos;
        Health = maxHealth;
    }
    public void Damage(int damage)
    {
        Health -= damage;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Chest")
        {
            collision.gameObject.GetComponent<ChestBehavior>().Open();
            counter.AddToCounter();

        }
    }
}
