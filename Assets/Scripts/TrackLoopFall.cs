using UnityEngine;
using System.Collections;

public class TrackLoopFall : MonoBehaviour {

    private GameObject inst, CubeCol;

    private Rigidbody[] allRigid;

    private bool fallTrack, updatePart;
    private int countFallParts;

	// Use this for initialization
	void Start () {
        GameObject temp = this.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        allRigid = new Rigidbody[16];

        inst = temp.transform.GetChild(120).gameObject;
        allRigid[0] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(121).gameObject;
        allRigid[1] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(122).gameObject;
        allRigid[2] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(123).gameObject;
        allRigid[3] = inst.GetComponent<Rigidbody>();

        inst = temp.transform.GetChild(85).gameObject;
        allRigid[4] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(86).gameObject;
        allRigid[5] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(87).gameObject;
        allRigid[6] = inst.GetComponent<Rigidbody>();

        inst = temp.transform.GetChild(88).gameObject;
        allRigid[7] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(89).gameObject;
        allRigid[8] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(90).gameObject;
        allRigid[9] = inst.GetComponent<Rigidbody>();

        inst = temp.transform.GetChild(78).gameObject;
        allRigid[10] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(79).gameObject;
        allRigid[11] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(80).gameObject;
        allRigid[12] = inst.GetComponent<Rigidbody>();

        inst = temp.transform.GetChild(81).gameObject;
        allRigid[13] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(82).gameObject;
        allRigid[14] = inst.GetComponent<Rigidbody>();
        inst = temp.transform.GetChild(83).gameObject;
        allRigid[15] = inst.GetComponent<Rigidbody>();

        fallTrack = false;
        updatePart = true;
        countFallParts = 0;

        // Collision with cart to know when to destroy bridge
        CubeCol = this.transform.GetChild(2).gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        if (CubeCol.GetComponent<CollideTrack>().hasCollided && !fallTrack)
        {
            fallTrack = true;
            CubeCol.GetComponent<CollideTrack>().hasCollided = false;
        }

        if (fallTrack)
        {
            if (countFallParts < allRigid.Length)
            {
                if(updatePart)
                    StartCoroutine(DestroyTrack());
            }
            else
            {
                countFallParts = 0;
                fallTrack = false;
            }
        }
	}

    IEnumerator DestroyTrack()
    {
        updatePart = false;
        allRigid[countFallParts].constraints = RigidbodyConstraints.None;
        allRigid[countFallParts].useGravity = true;
        if(countFallParts > 3)
        {
            allRigid[countFallParts].angularDrag = 30.0f;
        }
        ++countFallParts;
        yield return new WaitForSeconds(0.2f);
        updatePart = true;
    }
}
