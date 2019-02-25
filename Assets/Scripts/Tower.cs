using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    public bool preview;
    public Sprite sprite;
    public Collider2D collider;
    public CircleCollider2D range;
    public Vector3 position;
    public List<Upgrade> leftSideUpgrades;
    public List<Upgrade> rightSideUpgrades;
    public List<int> specialty;
}
