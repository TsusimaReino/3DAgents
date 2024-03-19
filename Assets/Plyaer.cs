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
    /// コンポーネント取得
    /// </summary>
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    /// <summary>
    /// プレイヤーの移動
    /// </summary>
    void Update()
    {
        //コライダーが地面についている時のみ移動可能
        if (characterController.isGrounded)
        {
            //初期値
            velocity = Vector3.zero;
            //左右方向キー
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