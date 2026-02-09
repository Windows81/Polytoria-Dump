using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RLD
{
	public class RTGizmosEngine : MonoSingleton<RTGizmosEngine>, IHoverableSceneEntityContainer
	{
		[SerializeField]
		private EditorToolbar _mainToolbar;

		[SerializeField]
		private GizmoEngineSettings _settings;

		private GizmosEnginePipelineStage _pipelineStage;

		private Gizmo _draggedGizmo;

		private bool _justReleasedDrag;

		private Gizmo _hoveredGizmo;

		private GizmoHoverInfo _gizmoHoverInfo;

		private List<Gizmo> _gizmos;

		private List<ISceneGizmo> _sceneGizmos;

		private List<RTSceneGizmoCamera> _sceneGizmoCameras;

		private List<Camera> _renderCameras;

		[SerializeField]
		private SceneGizmoLookAndFeel _sharedSceneGizmoLookAndFeel;

		public GizmoEngineSettings Settings => null;

		public GizmosEnginePipelineStage PipelineStage => default(GizmosEnginePipelineStage);

		public Camera RenderStageCamera => null;

		public bool HasHoveredSceneEntity => false;

		public bool IsAnyGizmoHovered => false;

		public Gizmo HoveredGizmo => null;

		public Gizmo DraggedGizmo => null;

		public bool JustReleasedDrag => false;

		public int NumRenderCameras => 0;

		public SceneGizmoLookAndFeel SharedSceneGizmoLookAndFeel => null;

		public event GizmoEngineCanDoHoverUpdateHandler CanDoHoverUpdate
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

		public void AddRenderCamera(Camera camera)
		{
		}

		public bool IsRenderCamera(Camera camera)
		{
			return false;
		}

		public void RemoveRenderCamera(Camera camera)
		{
		}

		public RTSceneGizmoCamera CreateSceneGizmoCamera(Camera sceneCamera, ISceneGizmoCamViewportUpdater viewportUpdater)
		{
			return null;
		}

		public bool IsSceneGizmoCamera(Camera camera)
		{
			return false;
		}

		public ISceneGizmo GetSceneGizmoByCamera(Camera sceneCamera)
		{
			return null;
		}

		public Gizmo CreateGizmo()
		{
			return null;
		}

		public void RemoveGizmo(Gizmo gizmo)
		{
		}

		public SceneGizmo CreateSceneGizmo(Camera sceneCamera)
		{
			return null;
		}

		public MoveGizmo CreateMoveGizmo()
		{
			return null;
		}

		public ObjectTransformGizmo CreateObjectMoveGizmo()
		{
			return null;
		}

		public RotationGizmo CreateRotationGizmo()
		{
			return null;
		}

		public ObjectTransformGizmo CreateObjectRotationGizmo()
		{
			return null;
		}

		public ScaleGizmo CreateScaleGizmo()
		{
			return null;
		}

		public ObjectTransformGizmo CreateObjectScaleGizmo()
		{
			return null;
		}

		public UniversalGizmo CreateUniversalGizmo()
		{
			return null;
		}

		public ObjectTransformGizmo CreateObjectUniversalGizmo()
		{
			return null;
		}

		public BoxGizmo CreateBoxGizmo()
		{
			return null;
		}

		public BoxGizmo CreateObjectBoxScaleGizmo()
		{
			return null;
		}

		public ObjectExtrudeGizmo CreateObjectExtrudeGizmo()
		{
			return null;
		}

		public void Update_SystemCall()
		{
		}

		public GizmoHandleHoverData GetGizmoHandleHoverData(Gizmo gizmo)
		{
			return null;
		}

		public void Render_SystemCall(Camera renderCamera)
		{
		}

		private void SortHandleHoverDataCollection(List<GizmoHandleHoverData> hoverDataCollection, Vector3 inputDevicePos)
		{
		}

		private void RegisterGizmo(Gizmo gizmo)
		{
		}

		private void UnregisterGizmo(Gizmo gizmo)
		{
		}

		private void OnGUI()
		{
		}

		private void OnGizmoDragBegin(Gizmo gizmo, int handleId)
		{
		}

		private void OnGizmoDragEnd(Gizmo gizmo, int handleId)
		{
		}
	}
}
