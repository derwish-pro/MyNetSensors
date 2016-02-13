﻿/*  MyNetSensors 
    Copyright (C) 2015 Derwish <derwish.pro@gmail.com>
    License: http://www.gnu.org/licenses/gpl-3.0.txt  
*/

using System.Collections.Generic;

namespace MyNetSensors.Nodes
{
    public class UiSwitchNode : UiNode
    {
        public string Value { get; set; }

        public UiSwitchNode() : base("Switch", 0, 1)
        {
            Value = "0";
            Outputs[0].Value = Value;
        }

        public override void Loop()
        {
        }

        public override void OnInputChange(Input input)
        {
        }

        public override bool SetValues(Dictionary<string, string> values)
        {
            Value = Value == "0" ? "1" : "0";
            Outputs[0].Value = Value;

            UpdateMe();
            UpdateMeInDb();

            return true;
        }
    }
}