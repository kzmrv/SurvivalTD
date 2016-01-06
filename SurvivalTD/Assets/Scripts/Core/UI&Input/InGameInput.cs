using UnityEngine;

namespace TD
{
    public class InGameInput : MonoBehaviour
    {
        private TowerBuilder towerBuilder;
        private GameObject towerBuildPanel;
        //private 
        void Start()
        {
            towerBuilder = this.GetComponent<TowerBuilder>();
            towerBuildPanel = GameObject.Find("TowerBuildPanel");
        }
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(towerBuilder.BuildTowerKey))
            {
                towerBuildPanel.SetActive(!towerBuildPanel.activeSelf);
            }
        }
    }
}

