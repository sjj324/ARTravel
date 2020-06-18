using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject Canvas1;
    public GameObject Canvas2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitinfo = new RaycastHit();

            if (Physics.Raycast(ray, out hitinfo, 100, 1<<9))
            {
                Destroy(GameObject.Find("Sign_Left_Turn_Only"));
                //gameObject.GetComponent<Transform>().localPosition = new Vector3(0.195f, 0, -0.6f); n
                Canvas1.SetActive(true);
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitinfo = new RaycastHit();

            if (Physics.Raycast(ray, out hitinfo, 100, 1 << 10))
            {
                Destroy(GameObject.Find("Sign_Right_Turn_Only"));
                Canvas2.SetActive(true);
            }
        }
    }
}
