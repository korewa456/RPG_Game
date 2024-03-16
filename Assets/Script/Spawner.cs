using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{

    public GameObject AvatarPanelContainer;
    public GameObject AvatarPanelPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<CombatDataManager.Instance.PlayerEntities.Count; i++)
        {
            SpawnPanel(CombatDataManager.Instance.PlayerEntities[i]);
        }
    }


    void SpawnPanel(EntityInfo entity)
    {
        GameObject panelInstance = Instantiate(AvatarPanelPrefab);
        panelInstance.transform.SetParent(AvatarPanelContainer.transform, false);

        GameObject AvatarChildren = panelInstance.transform.Find("Avatar").gameObject;

        Image AvatarImageComponent = AvatarChildren.GetComponent<Image>();
        GameObject AvatarName = AvatarChildren.transform.Find("Name").gameObject;

        TMPro.TextMeshProUGUI CharacterName = AvatarName.GetComponent<TMPro.TextMeshProUGUI>();

        AvatarImageComponent.sprite = entity.Avatar;
        CharacterName.text = entity.Name;



    }
}
