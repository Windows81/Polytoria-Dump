using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace RLD
{
	public class RTPrefabPreviewButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		public delegate void HoverEnterHandler(RTPrefab prefab);

		public delegate void HoverExitHandler(RTPrefab prefab);

		private Text _text;

		private RTPrefab _prefab;

		public RTPrefab Prefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event HoverEnterHandler HoverEnter
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event HoverExitHandler HoverExit
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		private void OnEnable()
		{
		}
	}
}
