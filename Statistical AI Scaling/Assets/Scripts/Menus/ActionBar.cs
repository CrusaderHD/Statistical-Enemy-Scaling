using UnityEngine;

public class ActionBar : MonoBehaviour
{
    public GameObject talentTree;
    public bool isTTreeOpen = false;

    public void Update()
    {
        TalentTreeHandler();
    }

    public void TalentTreeHandler()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (!isTTreeOpen)
            {
                OpenTalentTree();
            }
            else
            {
                CloseTalentTree();
            }
        }
    }

    public void OpenTalentTree()
    {
        talentTree.SetActive(true);
        isTTreeOpen = true;
    }

    public void CloseTalentTree()
    {
        talentTree.SetActive(false);
        isTTreeOpen = false;
    }

}
