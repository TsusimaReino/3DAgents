using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;//Usingディレクティブを指定
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Sensors.Reflection;

//public class Agent : MonoBehaviour
//{
//    public virtual void OnEpisodeBegin()
//    {

//    }
//    public virtual void CollectObservations(VectorSensor sensor)
//    {
//        //ゲームの舞台サイズに合わせて正規化し観察に追加する
//        sensor.AddObservations(target.localPosition / 15f);
//        sensor.AddObservations(targetform.localPosition / 15f);
//        //プレイヤーの方向性を正規化し観察に追加する
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
