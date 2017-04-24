﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StitchNode : NodeBaseClass {

    public Stitch myStitch;

    public StitchNode(Rect r, int ID, Stitch stitch) : base(r,ID)
    {
        myStitch = stitch;
    }

    public override void DrawGUI(int winID)
    {
        BaseDraw();
    }

    public override void AttachComplete(NodeBaseClass winID)
    {
        base.linkedNodes.Add(winID);
    }
}
