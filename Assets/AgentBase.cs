using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// AgentBlue, AgentRed, AgentGreen�̊��N���X
/// </summary>
//public class AgentBase : Agent
//{
//    [SerializeField]
//    protected float angularVelocityCoefficient = 1f; //���g�̊p���x
//    [SerializeField]
//    protected float velocityCoefficient = 1f; //���g�̑��x
//    public Transform stage; //�G�[�W�F���g���ړ����镽�ʂ̃X�e�[�W
//    [SerializeField]
//    protected List<Transform> otherAgents; //���g�ȊO�̃G�[�W�F���g
//    [SerializeField]
//    protected Rigidbody selfRidigBody; //���g��Rigidbody
//    [SerializeField]
//    float top = 12f; //���g�̊J�n�ʒu��z���W�̍ő�l
//    [SerializeField]
//    float right = 12f; //���g�̊J�n�ʒu��x���W�̍ő�l
//    [SerializeField]
//    float bottom = -12f; //���g�̊J�n�ʒu��z���W�̍ŏ��l
//    [SerializeField]
//    float left = -12f; //���g�̊J�n�ʒu��x���W�̍ŏ��l
//    [SerializeField]
//    float minDistanceBetweenOtherAgentsAtStart = 5f; //���g�Ƒ��̃G�[�W�F���g�Ƃ̊Ԃ̊J�n�ʒu�̍ŏ�����
//    protected bool hasTouchedDemon = false; //���g�̋S�ɕ߂܂���?
//    protected bool hasTouchedChild = false; //���g�̎q��߂܂���?

//    //���G�[�W�F���g�ƈ�苗�����ꂽ�X�e�[�W��̃����_���Ȉʒu���擾���܂�
//    protected Vector3 GetStartPosition(List<Transform> _otherAgents, Transform _stage)
//    {
//        var pos = new Vector3();
//        var stagePos = _stage.position;
//        while (true)
//        {
//            var hasDetect = true;
//            pos = stagePos + new Vector3(Random.Range(left, right), 0.5f, Random.Range(bottom, top));
//            foreach (var tr in _otherAgents)
//            {
//                if ((tr.position - pos).sqrMagnitude < minDistanceBetweenOtherAgentsAtStart)
//                {
//                    hasDetect = false;
//                    break;
//                }
//            }
//            if (hasDetect)
//            {
//                break;
//            }
//        }
//        return pos;

//    }
//    //�X�e�[�W�����t�߂̃����_���Ȉʒu���擾���܂�
//    protected Vector3 GetLookAtTargetPositionAtStart(Transform _stage)
//    {
//        var dx = Random.Range(-3f, 3f);
//        var dz = Random.Range(-3f, 3f);
//        var pos = new Vector3(_stage.position.x + dx, 0.5f, _stage.position.z + dz);
//        return pos;
//    }
//    //public override void OnEpisodeBegin()
//    //{
//    //    hasTouchedChild = false;
//    //    hasTouchedDemon = false;
//    //    transform.position = GetStartPosition(otherAgents, stage);
//    //    var pos = GetLookAtTargetPositionAtStart(stage);
//    //    transform.LookAt(pos);
//    //}
//}
