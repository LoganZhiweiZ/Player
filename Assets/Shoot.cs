using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject BulletPrefab; //定义子弹预制体

    public Transform BulletSpawn; //定义一个公有类型的transform 用来实例化一个要跟随的对象

    public float BulletSpeed = 20; //定义一个子弹的速度
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Bullet = Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation) as GameObject;

            Bullet.GetComponent<Rigidbody>().velocity = Bullet.transform.forward * BulletSpeed;

            Destroy(Bullet, 2);
        }
    }
}
