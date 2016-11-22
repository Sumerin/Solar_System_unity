using UnityEngine;
using System;
using System.Collections;

public class test : MonoBehaviour {
    

    public GameObject[] s;

    public int identify;
    
    private Rigidbody me;
    



    public float v;

    private Vector3 r;

    Vector3 Scalar(Vector3 a,Vector3 b)
    {
        float x,y,z;

        x=(a.y*b.z)-(a.z*b.y);
        y=(-(a.x*b.z)+(a.z*b.x));
        z=(a.x*b.y)-(a.y*b.x);

        Vector3 temp = new Vector3(x, y, z);
        temp = temp / temp.magnitude;
        return temp;
    }
	// Use this for initialization
	void Start () {
        me = this.GetComponent<Rigidbody>();
        r = s[0].transform.position - this.transform.position;

        //me.AddForce(me.mass * v* Scalar(r, Vector3.up));
        me.velocity = v *Scalar(r, Vector3.up);
	}
	
	// Update is called once per frame
	void Update () {

        for(int i =0;i<1;i++)
        {
            if(i!=identify)
            {
                Vector3 t;
                //float v_1;
                t = s[i].transform.position - this.transform.position;
               // v_1 = Constant.instance.G * s[i].GetComponent<Rigidbody>().mass / t.magnitude;


                me.AddForce(Constant.instance.G * s[i].GetComponent<Rigidbody>().mass * me.mass / (t.magnitude * t.magnitude) * t / t.magnitude);
            }
        }
       /* r=s.transform.position-this.transform.position;
        v = Constant.instance.G * s.GetComponent<Rigidbody>().mass / r.magnitude;
     

        me.AddForce(Constant.instance.G * s.GetComponent<Rigidbody>().mass * me.mass / (r.magnitude * r.magnitude )* r / r.magnitude );

        //me.AddForce(me.mass * v  / r.magnitude * (-r) / r.magnitude);

       
       */
       

       
	}
}
