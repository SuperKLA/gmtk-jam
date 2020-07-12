using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class Dialogs
{
    public static Akt currentAct = Akt.Akt1;

    #region Act 1
    public static Queue<DialogText> Dialog11
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("SPACE:", "Weird, the lights aren't working. Somethin's fishy!"),
                                                         new DialogText("SPACE:", "I bet CTRL is already looking into it. Maybe he could use some help.")});
        }
    }

    public static Queue<DialogText> Dialog12
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("SPACE:", "SHIFT! Are you okay? What happened?"),
                                                         new DialogText("SHIFT:","Someone attacked us! They looked like us but different! They <b>kiddnaped</b> CTRL!"),
                                                         new DialogText("SPACE:","What? Where did they take him?"),
                                                         new DialogText("SHIFT:","The <b>NUCLEAR POWER PLANT...</b> Check the <b>Terminal</b>!"),
            });
        }
    }

    public static Queue<DialogText> Dialog13
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("", ">>Booting"),
                                                         new DialogText("",">>Starting Central Town Recovery Locator (C-T-R-L) v1.17"),
                                                         new DialogText("",">>Initializing Key Buildings"),
                                                         new DialogText("",">>Connection established"),
                                                         new DialogText("",">>WARNING: Power Supply CRITICAL!"),
            });
        }
    }

    public static Queue<DialogText> Dialog14
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("SPACE:", "Hey N! Have you seen CTRL? Someone <b>kidnapped</b> him!"),
                                                         new DialogText("N:","What? Are you sure? Dang... we need to find him. But right now we have to get the power supply running before everything gets even more out of hand."),
                                                         new DialogText("SPACE:","Can I help you somehow?"),
                                                         new DialogText("N:","Apparently there was a shortcut within the system. Kinda' strage. Could you get me another <b>circuit board</b>?"),
                                                         new DialogText("N:","The SHOP has a new BFC3000 in stock. This would fix some our problems for now!"),
                                                         new DialogText("SPACE:","<b>BFC</b>?"),
                                                         new DialogText("N:","Don't ask, just go!"),
                                                         new DialogText("SPACE:","O-Key!"),
            });
        }
    }


    public static Queue<DialogText> Dialog15
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("S:", "What're ya buyin?"),
                                                         new DialogText("SPACE:","I need this <b>BFC3000</b> thingy."),
                                                         new DialogText("S:","A Big F-kin Circuit 3000? Ya won't be able to afford it. Ya're just an empty SPACE!"),
                                                         new DialogText("SPACE:","But N sent me to get it from you! We need to fix the <b>NUCLEAR POWER PLANT</b> and find CTRL."),
                                                         new DialogText("S:","Ah, CTRL is <b>gone</b>?... Hmm, O-Key. N and I talked about the <b>BFC</b> the other day. It seems the old circuit board was in a way worse state that N thought. Here ya go, mate."),
                                                         new DialogText("SPACE:","Wow! It's huge!"),
                                                         new DialogText("S:","Name says it all.")
            });
        }
    }

    public static Queue<DialogText> Dialog16
    {
        get
        {
            currentAct = Akt.Akt2;
            return CreateQueue(new List<DialogText>() {  new DialogText("N:", "Yo! Thanks! That's what we need!"),
                                                         new DialogText("N:","Weird. The old circuit isn't burned. It's missing a capacitor. This shouldn't have worked in the first place. Someone <b>manipulated</b> it...")


            });
        }
    }

    #endregion Act 1

    #region Act 2

    public static Queue<DialogText> Dialog21
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("SPACE:","Hey T! I've seen an alert. Something's wrong?"),
                                                         new DialogText("T:","Do you really bother? You are just one of these <b>characters with nothing to do</b>... I refuse to open up as long as people like <b>Y</b> are sitting here doing nothing."),
                                                         new DialogText("SPACE:","Why is <b>Y</b> not opening up its place?"),
                                                         new DialogText("T:","I don’t care! <b>If Y isn’t working, I’m not working!</b>"),
                                                         new DialogText("SPACE:","Hey <b>Y</b>, why are you here, drinking Tea at T’s place? Something’s wrong?"),
                                                         new DialogText("Y:","Y’s don’t work, that’s why!"),
                                                         new DialogText("SPACE:","But I’ve seen you working <b>yesterday.</b>"),
                                                         new DialogText("Y:","Of course! <b>Ys only work yesterdays!</b>"),
                                                         new DialogText("Y:","I checked my calendar at the <b>YACHT-SHOP</b>, it’s today.")
            });
        }
    }


    public static Queue<DialogText> Dialog22
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("","<i>Let's see what happens, if I change the date to yesterday?</i>"),
                                                         new DialogText("","<i>What's that? There is an entry in the calendar:</i>"),
                                                         new DialogText("","<i>“<b>Strange characters</b> doing stranger things at the <b>east border</b> of the city.”</i>"),

            });
        }
    }

    public static Queue<DialogText> Dialog23
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("Y:","I checked <b>my calendar at the YACHT-SHOP</b>, it’s today."),
                                                         new DialogText("SPACE:","You should check it again, it seems to be yesterday already.")
            });
        }
    }

    //Y muss raus laufen.

    public static Queue<DialogText> Dialog24
    {
        get
        {
            currentAct = Akt.Akt3;
            return CreateQueue(new List<DialogText>() {  new DialogText("T:","Well, it’s back to work then."),
            });
        }
    }
    #endregion Act 2

    #region Act 3   
    public static Queue<DialogText> Dialog31
    {
        get
        {
            
            return CreateQueue(new List<DialogText>() {  new DialogText("K:","Where is the <b>help</b> when you <b>need</b> it. I’m wasting my taxes here."),
            });
        }
    }

    public static Queue<DialogText> Dialog32
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("SPACE:","Hey K, what in keys name is happening here?"),
                                                         new DialogText("K:","Oh, a space bar wants to be a police officer? You only make things..."),
                                                         new DialogText("J:","What’s your problem?!"),
                                                         new DialogText("L:","I always receive the slowest and stupidest J’s from you!"),
                                                         new DialogText("J:","You should work too! Dang it, don’t suppress your employees! Your laziness is unbelievable!"),
                                                         new DialogText("L:","I never suppressed any key! You are such a jerk!"),
                                                         new DialogText("J:","Oh yeah? Am I? And you my sir, are a loser!"),
                                                         new DialogText("L:","It’s better than being a jackass like you!"),
                                                         new DialogText("J:","Do you kiss your mom with that mouth?"),
                                                         new DialogText("L:","Yo mama is just nothing but a mold!"),
                                                         new DialogText("L:","You stupid keys please STOOOP IT!!!"),
                                                         new DialogText("J:","Hey Space! You want to help? I’ve heard that the <b>Sheriff</b> is at the <b>ROADHOUSE</b> drinking. Dunno why, but maybe you can persuade him to <b>get his drunk ass over here</b>. And hurry up before they kill each other."),
            });
        }
    }

    public static Queue<DialogText> Dialog33
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("R:","You should really know when to stop. You R trashed!"),
                                                         new DialogText("P:","But it is the most important thing in my life!"),
                                                         new DialogText("SPACE:","What’s wrong officer?"),
                                                         new DialogText("R:","He is trashed."),
                                                         new DialogText("P:","<b>D-Dog</b>, my P-Dog <b>is acting strrrrange</b>. I took it to the vet yesterrrday <i>hic<i/> but the docs are clueless. I think it will never be the same again... or even worse."),
                                                         new DialogText("SPACE:","I need your help! The Keyboard is getting out of hand!"),
                                                         new DialogText("P:","<b>I won’t go anywhere without my P-Dog!</b>")
            });
        }
    }

    public static Queue<DialogText> Dialog34
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("SPACE:","Heyyy! Who’s a good key?"),
                                                         new DialogText("D-DOG:","I am not a key! I am dog! <b>Pet me!</b>"),
                                                         new DialogText("SPACE:","Oh pardon me... erm... O-key."),
                                                         new DialogText("D-DOG:","I feel like newborn! Gotta find P!")
                                                         //D-DOG haut ab
            });
        }
    }

    public static Queue<DialogText> Dialog35
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("P:","You helped my dog. We thank you a lot! Now, where are the baddies?"),
                                                         new DialogText("SPACE:","At Key’s, but we need to hurry!"),
                                                         new DialogText("P:","KK, let’s go!")
                                                         //P und D-DOG laufen nach osten aus dem Bild
            });
        }
    }

    public static Queue<DialogText> Dialog36
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("K:","I am glad you two came and helped!"),
                                                         new DialogText("D-DOG:","Three!"),
                                                         new DialogText("J:","L, I am sorry that I gave you just potheads. It will change in the future."),
                                                         new DialogText("L","And I will help them out more."),
                                                         new DialogText("SPACE:","Hey Sheriff, there is another problem!"),
                                                         new DialogText("P","Shoot."),
                                                         new DialogText("SPACE:","<b>CTRL is missing</b> and people have seen strange characters all over the city. Also the Power Plant has been sabotaged."),
                                                         new DialogText("P:","<b>The Numbers Gang...</b>"),
                                                         new DialogText("SPACE:","The who?"),
                                                         new DialogText("P:","No, not The Who. The Numbers Gang. The Who are gone for years. Don’t get fooled again."),
                                                         new DialogText("P:","There are three Numbers Gangs. Two up in the north and <b>one in the east</b> far beyond the arrows. The northern ones are at war with each other but the eastern gang is targeting us lately."),
                                                         new DialogText("P:","They probably kidnapped <b>CTRL</b> to throw us into chaos and take over the city. I have an idea <b>where we can find them</b>. We have to <b>enter... the point of no Return.</b>"),
                                                         new DialogText("P:","<b>Go to the east</b>, there is this old buiding with a -<b>DO NOT ENTER</b>- sign. We'll meet inside!."),
                                                         new DialogText("SPACE:","Got it!"),
            });
        }
    }
    #endregion Act 3

    #region IDLE
    public static Queue<DialogText> Idle_J
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("J:","I still hate him"),
            });
        }
    }
    public static Queue<DialogText> Idle_K
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("K:","Thanks for your help"),
            });
        }
    }
    public static Queue<DialogText> Idle_L
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("L:","He's still a dumbass!"),
            });
        }
    }
    public static Queue<DialogText> Idle_N
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("N:","Yo!"),
            });
        }
    }
    public static Queue<DialogText> Idle_P
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("P:","Justice always wins!"),
            });
        }
    }
    public static Queue<DialogText> Idle_D
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("D:","I sold our cat on craigslist!"),
            });
        }
    }
    public static Queue<DialogText> Idle_R
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("D:","TRASHED!"),
            });
        }
    }
    public static Queue<DialogText> Idle_T
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("T:","I won't move!"),
            });
        }
    }
    public static Queue<DialogText> Idle_S
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("S:","Ching Ching!"),
            });
        }
    }
    public static Queue<DialogText> Idle_Y
    {
        get
        {
            return CreateQueue(new List<DialogText>() {  new DialogText("Y:","Which year do we have?"),
            });
        }
    }
    #endregion IDLE
    

    private static Queue<DialogText> CreateQueue(List<DialogText> list)
    {
        Queue<DialogText> queue = new Queue<DialogText>();
        foreach (var item in list)
            queue.Enqueue(item);
        return queue;
    }

}

