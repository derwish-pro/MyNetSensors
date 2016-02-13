﻿/*  MyNetSensors 
    Copyright (C) 2015 Derwish <derwish.pro@gmail.com>
    License: http://www.gnu.org/licenses/gpl-3.0.txt  
*/

using System.Collections.Generic;
using System.Linq;

namespace MyNetSensors.Nodes
{
    public class UiTextBoxNode : UiNode
    {
        public string Value { get; set; }

        public UiTextBoxNode() : base("TextBox",0, 1)
        {
        }

        public override void Loop()
        {
        }

        public override void OnInputChange(Input input)
        {
        }

        public override bool SetValues(Dictionary<string, string> values)
        {
            Value = values.FirstOrDefault().Value;
            Outputs[0].Value = Value;

            UpdateMe();
            UpdateMeInDb();

            return true;
        }
    }
}