namespace UnityEngine.UIElements;

[HelpURL("UIE-Runtime-Panel-Settings")]
[Token(Token = "0x200026C")]
public class PanelSettings : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200026E")]
	private sealed class <>c__DisplayClass135_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009AB")]
		public Func<Vector2, Vector2> screenToPanelSpaceFunction; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600111E")]
		public <>c__DisplayClass135_0() { }

		[Address(RVA = "0x1C76160", Offset = "0x1C75360", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600111F")]
		internal Vector3 <SetScreenToPanelSpaceFunction>b__0(Vector2 p) { }

	}

	[Token(Token = "0x200026D")]
	private class RuntimePanelAccess
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009A9")]
		private readonly PanelSettings m_Settings; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009AA")]
		private BaseRuntimePanel m_RuntimePanel; //Field offset: 0x18

		[Token(Token = "0x17000342")]
		internal bool isInitialized
		{
			[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
			[CallerCount(Count = 14)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x6001114")]
			internal get { } //Length: 9
		}

		[Token(Token = "0x17000343")]
		internal BaseRuntimePanel panel
		{
			[Address(RVA = "0x1C74250", Offset = "0x1C73450", Length = "0x2E0")]
			[CalledBy(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
			[CalledBy(Type = typeof(PanelSettings), Member = "set_bindingLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingLogLevel)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PanelSettings), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
			[CalledBy(Type = typeof(PanelSettings), Member = "get_visualTree", ReturnType = typeof(VisualElement))]
			[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector2>)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(UIDocument), Member = "UpdateIsWorldSpaceRootFlag", ReturnType = typeof(void))]
			[CallerCount(Count = 16)]
			[Calls(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
			[Calls(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(BaseRuntimePanel), Member = "set_screenToPanelSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
			[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
			[Calls(Type = typeof(Panel), Member = "set_panelChangeReceiver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugPanelChangeReceiver)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6001115")]
			internal get { } //Length: 736
		}

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001113")]
		internal RuntimePanelAccess(PanelSettings settings) { }

		[Address(RVA = "0x1C73F60", Offset = "0x1C73160", Length = "0xDE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600111B")]
		private BaseRuntimePanel CreateRelatedRuntimePanel() { }

		[Address(RVA = "0x1C74040", Offset = "0x1C73240", Length = "0x72")]
		[CalledBy(Type = typeof(PanelSettings), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "DisposePanel", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "DisposeRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001116")]
		internal void DisposePanel() { }

		[Address(RVA = "0x1C740C0", Offset = "0x1C732C0", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "DisposeRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject)}, ReturnType = typeof(void))]
		[Token(Token = "0x600111C")]
		private void DisposeRelatedPanel() { }

		[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
		[CallerCount(Count = 14)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001114")]
		internal bool get_isInitialized() { }

		[Address(RVA = "0x1C74250", Offset = "0x1C73450", Length = "0x2E0")]
		[CalledBy(Type = typeof(UIDocument), Member = "UpdateIsWorldSpaceRootFlag", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector2>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "SetScreenToPanelSpaceFunction3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CalledBy(Type = typeof(PanelSettings), Member = "set_bindingLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingLogLevel)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[CalledBy(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PanelSettings), Member = "get_visualTree", ReturnType = typeof(VisualElement))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Panel), Member = "set_panelChangeReceiver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugPanelChangeReceiver)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "FindOrCreateRuntimePanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableObject), typeof(CreateRuntimePanelDelegate)}, ReturnType = typeof(BaseRuntimePanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "set_screenToPanelSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PanelSettings), Member = "ApplyPanelSettings", ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001115")]
		internal BaseRuntimePanel get_panel() { }

		[Address(RVA = "0x1C74110", Offset = "0x1C73310", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MarkPotentiallyEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
		[Token(Token = "0x600111D")]
		internal void MarkPotentiallyEmpty() { }

		[Address(RVA = "0x1C74160", Offset = "0x1C73360", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel), Member = "set_panelChangeReceiver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugPanelChangeReceiver)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600111A")]
		internal void SetPanelChangeReceiver() { }

		[Address(RVA = "0x1C741A0", Offset = "0x1C733A0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001118")]
		internal void SetSortingPriority() { }

		[Address(RVA = "0x1C741E0", Offset = "0x1C733E0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001119")]
		internal void SetTargetDisplay() { }

		[Address(RVA = "0x1C74210", Offset = "0x1C73410", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001117")]
		internal void SetTargetTexture() { }

	}

	[Token(Token = "0x400097D")]
	private const int k_DefaultSortingOrder = 0; //Field offset: 0x0
	[Token(Token = "0x400097E")]
	private const float k_DefaultScaleValue = 1; //Field offset: 0x0
	[Token(Token = "0x400097F")]
	internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset"; //Field offset: 0x0
	[Token(Token = "0x400098A")]
	private const float DefaultDpi = 96; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000980")]
	private ThemeStyleSheet themeUss; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000981")]
	private bool m_DisableNoThemeWarning; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000982")]
	private RenderTexture m_TargetTexture; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000983")]
	private PanelRenderMode m_RenderMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("m_WorldInputMode")]
	[SerializeField]
	[Token(Token = "0x4000984")]
	private ColliderUpdateMode m_ColliderUpdateMode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000985")]
	private bool m_ColliderIsTrigger; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000986")]
	private PanelScaleMode m_ScaleMode; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000987")]
	private float m_ReferenceSpritePixelsPerUnit; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000988")]
	private float m_PixelsPerUnit; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000989")]
	private float m_Scale; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x400098B")]
	private float m_ReferenceDpi; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400098C")]
	private float m_FallbackDpi; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400098D")]
	private Vector2Int m_ReferenceResolution; //Field offset: 0x54
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x400098E")]
	private PanelScreenMatchMode m_ScreenMatchMode; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0, 1)]
	[SerializeField]
	[Token(Token = "0x400098F")]
	private float m_Match; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x4000990")]
	private float m_SortingOrder; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000991")]
	private int m_TargetDisplay; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x4000992")]
	private BindingLogLevel m_BindingLogLevel; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000993")]
	private bool m_ClearDepthStencil; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[SerializeField]
	[Token(Token = "0x4000994")]
	private bool m_ClearColor; //Field offset: 0x71
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x4000995")]
	private Color m_ColorClearValue; //Field offset: 0x74
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x4000996")]
	private uint m_VertexBudget; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000997")]
	private RuntimePanelAccess m_PanelAccess; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000998")]
	internal UIDocumentList m_AttachedUIDocumentsList; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000999")]
	private DynamicAtlasSettings m_DynamicAtlasSettings; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400099A")]
	private Shader m_AtlasBlitShader; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400099B")]
	private Shader m_RuntimeShader; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400099C")]
	private Shader m_RuntimeWorldShader; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400099D")]
	private Shader m_SDFShader; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400099E")]
	private Shader m_BitmapShader; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400099F")]
	private Shader m_SpriteShader; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009A0")]
	internal TextAsset m_ICUDataAsset; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x40009A1")]
	public bool forceGammaRendering; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x40009A2")]
	public PanelTextSettings textSettings; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40009A3")]
	private Rect m_TargetRect; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40009A4")]
	private float m_ResolvedScale; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40009A5")]
	private StyleSheet m_OldThemeUss; //Field offset: 0x100
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40009A6")]
	private float <ScreenDPI>k__BackingField; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40009A7")]
	private IDebugPanelChangeReceiver m_PanelChangeReceiver; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40009A8")]
	private Func<Vector2, Vector3> m_AssignedScreenToPanel; //Field offset: 0x118

	[Token(Token = "0x17000337")]
	public BindingLogLevel bindingLogLevel
	{
		[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010EF")]
		 get { } //Length: 4
		[Address(RVA = "0x1C73540", Offset = "0x1C72740", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[Calls(Type = typeof(Binding), Member = "SetPanelLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(BindingLogLevel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010F0")]
		 set { } //Length: 64
	}

	[Token(Token = "0x1700033A")]
	public bool clearColor
	{
		[Address(RVA = "0x521590", Offset = "0x520790", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010F4")]
		 get { } //Length: 5
		[Address(RVA = "0x521650", Offset = "0x520850", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010F5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000338")]
	public bool clearDepthStencil
	{
		[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010F1")]
		 get { } //Length: 5
		[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010F2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700032B")]
	internal bool colliderIsTrigger
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D6")]
		internal get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D7")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700032A")]
	internal ColliderUpdateMode colliderUpdateMode
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D4")]
		internal get { } //Length: 4
		[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D5")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700033B")]
	public Color colorClearValue
	{
		[Address(RVA = "0x1C73480", Offset = "0x1C72680", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60010F6")]
		 get { } //Length: 11
		[Address(RVA = "0x1C73590", Offset = "0x1C72790", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60010F7")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000339")]
	public float depthClearValue
	{
		[Address(RVA = "0x1C73490", Offset = "0x1C72690", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60010F3")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000340")]
	public DynamicAtlasSettings dynamicAtlasSettings
	{
		[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010FD")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60010FE")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000331")]
	public float fallbackDpi
	{
		[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E2")]
		 get { } //Length: 6
		[Address(RVA = "0x1C735A0", Offset = "0x1C727A0", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010E3")]
		 set { } //Length: 41
	}

	[Token(Token = "0x1700033E")]
	internal bool isInitialized
	{
		[Address(RVA = "0x1C734A0", Offset = "0x1C726A0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010FB")]
		internal get { } //Length: 22
	}

	[Token(Token = "0x17000334")]
	public float match
	{
		[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E8")]
		 get { } //Length: 6
		[Address(RVA = "0x18184E0", Offset = "0x18176E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E9")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700033D")]
	internal BaseRuntimePanel panel
	{
		[Address(RVA = "0x1C734C0", Offset = "0x1C726C0", Length = "0x20")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010FA")]
		internal get { } //Length: 32
	}

	[Token(Token = "0x1700032E")]
	internal float pixelsPerUnit
	{
		[Address(RVA = "0x1A1E2B0", Offset = "0x1A1D4B0", Length = "0x8")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DC")]
		internal get { } //Length: 8
		[Address(RVA = "0x599380", Offset = "0x598580", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DD")]
		internal set { } //Length: 6
	}

	[Token(Token = "0x17000330")]
	public float referenceDpi
	{
		[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E0")]
		 get { } //Length: 6
		[Address(RVA = "0x1C735D0", Offset = "0x1C727D0", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010E1")]
		 set { } //Length: 41
	}

	[Token(Token = "0x17000332")]
	public Vector2Int referenceResolution
	{
		[Address(RVA = "0x1C00420", Offset = "0x1BFF620", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E4")]
		 get { } //Length: 5
		[Address(RVA = "0x1C73600", Offset = "0x1C72800", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60010E5")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700032D")]
	public float referenceSpritePixelsPerUnit
	{
		[Address(RVA = "0x19DC110", Offset = "0x19DB310", Length = "0x8")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DA")]
		 get { } //Length: 8
		[Address(RVA = "0x83D110", Offset = "0x83C310", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DB")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000329")]
	internal PanelRenderMode renderMode
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D2")]
		internal get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D3")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700032F")]
	public float scale
	{
		[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DE")]
		 get { } //Length: 6
		[Address(RVA = "0x1C73610", Offset = "0x1C72810", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DF")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700032C")]
	public PanelScaleMode scaleMode
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D8")]
		 get { } //Length: 4
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000341")]
	private float ScreenDPI
	{
		[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6001104")]
		private get { } //Length: 9
		[Address(RVA = "0x1C73530", Offset = "0x1C72730", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6001105")]
		private set { } //Length: 9
	}

	[Token(Token = "0x17000333")]
	public PanelScreenMatchMode screenMatchMode
	{
		[Address(RVA = "0x53C080", Offset = "0x53B280", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E6")]
		 get { } //Length: 4
		[Address(RVA = "0x599430", Offset = "0x598630", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010E7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000335")]
	public float sortingOrder
	{
		[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010EA")]
		 get { } //Length: 6
		[Address(RVA = "0x1C73620", Offset = "0x1C72820", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010EB")]
		 set { } //Length: 68
	}

	[Token(Token = "0x17000336")]
	public int targetDisplay
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010ED")]
		 get { } //Length: 4
		[Address(RVA = "0x1C73670", Offset = "0x1C72870", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010EE")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000328")]
	public RenderTexture targetTexture
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010D0")]
		 get { } //Length: 5
		[Address(RVA = "0x1C736B0", Offset = "0x1C728B0", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60010D1")]
		 set { } //Length: 93
	}

	[Token(Token = "0x17000327")]
	public ThemeStyleSheet themeStyleSheet
	{
		[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
		[CallerCount(Count = 73)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010CE")]
		 get { } //Length: 7
		[Address(RVA = "0x1C73710", Offset = "0x1C72910", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
		[Token(Token = "0x60010CF")]
		 set { } //Length: 40
	}

	[Token(Token = "0x1700033C")]
	public uint vertexBudget
	{
		[Address(RVA = "0xE0C200", Offset = "0xE0B400", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010F8")]
		 get { } //Length: 7
		[Address(RVA = "0xE0C2C0", Offset = "0xE0B4C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010F9")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700033F")]
	internal VisualElement visualTree
	{
		[Address(RVA = "0x1C734F0", Offset = "0x1C726F0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60010FC")]
		internal get { } //Length: 60
	}

	[Address(RVA = "0x1C732F0", Offset = "0x1C724F0", Length = "0x18C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60010FF")]
	private PanelSettings() { }

	[Address(RVA = "0x1C71A30", Offset = "0x1C70C30", Length = "0xBD7")]
	[CalledBy(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = typeof(RuntimePanel), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StyleLength), Member = "get_value", ReturnType = typeof(Length))]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_maxSubTextureSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_maxAtlasSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_minAtlasSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DataBindingManager), Member = "set_logLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingLogLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "set_isFlat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "set_pixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "set_drawsInCameras", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(BaseVisualElementPanel), Member = "set_scale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Length), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_activeFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicAtlasFilters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DynamicAtlas), Member = "set_customFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicAtlasCustomFilter)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600110C")]
	internal void ApplyPanelSettings() { }

	[Address(RVA = "0x1C72610", Offset = "0x1C71810", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010EC")]
	internal void ApplySortingOrder() { }

	[Address(RVA = "0x1C72650", Offset = "0x1C71850", Length = "0x1A6")]
	[CalledBy(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[CalledBy(Type = typeof(PanelSettings), Member = "set_themeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThemeStyleSheet)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_styleSheets", ReturnType = typeof(VisualElementStyleSheetSet))]
	[Calls(Type = typeof(VisualElementStyleSheetSet), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleSheet), Member = "set_isDefaultStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElementStyleSheetSet), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001109")]
	private void ApplyThemeStyleSheet(VisualElement root = null) { }

	[Address(RVA = "0x191DD80", Offset = "0x191CF80", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600110A")]
	internal bool AssignICUData() { }

	[Address(RVA = "0x1C72800", Offset = "0x1C71A00", Length = "0x130")]
	[CalledBy(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UIDocumentList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001111")]
	internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) { }

	[Address(RVA = "0x1C72940", Offset = "0x1C71B40", Length = "0x112")]
	[CalledBy(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIElementsRuntimeUtility), Member = "MarkPotentiallyEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001112")]
	internal void DetachUIDocument(UIDocument uiDocument) { }

	[Address(RVA = "0x1C72A60", Offset = "0x1C71C60", Length = "0x20")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "DisposePanel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001103")]
	internal void DisposePanel() { }

	[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010EF")]
	public BindingLogLevel get_bindingLogLevel() { }

	[Address(RVA = "0x521590", Offset = "0x520790", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010F4")]
	public bool get_clearColor() { }

	[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010F1")]
	public bool get_clearDepthStencil() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D6")]
	internal bool get_colliderIsTrigger() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D4")]
	internal ColliderUpdateMode get_colliderUpdateMode() { }

	[Address(RVA = "0x1C73480", Offset = "0x1C72680", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60010F6")]
	public Color get_colorClearValue() { }

	[Address(RVA = "0x1C73490", Offset = "0x1C72690", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60010F3")]
	public float get_depthClearValue() { }

	[Address(RVA = "0x2DD240", Offset = "0x2DC440", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010FD")]
	public DynamicAtlasSettings get_dynamicAtlasSettings() { }

	[Address(RVA = "0x3B43D0", Offset = "0x3B35D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E2")]
	public float get_fallbackDpi() { }

	[Address(RVA = "0x1C734A0", Offset = "0x1C726A0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010FB")]
	internal bool get_isInitialized() { }

	[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E8")]
	public float get_match() { }

	[Address(RVA = "0x1C734C0", Offset = "0x1C726C0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010FA")]
	internal BaseRuntimePanel get_panel() { }

	[Address(RVA = "0x1A1E2B0", Offset = "0x1A1D4B0", Length = "0x8")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DC")]
	internal float get_pixelsPerUnit() { }

	[Address(RVA = "0x3B43E0", Offset = "0x3B35E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E0")]
	public float get_referenceDpi() { }

	[Address(RVA = "0x1C00420", Offset = "0x1BFF620", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E4")]
	public Vector2Int get_referenceResolution() { }

	[Address(RVA = "0x19DC110", Offset = "0x19DB310", Length = "0x8")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DA")]
	public float get_referenceSpritePixelsPerUnit() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D2")]
	internal PanelRenderMode get_renderMode() { }

	[Address(RVA = "0x3B43F0", Offset = "0x3B35F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DE")]
	public float get_scale() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D8")]
	public PanelScaleMode get_scaleMode() { }

	[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6001104")]
	private float get_ScreenDPI() { }

	[Address(RVA = "0x53C080", Offset = "0x53B280", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E6")]
	public PanelScreenMatchMode get_screenMatchMode() { }

	[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010EA")]
	public float get_sortingOrder() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010ED")]
	public int get_targetDisplay() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D0")]
	public RenderTexture get_targetTexture() { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010CE")]
	public ThemeStyleSheet get_themeStyleSheet() { }

	[Address(RVA = "0xE0C200", Offset = "0xE0B400", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010F8")]
	public uint get_vertexBudget() { }

	[Address(RVA = "0x1C734F0", Offset = "0x1C726F0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010FC")]
	internal VisualElement get_visualTree() { }

	[Address(RVA = "0x1C72A90", Offset = "0x1C71C90", Length = "0x137")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001110")]
	internal Rect GetDisplayRect() { }

	[Address(RVA = "0x1C72BD0", Offset = "0x1C71DD0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001107")]
	internal IDebugPanelChangeReceiver GetPanelChangeReceiver() { }

	[Address(RVA = "0x1C72BE0", Offset = "0x1C71DE0", Length = "0x336")]
	[CalledBy(Type = typeof(PanelSettings), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600110B")]
	private void InitializeShaders() { }

	[Address(RVA = "0x1C72A60", Offset = "0x1C71C60", Length = "0x20")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "DisposePanel", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001102")]
	private void OnDisable() { }

	[Address(RVA = "0x1C72F20", Offset = "0x1C72120", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
	[Calls(Type = typeof(PanelSettings), Member = "InitializeShaders", ReturnType = typeof(void))]
	[Token(Token = "0x6001101")]
	private void OnEnable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001100")]
	private void Reset() { }

	[Address(RVA = "0x1C73010", Offset = "0x1C72210", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600110F")]
	internal float ResolveScale(Rect targetRect, float screenDpi) { }

	[Address(RVA = "0x1C73540", Offset = "0x1C72740", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(Binding), Member = "SetPanelLogLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPanel), typeof(BindingLogLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010F0")]
	public void set_bindingLogLevel(BindingLogLevel value) { }

	[Address(RVA = "0x521650", Offset = "0x520850", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010F5")]
	public void set_clearColor(bool value) { }

	[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010F2")]
	public void set_clearDepthStencil(bool value) { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D7")]
	internal void set_colliderIsTrigger(bool value) { }

	[Address(RVA = "0x3EAB30", Offset = "0x3E9D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D5")]
	internal void set_colliderUpdateMode(ColliderUpdateMode value) { }

	[Address(RVA = "0x1C73590", Offset = "0x1C72790", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60010F7")]
	public void set_colorClearValue(Color value) { }

	[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60010FE")]
	public void set_dynamicAtlasSettings(DynamicAtlasSettings value) { }

	[Address(RVA = "0x1C735A0", Offset = "0x1C727A0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010E3")]
	public void set_fallbackDpi(float value) { }

	[Address(RVA = "0x18184E0", Offset = "0x18176E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E9")]
	public void set_match(float value) { }

	[Address(RVA = "0x599380", Offset = "0x598580", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DD")]
	internal void set_pixelsPerUnit(float value) { }

	[Address(RVA = "0x1C735D0", Offset = "0x1C727D0", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010E1")]
	public void set_referenceDpi(float value) { }

	[Address(RVA = "0x1C73600", Offset = "0x1C72800", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60010E5")]
	public void set_referenceResolution(Vector2Int value) { }

	[Address(RVA = "0x83D110", Offset = "0x83C310", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DB")]
	public void set_referenceSpritePixelsPerUnit(float value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D3")]
	internal void set_renderMode(PanelRenderMode value) { }

	[Address(RVA = "0x1C73610", Offset = "0x1C72810", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DF")]
	public void set_scale(float value) { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010D9")]
	public void set_scaleMode(PanelScaleMode value) { }

	[Address(RVA = "0x1C73530", Offset = "0x1C72730", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6001105")]
	private void set_ScreenDPI(float value) { }

	[Address(RVA = "0x599430", Offset = "0x598630", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E7")]
	public void set_screenMatchMode(PanelScreenMatchMode value) { }

	[Address(RVA = "0x1C73620", Offset = "0x1C72820", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "set_sortingPriority", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010EB")]
	public void set_sortingOrder(float value) { }

	[Address(RVA = "0x1C73670", Offset = "0x1C72870", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010EE")]
	public void set_targetDisplay(int value) { }

	[Address(RVA = "0x1C736B0", Offset = "0x1C728B0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010D1")]
	public void set_targetTexture(RenderTexture value) { }

	[Address(RVA = "0x1C73710", Offset = "0x1C72910", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PanelSettings), Member = "ApplyThemeStyleSheet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010CF")]
	public void set_themeStyleSheet(ThemeStyleSheet value) { }

	[Address(RVA = "0xE0C2C0", Offset = "0xE0B4C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010F9")]
	public void set_vertexBudget(uint value) { }

	[Address(RVA = "0x1C73110", Offset = "0x1C72310", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Panel), Member = "set_panelChangeReceiver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDebugPanelChangeReceiver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Conditional("ENABLE_PROFILER")]
	[Token(Token = "0x6001106")]
	public void SetPanelChangeReceiver(IDebugPanelChangeReceiver value) { }

	[Address(RVA = "0x1C731D0", Offset = "0x1C723D0", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "set_screenToPanelSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600110E")]
	public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screenToPanelSpaceFunction) { }

	[Address(RVA = "0x1C73170", Offset = "0x1C72370", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimePanelAccess), Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "set_screenToPanelSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<UnityEngine.Vector2, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600110D")]
	public void SetScreenToPanelSpaceFunction3D(Func<Vector2, Vector3> screenToPanelSpaceFunction) { }

	[Address(RVA = "0x1C732D0", Offset = "0x1C724D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
	[Token(Token = "0x6001108")]
	internal void UpdateScreenDPI() { }

}

