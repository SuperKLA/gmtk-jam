using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Quest
{
    public Quest(int iD, QuestState state, string questText, NpcOrItemToInteract NpcOrItem)
    {
        ID = iD;
        this.state = state;
        QuestText = questText;
        this.NpcOrItem = NpcOrItem;
    }

    public readonly int ID;
    public QuestState state { set; get; }
    public readonly string QuestText;
    public readonly NpcOrItemToInteract NpcOrItem;
}
