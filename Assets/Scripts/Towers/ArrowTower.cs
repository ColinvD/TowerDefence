using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTower : Tower
{
    private bool _preview;
    private Sprite _sprite;
    private Collider2D _collider;
    private CircleCollider2D _range;
    private Vector3 _position;
    private List<Upgrade> _leftSideUpgrades;
    private List<Upgrade> _rightSideUpgrades;
    private List<int> _specialty;

    // Start is called before the first frame update
    void Start()
    {
        preview = _preview;
        sprite = _sprite;
        collider = _collider;
        range = _range;
        position = _position;
        leftSideUpgrades = _leftSideUpgrades;
        rightSideUpgrades = _rightSideUpgrades;
        specialty = _specialty;
    }
}
