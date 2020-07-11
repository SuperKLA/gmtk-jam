using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class Dialogs
{

    public static Queue<DialogText> TestDialogListe
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("Space", "Hallo"),
                                                                         new DialogText("Other", "Ja Hi"),
                                                                         new DialogText("Space", "adksjf"),
                                                                         new DialogText("Other", "OK CIAO") });
        }
    }




    private static Queue<DialogText> CreateQueue(List<DialogText> list)
    {
        Queue<DialogText> queue = new Queue<DialogText>();
        foreach (var item in list)
            queue.Enqueue(item);
        return queue;
    }

}

