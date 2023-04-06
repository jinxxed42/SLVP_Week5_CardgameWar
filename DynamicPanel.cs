﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// THANK YOU CHATGPT!!!

namespace SLVP_Week5_CardgameWar
{
    public partial class DynamicPanel : Panel
    {
        private List<UserControl> _userControls = new List<UserControl>();

        public IEnumerable<UserControl> UserControls => _userControls;


        public DynamicPanel()
        {
            this.Size = new Size(100,100);
        }

        public void AddControl(UserControl userControl)
        {
            _userControls.Add(userControl);
            Controls.Add(userControl);
            UpdateLayout();
        }

        public void RemoveControl(UserControl userControl)
        {
            _userControls.Remove(userControl);
            Controls.Remove(userControl);
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            int yPos = 0;
            foreach (var control in _userControls)
            {
                control.Location = new Point(0, yPos);
                yPos += control.Height;
            }
            Height = yPos;
        }
    }
}
