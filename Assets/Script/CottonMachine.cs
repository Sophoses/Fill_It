using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CottonMachine : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 1.0f;

    public enum MachineState { idle, down, pushing, up };
    public MachineState machineState = MachineState.idle;

    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        StartCoroutine(this.CheckMachineState());
        StartCoroutine(this.MachineAction());
    }

    void Update()
    {
        animator.speed = moveSpeed;

        if (Input.GetMouseButton(0))
        {
            animator.SetBool("IsUp", false);
            animator.SetBool("IsDown", true);
            animator.SetBool("IsDown", false);
            animator.SetBool("IsPushing", true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("IsPushing", false);
            animator.SetBool("IsUp", true);
        }
    }

    IEnumerator CheckMachineState()
    {
        yield return new WaitForSeconds(0.1f);

    }

    IEnumerator MachineAction()
    {

        switch (machineState)
            {
                case MachineState.idle:
                    animator.SetBool("IsRolling", false);
                    break;
                case MachineState.down:
                    animator.SetBool("IsRolling", true);
                    break;
            }
            yield return null;
    }

}
