using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject BulletPrefab; //�����ӵ�Ԥ����

    public Transform BulletSpawn; //����һ���������͵�transform ����ʵ����һ��Ҫ����Ķ���

    public float BulletSpeed = 20; //����һ���ӵ����ٶ�
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
