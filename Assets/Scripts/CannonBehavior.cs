using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float repeatTime;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform position;
    [SerializeField]
    private float speed;
    void Start()
    {
        InvokeRepeating("SpawnCannonBalls", 0,repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnCannonBalls()
    {
        Rigidbody bulletPref;
        bulletPref= Instantiate(bullet, position).GetComponent<Rigidbody>();
        bulletPref.AddForce(position.forward * 100 * speed);
    }
}
