using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController characterController;
    [SerializeField]
    private float walkSpeed = 4f;
    private Vector3 velocity = default;

    /// <summary>
    /// �R���|�[�l���g�擾
    /// </summary>
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    /// <summary>
    /// �v���C���[�̈ړ�
    /// </summary>
    void Update()
    {
        //�R���C�_�[���n�ʂɂ��Ă��鎞�݈̂ړ��\
        if (characterController.isGrounded)
        {
            //�����l
            velocity = Vector3.zero;
            //���E�����L�[
            var input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            if (input.magnitude > 0f)
            {
                velocity = input.normalized * walkSpeed;
                //transform.LookAt(transform.position + input.normalized);
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(input.normalized), 6f * Time.deltaTime);
            }
            else
            {

            }
        }
        velocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}