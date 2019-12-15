using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
	public Transform[] Waypoints;
    public float speed;
	public int curWayPoint;
	public bool doPatrol = true;
    public Vector3 Target;
	public Vector3 moveDirection;
	public Vector3 Velocity;

    void update()
	{
        if(curWayPoint < Waypoints.Length)
        {
		    Target = Waypoints[curWayPoint].position;
		    moveDirection = Target - transform.position;
		    Velocity = rigidbody.velocity;
		   if (moveDirection.magnitude < 1)
		   {
		        curWayPoint++;
		   }
		   else
		   {
		        Velocity = moveDirection.normalized * speed;
		   }
	    }
        else
		{
			if (doPatrol)
			{
				curWayPoint = 0;
			}
			else
			{
				Velocity = Vector3.zero;
			}
		}
		rigidbody.velocity = Velocity;
    }
}
