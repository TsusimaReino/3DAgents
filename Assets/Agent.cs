using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;//Using�f�B���N�e�B�u���w��
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Sensors.Reflection;

//public class Agent : MonoBehaviour
//{
//    public virtual void OnEpisodeBegin()
//    {

//    }
//    public virtual void CollectObservations(VectorSensor sensor)
//    {
//        //�Q�[���̕���T�C�Y�ɍ��킹�Đ��K�����ώ@�ɒǉ�����
//        sensor.AddObservations(target.localPosition / 15f);
//        sensor.AddObservations(targetform.localPosition / 15f);
//        //�v���C���[�̕������𐳋K�����ώ@�ɒǉ�����
//        var direction = (target.localPosition - transform.localPosition).normalized;
//        sensor.AddObservations(direction);
//    }
//    public virtual void OnActionReceived(float[] vectorAction)
//    {

//    }
//    public virtual void Heuristic(float[] actionsOut)
//    {

//    }
//}
