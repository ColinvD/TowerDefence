using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grunt : Enemy
{
    private Sprite _sprite;
    private Collider2D _collider;
    private List<GameObject> _route;
    private Vector3 _position;
    private List<int> _immunities;
    private int _health;
    private float _speed;

    void Start()
    {
        sprite = _sprite;
        collider = _collider;
        route = _route;
        position = _position;
        immunities = _immunities;
        health = _health;
        speed = _speed;
    }

    public override void Move()
    {
    }
}
