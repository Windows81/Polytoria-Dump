using UnityEngine;

namespace Polytoria.Datamodel
{
	public class SkyBase : Instance
	{
		protected Material skyboxMaterial;

		protected override void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Apply()
		{
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
