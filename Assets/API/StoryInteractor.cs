using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum StoryInteractor
{
    //AKT 1 -----------------
    GAME_START, //11
    //Spieler übernimmt die Kontrolle
    CTRL_TOWER_SHIFT,//12
    //SHIFT weggeschafft wird von zwei H-Hospital -- TODO?
    TERMINAL_START,//13
    N_IFR_POWER_PLANT_FIRST_TIME,//14
    S_IN_SHOP_TALKT_TO,//15
    N_IFR_POWER_PLANT_SECOND_TIME,//16
    //AKT 2 -----------------
    T_IFR_WITH_Y,//21
    CALENDAR_AT_Y,//22
    Y_IFR_TEAHOUSE,//23
    //Y geht nach hause, T fängt an zu arbeiten -- TODO? die gehen ins Haus
    //AKT 3 -----------------
    K_IFR_P,//31
    //K geht vor und verschwindet nach süden aus dem Bild -- TODO? weglaufen lassen
    K_IFR_K_SHOP,//32
    R_TALK_TO_R_OR_P, //33
    D_IFR_VET,//34
    //D-Dog haut ab richtung Norden -- TODO? weglaufen
    P_IFR_BAR,//35
    //P und D laufen zu K-L-J -- TODO? dahin laufen lassen
    K_TALK_TO_K_D_J_L,//36
    ENTER_ENTER
    //ENDE?
}

