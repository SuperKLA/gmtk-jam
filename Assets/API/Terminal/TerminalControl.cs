using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalControl : MonoBehaviour
{
    public TerminalBuildingDisplay tbp;

    #region TerminalBuildings
    public TerminalBuilding A;
    public TerminalBuilding B;
    public TerminalBuilding C;
    public TerminalBuilding D;
    public TerminalBuilding E;
    public TerminalBuilding F;
    public TerminalBuilding G;
    public TerminalBuilding H;
    public TerminalBuilding I;
    public TerminalBuilding J;
    public TerminalBuilding K;
    public TerminalBuilding L;
    public TerminalBuilding M;
    public TerminalBuilding N;
    public TerminalBuilding O;
    public TerminalBuilding P;
    public TerminalBuilding Q;
    public TerminalBuilding R;
    public TerminalBuilding T;
    public TerminalBuilding S;
    public TerminalBuilding U;
    public TerminalBuilding V;
    public TerminalBuilding W;
    public TerminalBuilding X;
    public TerminalBuilding Y;
    public TerminalBuilding Z;
    public TerminalBuilding CTRL;
    public TerminalBuilding ALT;
    public TerminalBuilding SPACE;
    public TerminalBuilding ENTER;
    #endregion TerminalBuildings

    private void Start()
    {
        if (Dialogs.currentAct == Akt.Akt1)
            StartAct1();
        if (Dialogs.currentAct == Akt.Akt2)
            StartAct2();
        if (Dialogs.currentAct == Akt.Akt3)
            StartAct3();
    }
    public void StartAct1()
    {
        N.state = BuildingState.ALERT;
    }

    public void StartAct2()
    {
        N.state = BuildingState.OK;
        T.state = BuildingState.ALERT;
    }

    public void StartAct3()
    {
        T.state = BuildingState.OK;
        P.state = BuildingState.ALERT;
    }

    // Update is called once per frame
    void Update()
    {
        CheckBuildingKeys();
    }

    private void CheckBuildingKeys()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            tbp.SetNewTerminalBuilding(A);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            tbp.SetNewTerminalBuilding(B);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            tbp.SetNewTerminalBuilding(C);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            tbp.SetNewTerminalBuilding(D);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            tbp.SetNewTerminalBuilding(E);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            tbp.SetNewTerminalBuilding(F);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            tbp.SetNewTerminalBuilding(G);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            tbp.SetNewTerminalBuilding(H);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            tbp.SetNewTerminalBuilding(I);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            tbp.SetNewTerminalBuilding(J);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            tbp.SetNewTerminalBuilding(K);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            tbp.SetNewTerminalBuilding(L);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            tbp.SetNewTerminalBuilding(M);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            tbp.SetNewTerminalBuilding(N);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            tbp.SetNewTerminalBuilding(O);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            tbp.SetNewTerminalBuilding(P);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            tbp.SetNewTerminalBuilding(Q);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            tbp.SetNewTerminalBuilding(R);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            tbp.SetNewTerminalBuilding(T);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            tbp.SetNewTerminalBuilding(S);
        }

        else if (Input.GetKeyDown(KeyCode.U))
        {
            tbp.SetNewTerminalBuilding(U);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            tbp.SetNewTerminalBuilding(V);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            tbp.SetNewTerminalBuilding(W);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            tbp.SetNewTerminalBuilding(X);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            tbp.SetNewTerminalBuilding(Y);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            tbp.SetNewTerminalBuilding(Z);
        }
        else if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
        {
            tbp.SetNewTerminalBuilding(CTRL);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt))
        {
            tbp.SetNewTerminalBuilding(CTRL);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            TerminalManager.Current.ShowOrCloseTerminal(false);
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            tbp.SetNewTerminalBuilding(ENTER);
        }
    }

}
