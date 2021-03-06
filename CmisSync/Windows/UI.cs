//   CmisSync, a collaboration and sharing tool.
//   Copyright (C) 2010  Hylke Bons <hylkebons@gmail.com>
//
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with this program. If not, see <http://www.gnu.org/licenses/>.


using System;
using System.Windows.Forms;

namespace CmisSync {

    public class UI {

        public Setup Setup;
        public Bubbles Bubbles;
        public StatusIcon StatusIcon;
        public About About;


        public UI ()
        {   
			// FIXME: The second time windows are shown, the windows
			// don't have the smooth ease in animation, but appear abruptly.
			// The ease out animation always seems to work
            Setup      = new Setup ();
            About      = new About ();
            Bubbles    = new Bubbles ();
            //StatusIcon = new StatusIcon ();
            
            Program.Controller.UIHasLoaded ();
        }

        
        public void Run ()
        {
            Application.Run (StatusIcon = new StatusIcon ());
            StatusIcon.Dispose ();
        }
    }
}
