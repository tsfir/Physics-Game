using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EditParameters : MonoBehaviour
{
    Rigidbody2D myRigidBody;
    [SerializeField] TextMeshProUGUI peMass;
    [SerializeField] TextMeshProUGUI peHeight;
    [SerializeField] TextMeshProUGUI peResults;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void start()
    {
        myRigidBody.gravityScale = 1;
    }

    public void HeightChange(string newFriction)
    {
        float userHeight = float.Parse(newFriction);
        float newPosition = userHeight * 9 - 6;
        transform.position  = new Vector3(transform.position.x, newPosition, transform.position.z);
        peHeight.text = newFriction;
        peResults.text = "= " + (9.8f * float.Parse(peMass.text) * float.Parse(peHeight.text)).ToString();
    }

    public void MassChange(string newMass)
    {
        myRigidBody.mass = float.Parse(newMass);
        peMass.text = newMass ;
        peResults.text = "= " + (9.8f * float.Parse(peMass.text) * float.Parse(peHeight.text)).ToString();
    }
}
