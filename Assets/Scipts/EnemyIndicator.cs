using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIndicator : MonoBehaviour
{
    // variables so that we can put the indicator between the player and the enemy objects 
    public GameObject Indicator;
    public GameObject Target;

    // variable to check if the enemy object is visible in the camera or not 
    Renderer rd; 

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // if you can't see the enemy 
        if (rd.isVisible == false)
        {
            // and the indicator is off
            if (Indicator.activeSelf == false)
            {
                Indicator.SetActive(true);
            }

            Vector3 direction = Target.transform.position - transform.position;

            RaycastHit2D ray = Physics2D.Raycast(transform.position, direction);

            // if the raycast is hitting something 
            if (ray.collider != null)
            {
                Indicator.transform.position = ray.point;
            }
        }
        else
        {
            // and the indicator is off
            if (Indicator.activeSelf == true)
            {
                Indicator.SetActive(false);
            }
        }
    }
}
