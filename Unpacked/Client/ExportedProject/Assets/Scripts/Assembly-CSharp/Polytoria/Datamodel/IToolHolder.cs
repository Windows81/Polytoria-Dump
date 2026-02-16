using UnityEngine;

namespace Polytoria.Datamodel
{
	public interface IToolHolder
	{
		Transform ToolAttachmentPoint { get; }

		void PlayAnim(string animationName);

		void PlayAnimTargetRpc(string animationName);
	}
}
