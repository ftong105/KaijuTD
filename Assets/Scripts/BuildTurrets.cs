using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTurrets : MonoBehaviour
{
    //private GameObject[] street;
    public GameObject pointing;
    private float buildRange = 10f;

    private GameObject turret;
    BuildManager buildManager;

    private int money;
    void Start()
    {
        //street = GameObject.FindGameObjectsWithTag("Street");
        buildManager = BuildManager.instance;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (GameManager.money >= 200)
            {
                buildManager.SetTurretToBuild(buildManager.t1Prefab);
                PointingToBuild();
                GameManager.money -= 200;
            }
            else
            {
                Debug.Log("Money less than 200");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (GameManager.money >= 300)
            {
                buildManager.SetTurretToBuild(buildManager.t2Prefab);
                PointingToBuild();
                GameManager.money -= 300;
            }
            else
            {
                Debug.Log("Money less than 300");
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            if (GameManager.money >= 450)
            {
                buildManager.SetTurretToBuild(buildManager.t3Prefab);
                PointingToBuild();
                GameManager.money -= 450;
            }
            else
            {
                Debug.Log("Money less than 450");
            }
        }
    }

    void PointingToBuild()
    {
        RaycastHit ray;

        if(Physics.Raycast(pointing.transform.position, pointing.transform.forward, out ray, buildRange))
        {
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
            turret = Instantiate(turretToBuild, ray.point, transform.rotation);
        }

        /*if (turret != null)
        {
            Debug.Log("cant build");
            return;
        }*/
    }
}
