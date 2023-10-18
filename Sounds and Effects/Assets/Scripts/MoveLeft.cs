using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float _speed = 30f;
    private PlayerController _playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerControllerScript.GameOver == false)
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
    }
}
