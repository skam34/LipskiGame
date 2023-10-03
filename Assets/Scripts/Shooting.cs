using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shotPoint;

    public float fireRate;
    private float timeBetweenShots;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenShots > 0)
        {
            timeBetweenShots -= Time.deltaTime;
        }
        if (timeBetweenShots <= 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                GameObject bulletClone = (GameObject)Instantiate(bulletPrefab, shotPoint.transform.position, shotPoint.transform.rotation);
                bulletClone.GetComponent<Bullet>().direction = 1;
                timeBetweenShots = fireRate;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                GameObject bulletClone = (GameObject)Instantiate(bulletPrefab, shotPoint.transform.position, shotPoint.transform.rotation);
                bulletClone.GetComponent<Bullet>().direction = 2;
                timeBetweenShots = fireRate;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                GameObject bulletClone = (GameObject)Instantiate(bulletPrefab, shotPoint.transform.position, shotPoint.transform.rotation);
                bulletClone.GetComponent<Bullet>().direction = 3;
                timeBetweenShots = fireRate;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                GameObject bulletClone = (GameObject)Instantiate(bulletPrefab, shotPoint.transform.position, shotPoint.transform.rotation);
                bulletClone.GetComponent<Bullet>().direction = 4;
                timeBetweenShots = fireRate;
            }
        }


        /*
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GameObject bulletClone = (GameObject)Instantiate(bulletPrefab, shotPoint.transform.position, shotPoint.transform.rotation);
            bulletClone.transform.localScale = transform.localScale;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GameObject bulletClone = (GameObject)Instantiate(bulletPrefab, shotPoint.transform.position, shotPoint.transform.rotation);
            bulletClone.transform.localScale = transform.localScale;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            GameObject bulletClone = (GameObject)Instantiate(bulletPrefab, shotPoint.transform.position, shotPoint.transform.rotation);
            bulletClone.transform.localScale = transform.localScale;
        }
        */

    }
}
