using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private List<Quest> quests = new List<Quest>();

    #region Init
    void Awake()
    {
        quests = QuestData.InitQuests();
    }
    #endregion Init

    public List<Quest> GetAllQuestsDone()
    {
        return quests.FindAll(q => q.state == QuestState.Done);
    }

    public Quest GetActiveQuest()
    {
        return quests.Find(q => q.state == QuestState.Active);
    }
}
