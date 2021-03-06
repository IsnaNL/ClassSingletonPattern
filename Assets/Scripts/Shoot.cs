﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public LayerMask SphereLayerMask;
    public ScoreHolder score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootRay();
        }
    }
    void FixedUpdate()
    {

        

    }

    private void ShootRay()
    {
        Debug.Log("Player clicked mouse0");
        RaycastHit hit;
        Ray forwardRay = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward);
        if (Physics.Raycast(forwardRay, out hit, 10, SphereLayerMask))
        {
            Debug.Log("Player hit");

            Destroy(hit.collider.gameObject);
            score.HitTarget();        
        }
    }
}