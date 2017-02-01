using UnityEngine;
using System.Collections;


public class EnemyDestroy : MonoBehaviour
{



    // Use this for initialization
    void Start()
    {
        //public PlayerHealth _PlayerHealth;
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.name == "FPSController")
        {
            //_PlayerHealth.PlayerHit();
            Destroy(gameObject);
        }
    }
}
