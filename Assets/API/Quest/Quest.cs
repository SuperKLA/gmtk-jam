using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Quest
{
    public Quest(int iD, QuestState state, string questText, Interactive interactable)
    {
        ID = iD;
        this.state = state;
        QuestText = questText;
        Interactive = interactable;
    }

    public readonly int ID;
    public QuestState state { set; get; }
    public readonly string QuestText;
    public readonly Interactive Interactive;
}
