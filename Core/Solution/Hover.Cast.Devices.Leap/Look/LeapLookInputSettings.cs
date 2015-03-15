﻿using Hover.Cast.Devices.Leap.Touch;
using UnityEngine;

namespace Hover.Cast.Devices.Leap.Look {

	/*================================================================================================*/
	public class LeapLookInputSettings : LeapInputSettings {

		//TODO: hide the "Cursor Finger" setting
		//TODO: custom editor with a slider with range [0,1] for "Cursor Horizontal Offset"

		public Transform LeapTransform { get; set; }
		public Transform CameraTransform { get; set; }
		public float CursorHorizontalOffset { get; set; }

	}

}