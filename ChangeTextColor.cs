﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1
{
    class ChangeTextColor
    {
        public static void ChangeColor(RichTextBox rtx,int Start,byte Length=1)
        {
            rtx.SelectionAlignment = HorizontalAlignment.Left;
            rtx.SelectionStart = Start;
            rtx.SelectionLength = Length;
            rtx.SelectionColor = Color.Crimson;

        }
    }
}
