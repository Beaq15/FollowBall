using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKPuppet : MonoBehaviour
{
    public Transform target;
    Animator anim;
    float weight = 1f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnAnimatorIK(int layerIndex)
    {
        anim.SetIKPosition(AvatarIKGoal.RightFoot, target.position);
        anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, weight);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            target.transform.Translate(0f, 0.1f, 0f);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            target.transform.Translate(0f, -0.1f, 0f);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            target.transform.Translate(0.1f, 0f, 0f);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            target.transform.Translate(-0.1f, 0f, 0f);
    }
}
