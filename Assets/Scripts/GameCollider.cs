using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameCollider : MonoBehaviour
{

 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            ScoreManager.instance.Addpoint();
        Destroy(gameObject);

    }
}
