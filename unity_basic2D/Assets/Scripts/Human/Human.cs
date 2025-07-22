using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [System.Serializable]
    public struct HumanBoneConfiguration
    {
        public string boneName;
        public Color color;
        public int sortingOrder;
    }


    [SerializeField] private HumanBone[] allBones;

    [SerializeField] private Arm[] arm;
    private Leg[] leg;
    private Body body;
    private Head head;

    [SerializeField] private HumanBoneConfiguration[] boneConfigurations;
    [SerializeField] private Color legColor;
    [SerializeField] private int legSortingOrder = 10;

    // Start is called before the first frame update
    void Start()
    {
        // 자기자신으로 부터 자식을 검색해서 가장 먼저 발견한 컴포넌트를 반환한다.

        allBones = GetComponentsInChildren<HumanBone>();

        arm = GetComponentsInChildren<Arm>();
        leg = GetComponentsInChildren<Leg>();
        body = GetComponentInChildren<Body>();
        head = GetComponentInChildren<Head>();

        for(int i=0; i<leg.Length;i++)
        {
            leg[i].SetRenderProperty(legColor, legSortingOrder);
        }
    }   
}
