using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public Sprite sprite;
    public Collider collider;
    public List<GameObject> route;
    public Vector3 position;
    public List<int> immunities;
    public int health;
    public float speed;

    public virtual void Move()
    {
    }
}
