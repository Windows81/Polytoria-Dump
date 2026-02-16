using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Battlehub.UIControls;
using HSVPicker;
using Mirror;
using Polytoria.Creator.PropertyGrid;
using Polytoria.Datamodel;
using RLD;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	public class CreatorController : NetworkBehaviour
	{
		public enum PaintType
		{
			None = 0,
			Color = 1,
			Material = 2
		}

		private struct ThumbnailImageTarget
		{
			public string Url { get; set; }

			public Image Target { get; set; }
		}

		[CompilerGenerated]
		private sealed class _003CAutoSaveLoop_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CreatorController _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CAutoSaveLoop_003Ed__85(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCheckToken_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CreatorController _003C_003E4__this;

			private UnityWebRequest _003Cuwr_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCheckToken_003Ed__50(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoPublish_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CreatorController _003C_003E4__this;

			private UnityWebRequest _003Cuwr_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoPublish_003Ed__74(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDoPublishModel_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CreatorController _003C_003E4__this;

			private List<Instance>.Enumerator _003C_003E7__wrap1;

			private UnityWebRequest _003Cuwr_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDoPublishModel_003Ed__62(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadMapFromFile_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CreatorController _003C_003E4__this;

			public string path;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadMapFromFile_003Ed__87(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadStarterPlaces_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CreatorController _003C_003E4__this;

			private List<ThumbnailImageTarget> _003Cimages_003E5__2;

			private RectTransform _003Ctemplate_003E5__3;

			private UnityWebRequest _003Cuwr_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadStarterPlaces_003Ed__68(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadThumbnailImage_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string src;

			public Image target;

			private UnityWebRequest _003Ctwr_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadThumbnailImage_003Ed__77(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadThumbnailImages_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public List<ThumbnailImageTarget> thumbnails;

			private List<ThumbnailImageTarget>.Enumerator _003C_003E7__wrap1;

			private Image _003Ctarget_003E5__3;

			private UnityWebRequest _003Ctwr_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLoadThumbnailImages_003Ed__75(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPublishLevelToID_003Ed__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CreatorController _003C_003E4__this;

			public int id;

			private UnityWebRequest _003Cuwr_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPublishLevelToID_003Ed__81(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowExportGLTFDialog_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowExportGLTFDialog_003Ed__59(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowExportModelDialog_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowExportModelDialog_003Ed__56(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowImportModelDialog_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowImportModelDialog_003Ed__64(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowOpenDialog_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowOpenDialog_003Ed__84(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowSaveDialog_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowSaveDialog_003Ed__89(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private string testCreatorToken;

		public static CreatorController singleton;

		public static bool IsCreator;

		public static string externalScriptFolder;

		private static System.Random random;

		public VirtualizingTreeView TreeView;

		public CreatorPropertyGrid PropertyGrid;

		public Image[] activateButtons;

		public ColorPicker colorPicker;

		public Image[] colorDisplay;

		public Canvas canvas;

		public RectTransform landing;

		public RectTransform materialSelector;

		public RectTransform publishModal;

		public RectTransform contextMenu;

		public ColorPicker propertyColorPicker;

		public TMP_Text statusBar;

		public GameObject confirmExit;

		private float moveSnap;

		private float rotateSnap;

		private bool moveSnapEnabled;

		private bool rotateSnapEnabled;

		public float autoSaveInterval;

		private PaintType paintType;

		private Color defaultButtonClr;

		private Dictionary<string, BaseScript> externalScriptFiles;

		private FileSystemWatcher watcher;

		private Color paintColor;

		private PartMaterial paintMaterial;

		private int userID;

		private int gameID;

		private static string saveLocation;

		private Vector3 mouseDownPosition;

		private List<Instance> selectionQueue;

		public string CreatorToken { get; private set; }

		private static bool WantsToQuit()
		{
			return false;
		}

		public void PromptExit()
		{
		}

		public void DoExit()
		{
		}

		private void Awake()
		{
		}

		private void OnPostDragEnd(Gizmo gizmo, int handleId)
		{
		}

		private void PropertyGrid_ValueChanged(object obj, PropertyInfo propertyInfo)
		{
		}

		private void GameLoaded()
		{
		}

		private void OnAppInitialized()
		{
		}

		private void Start()
		{
		}

		public void DeleteSelection()
		{
		}

		public void DuplicateSelection()
		{
		}

		public void SetStatusBarMessage(string message)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckToken_003Ed__50))]
		private IEnumerator CheckToken()
		{
			return null;
		}

		private Dictionary<string, string> GetCommandLineArgs()
		{
			return null;
		}

		private void RelaunchCreator()
		{
		}

		public void GroupSelection()
		{
		}

		public void UngroupSelection()
		{
		}

		public void ExportModel()
		{
		}

		[IteratorStateMachine(typeof(_003CShowExportModelDialog_003Ed__56))]
		private IEnumerator ShowExportModelDialog()
		{
			return null;
		}

		private static void DoExportModel(string path)
		{
		}

		public void ExportGLTF()
		{
		}

		[IteratorStateMachine(typeof(_003CShowExportGLTFDialog_003Ed__59))]
		private IEnumerator ShowExportGLTFDialog()
		{
			return null;
		}

		private static void DoExportGLTF(string path)
		{
		}

		public void PublishModel()
		{
		}

		[IteratorStateMachine(typeof(_003CDoPublishModel_003Ed__62))]
		private IEnumerator DoPublishModel()
		{
			return null;
		}

		public void ImportModel()
		{
		}

		[IteratorStateMachine(typeof(_003CShowImportModelDialog_003Ed__64))]
		private IEnumerator ShowImportModelDialog()
		{
			return null;
		}

		private static void DoImportModel(string[] paths)
		{
		}

		public void ToolboxModelAdded(Model i)
		{
		}

		public static List<Instance> GetSelectedInstances()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadStarterPlaces_003Ed__68))]
		private IEnumerator LoadStarterPlaces()
		{
			return null;
		}

		public void ClearWorkspace()
		{
		}

		public void CloseStartScreen()
		{
		}

		private void ScriptEditedExternally(object sender, FileSystemEventArgs e)
		{
		}

		private void EditScript(BaseScript script)
		{
		}

		public void PublishGame()
		{
		}

		[IteratorStateMachine(typeof(_003CDoPublish_003Ed__74))]
		private IEnumerator DoPublish()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadThumbnailImages_003Ed__75))]
		private IEnumerator LoadThumbnailImages(List<ThumbnailImageTarget> thumbnails)
		{
			return null;
		}

		public void SetPublishModalSelectedGame(JSONNode game)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadThumbnailImage_003Ed__77))]
		private IEnumerator LoadThumbnailImage(string src, Image target)
		{
			return null;
		}

		[PreserveSig]
		private static extern int chmod(string path, int mode);

		public void TestGame()
		{
		}

		public void PublishGameOverwrite(int id)
		{
		}

		[IteratorStateMachine(typeof(_003CPublishLevelToID_003Ed__81))]
		private IEnumerator PublishLevelToID(int id)
		{
			return null;
		}

		public static string RandomString(int length)
		{
			return null;
		}

		public void FileOpen()
		{
		}

		[IteratorStateMachine(typeof(_003CShowOpenDialog_003Ed__84))]
		private IEnumerator ShowOpenDialog()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAutoSaveLoop_003Ed__85))]
		private IEnumerator AutoSaveLoop()
		{
			return null;
		}

		private static void DoLoadMap(string[] paths)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadMapFromFile_003Ed__87))]
		private IEnumerator LoadMapFromFile(string path)
		{
			return null;
		}

		public void FileSave(bool saveAs)
		{
		}

		[IteratorStateMachine(typeof(_003CShowSaveDialog_003Ed__89))]
		private IEnumerator ShowSaveDialog()
		{
			return null;
		}

		private static void DoSaveFile(string path)
		{
		}

		public void SetMoveSnapEnabled(bool enabled)
		{
		}

		public void SetMoveSnapSize(string snapString)
		{
		}

		public void SetRotateSnapEnabled(bool enabled)
		{
		}

		public void SetRotateSnapSize(string snapString)
		{
		}

		public void SetActiveGizmo(string name)
		{
		}

		private void Update()
		{
		}

		private bool IsEditingTextField()
		{
			return false;
		}

		public List<Instance> GetSelectedInstancesTreeView()
		{
			return null;
		}

		public void CopySelectionToClipboard()
		{
		}

		public void CutSelectionToClipboard()
		{
		}

		public void PasteFromClipboard()
		{
		}

		private void ShowContextMenu()
		{
		}

		public void SetPaintColor(Color c)
		{
		}

		public void ToggleColorPicker()
		{
		}

		public void ToggleMaterialPicker()
		{
		}

		private void OnItemDataBinding(object sender, VirtualizingTreeViewItemDataBindingArgs e)
		{
		}

		private void OnItemBeginDrop(object sender, ItemDropCancelArgs e)
		{
		}

		private void OnItemBeginDrag(object sender, ItemArgs e)
		{
		}

		private void OnItemEndDrag(object sender, ItemArgs e)
		{
		}

		private void OnItemExpanding(object sender, VirtualizingItemExpandingArgs e)
		{
		}

		private void OnTreeSelectionChanged(object sender, SelectionChangedArgs e)
		{
		}

		private List<Instance> ChildrenOf(Instance parent)
		{
			return null;
		}

		private void OnItemDrop(object sender, ItemDropArgs e)
		{
		}

		private void OnItemDoubleClick(object sender, ItemArgs e)
		{
		}

		private void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args)
		{
		}

		public void CloseContextMenu()
		{
		}

		public void AddPart(string shape)
		{
		}

		public void SelectChildren()
		{
		}

		public void Undo()
		{
		}

		public void Redo()
		{
		}

		public void AddTruss()
		{
		}

		public Instance AddInstance(string className, Instance parent = null, bool ignorePlacement = false)
		{
			return null;
		}

		public void AddPart(PartShape shape = PartShape.Brick, string name = "Brick")
		{
		}

		public void AddScript()
		{
		}

		public void AddSound()
		{
		}

		public void AddLocalScript()
		{
		}

		public void AddModuleScript()
		{
		}

		public void AddRemoteEvent()
		{
		}

		public Instance Add(string instanceClass, string parentClass)
		{
			return null;
		}

		public void AddUI(string instanceClass)
		{
		}

		public void AddSeat(string name = "Seat")
		{
		}

		public static bool IsPointerOverUIObject()
		{
			return false;
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
