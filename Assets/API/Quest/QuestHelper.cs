using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class QuestData
{
    internal static List<Quest> InitQuests()
    {
        return new List<Quest>()
        {
            new Quest(1, QuestState.Active, "ErsteQuest", NpcOrItemToInteract.EnterHouse),
        };
    }
}

