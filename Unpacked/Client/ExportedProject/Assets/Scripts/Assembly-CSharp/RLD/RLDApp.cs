using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace RLD
{
	public class RLDApp : MonoSingleton<RLDApp>, IRLDApplication
	{
		private Camera _renderCamera;

		private RenderPipelineId _renderPipelineId;

		[SerializeField]
		[HideInInspector]
		private DynamicConvertSettings _dynamicConvertSettings;

		public DynamicConvertSettings DynamicConvertSettings => null;

		public RenderPipelineId RenderPipelineId => default(RenderPipelineId);

		public Camera RenderCamera => null;

		public event RLDAppInitializedHandler Initialized
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

		private void OnSceneCanRenderCameraIcon(Camera camera, YesNoAnswer answer)
		{
		}

		private void OnCanCameraUseScrollWheel(YesNoAnswer answer)
		{
		}

		private void OnCanCameraProcessInput(YesNoAnswer answer)
		{
		}

		private void OnCanUndoRedo(UndoRedoOpType undoRedoOpType, YesNoAnswer answer)
		{
		}

		private void OnCanDoGizmoHoverUpdate(YesNoAnswer answer)
		{
		}

		private void OnCanObjectSelectionClickAndMultiSelectDeselect(YesNoAnswer answer)
		{
		}

		private void OnViewportsCameraAdded(Camera camera)
		{
		}

		private void OnViewportCameraRemoved(Camera camera)
		{
		}

		private void Start()
		{
		}

		private void DetectRenderPipeline()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnRenderObject()
		{
		}

		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}

		private void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
		}
	}
}
