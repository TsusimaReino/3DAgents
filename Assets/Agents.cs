using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;//Using�f�B���N�e�B�u���w��
using Unity.MLAgents.Sensors;
using UnityEngine;
using Unity.MLAgents.Sensors.Reflection;

//public class ZombieAgent : Agent
//{
//    private CharacterController characterController;
//    private Animator animator;
//    //�@�ǂ�������^�[�Q�b�g
//    [SerializeField]
//    private Transform target;
//    // ����
//    [SerializeField]
//    [Observable]
//    private float walkSpeed = 2f;
//    //�@���x
//    private Vector3 velocity;

//    //���g�̃R���|�[�l���g�擾
//    private void Start()
//    {
//        characterController = GetComponent<CharacterController>();
//        animator = GetComponent<Animator>();
//    }
//    public override void OnEpisodeBegin()
//    {
//        Reset();
//    }
//    //�ώ@�̎��W
//    public override void CollectObservations(VectorSensor sensor)
//    {
//        //�Q�[���̕���T�C�Y�ɍ��킹�Đ��K�����ώ@�ɒǉ�����
//        sensor.AddObservations(target.localPosition / 15f);
//        sensor.AddObservations(targetform.localPosition / 15f);
//        //�v���C���[�̕������𐳋K�����ώ@�ɒǉ�����
//        var direction = (target.localPosition - transform.localPosition).normalized;
//        sensor.AddObservations(direction);
//    }


//    //�@�A�N�V�����̎󂯎��ƕ�V��^����
//    public override void OnActionReceived(float[] vectorAction)
//    {
//        //�@MaxStep�𕪕�ɂ���1�X�e�b�v���Ƀ}�C�i�X��V��^����
//        AddReward(-1f / MaxStep);
//        //�@�ړ��f�[�^�̍쐬
//        var input = new Vector3(vectorAction[0], 0f, vectorAction[1]);
//        //�@�L�����N�^�[���ڒn���Ă��鎞�����ړ�
//        if (characterController.isGrounded)
//        {
//            velocity = Vector3.zero;

//            if (input.magnitude > 0f)
//            {
//                //�@�L�����N�^�[�̌����͏��X�ɕς���
//                transform.rotation = Quaternion.Lerp(transform.localRotation, Quaternion.LookRotation(input.normalized, Vector3.up), 6f * Time.deltaTime);
//                velocity = transform.forward * walkSpeed;
//                animator.SetFloat("Speed", input.magnitude);
//            }
//            else
//            {
//                animator.SetFloat("Speed", 0f);
//            }
//        }
//        velocity.y += Physics.gravity.y * Time.deltaTime;
//        characterController.Move(velocity * Time.deltaTime);
//        //�@��l���Ǝ��g�i�G�j�̋�����1.8m���Z�����1�̕�V��^����
//        if (Vector3.Distance(target.localPosition, transform.localPosition) < 1.8f)
//        {
//            AddReward(1f);
//            EndEpisode();
//        }
//        //�@�Ȃ�炩�̉e����Floor����]�����ʒu��-5��艺�ɂȂ�����-0.1�̕�V��^����
//        if (transform.localPosition.y < -5f)
//        {
//            AddReward(-0.1f);
//            EndEpisode();
//        }
//    }

//    private void EndEpisode()
//    {
//        throw new System.NotImplementedException();
//    }

//    private void AddReward(object p)
//    {
//        throw new System.NotImplementedException();
//    }

//    //�@�f�[�^�̏��������\�b�h
//    public void Reset()
//    {
//        velocity = Vector3.zero;
//        characterController.enabled = false;
//        transform.localPosition = new Vector3(-2f, 1.5f, 0f);
//        characterController.enabled = true;

//        var targetCharacterController = GetComponent<CharacterController>();
//        targetCharacterController.enabled = false;
//        target.localPosition = new Vector3(Random.Range(-13f, 13f), 0f, Random.Range(-13f, 13f));
//        targetCharacterController.enabled = true;
//    }

//    //�@�����ő���
//    public override void Heuristic(float[] actionsOut)
//    {
//        actionsOut[0] = Input.GetAxis("Horizontal");
//        actionsOut[1] = Input.GetAxis("Vertical");
//    }


//}

