using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class GizmoEngineSettings : Settings
	{
		[SerializeField]
		private bool _enableGizmoSorting;

		public bool EnableGizmoSorting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}
}
