using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{

	private float attackLength = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackLength -= Time.deltaTime;
        if (attackLength <= 0)
        {
            gameObject.SetActive(false);
            attackLength = .5f;
        }
        
    }
	
private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}
