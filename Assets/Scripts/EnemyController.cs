using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Gun gun;
    public float turnSpeed = 3;


    void Update()
    {

        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        Debug.Log(players.Length);
        if (players.Length == 0)
            return;

        GameObject target = players[0];

        this.transform.LookAt(target.transform.position);
        if (gun.isReadyToShoot())
            gun.Fire();

        //        GameObject target = GetClosestTarget(players);

        //        Vector3 dir = target.transform.position - this.transform.position;
        //        Quaternion targetQuaternion = Quaternion.LookRotation(dir);
        //
        //        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, targetQuaternion, turnSpeed * Time.deltaTime);
        //        float angle = Quaternion.Angle(this.transform.rotation, targetQuaternion);
        //
        //        if (Mathf.Abs(angle) < 0.5f && gun.isReadyToShoot())
        //            gun.Fire();
    }

    GameObject GetClosestTarget(GameObject[] players)
    {
        float minDist = float.MaxValue;
        GameObject closestTarget = players[0];
        foreach (GameObject target in players)
        {
            float dist = Vector3.Distance(target.transform.position, this.transform.position);
            if (dist < minDist)
            {
                minDist = dist;
                closestTarget = target;
            }
        }
        return closestTarget;
    }
}
