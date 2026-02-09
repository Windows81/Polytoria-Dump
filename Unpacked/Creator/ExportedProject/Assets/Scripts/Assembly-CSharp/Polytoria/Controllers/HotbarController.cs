using System.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	public class HotbarController : MonoBehaviour
	{
		public static HotbarController singleton;

		private RectTransform hotbarItem;

		private Dictionary<Tool, RectTransform> tools;

		private int toolIndex;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void ToolLinked(Tool tool, Instance parent)
		{
		}

		private void Update()
		{
		}

		private void EquipTool(Tool tool)
		{
		}
	}
}
