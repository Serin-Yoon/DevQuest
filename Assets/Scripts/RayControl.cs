using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayControl : MonoBehaviour
{
    Vector3 pos;
    Vector3 dir;
    GameObject player;
    GameObject bullet;
    GameObject aim;
    float force = 1;

    void Start()
    {
        player = GameObject.Find("Player");
        bullet = GameObject.Find("Bullet");
        aim = GameObject.Find("Aim");
    }

    void Update()
    {
        /* Need modification for VR
        if (Input.GetMouseButtonDown(0)) {
            pos = aim.transform.position;
            pos.z = GetComponent<Camera>().farClipPlane;
            dir = GetComponent<Camera>().ScreenToWorldPoint(pos);
            bullet = Instantiate(bullet, player.transform.position, player.transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(dir * force);
        }
        */
    }
}
