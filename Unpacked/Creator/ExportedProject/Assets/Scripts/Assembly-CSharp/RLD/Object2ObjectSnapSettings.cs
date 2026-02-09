using System;
using UnityEngine;

namespace RLD
{
	[Serializable]
	public class Object2ObjectSnapSettings : Settings
	{
		[SerializeField]
		private int _snapDestinationLayers;

		[SerializeField]
		private bool _canClimbObjects;

		[SerializeField]
		private float _snapRadius;

		public int SnapDestinationLayers
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool CanClimbObjects
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float SnapRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
