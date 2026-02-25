namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/UI Document")]
[DefaultExecutionOrder(-100)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("UIE-get-started-with-runtime-ui")]
[Token(Token = "0x200027C")]
public sealed class UIDocument : MonoBehaviour
{
	[Token(Token = "0x200027D")]
	internal enum WorldSpaceSizeMode
	{
		Dynamic = 0,
		Fixed = 1,
	}

	[Token(Token = "0x40009CF")]
	internal const string k_RootStyleClassName = "unity-ui-document__root"; //Field offset: 0x0
	[Token(Token = "0x40009D0")]
	internal const string k_VisualElementNameSuffix = "-container"; //Field offset: 0x0
	[Token(Token = "0x40009D1")]
	private const int k_DefaultSortingOrder = 0; //Field offset: 0x0
	[Token(Token = "0x40009D2")]
	private static int s_CurrentUIDocumentCounter; //Field offset: 0x0
	[Token(Token = "0x40009D4")]
	internal static int EnabledDocumentCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009D3")]
	internal readonly int m_UIDocumentCreationIndex; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40009D5")]
	private PanelSettings m_PanelSettings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009D6")]
	private PanelSettings m_PreviousPanelSettings; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40009D7")]
	private UIDocument m_ParentUI; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009D8")]
	private UIDocumentList m_ChildrenContent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009D9")]
	private List<UIDocument> m_ChildrenContentCopy; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40009DA")]
	private VisualTreeAsset sourceAsset; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40009DB")]
	private UIDocumentRootElement m_RootVisualElement; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40009DC")]
	private VisualElementFocusRing <focusRing>k__BackingField; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40009DD")]
	internal int softPointerCaptures; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40009DE")]
	private int m_FirstChildInsertIndex; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40009DF")]
	private float m_SortingOrder; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40009E0")]
	private Position m_Position; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40009E1")]
	private WorldSpaceSizeMode m_WorldSpaceSizeMode; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x40009E2")]
	private float m_WorldSpaceWidth; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40009E3")]
	private float m_WorldSpaceHeight; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x40009E4")]
	private PivotReferenceSize m_PivotReferenceSize; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40009E5")]
	private Pivot m_Pivot; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40009E6")]
	private BoxCollider m_WorldSpaceCollider; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40009E7")]
	private bool m_RootHasWorldTransform; //Field offset: 0x98

	[Token(Token = "0x17000357")]
	internal RuntimePanel containerPanel
	{
		[Address(RVA = "0x1C7A920", Offset = "0x1C79B20", Length = "0x7B")]
		[CalledBy(Type = typeof(UIDocument), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PhysicsDocumentPicker), Member = "TryPickWithCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Ray), typeof(float), typeof(int), typeof(Collider&), typeof(UIDocument&), typeof(VisualElement&), typeof(Single&), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UIDocument), Member = "get_runtimePanel", ReturnType = typeof(IRuntimePanel))]
		[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColliderUpdateMode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "ScaleAndFlipMatrix", ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(Single&)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(PickResult))]
		[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
		[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001166")]
		internal get { } //Length: 123
	}

	[Token(Token = "0x1700034D")]
	internal int firstChildInserIndex
	{
		[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001150")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700034C")]
	internal VisualElementFocusRing focusRing
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600114E")]
		internal get { } //Length: 5
		[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600114F")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000352")]
	internal bool isTransformControlledByGameObject
	{
		[Address(RVA = "0x1C7A9A0", Offset = "0x1C79BA0", Length = "0x87")]
		[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "SetupPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "SetupWorldSpaceSize", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UIDocument), Member = "get_isWorldSpace", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001158")]
		internal get { } //Length: 135
	}

	[Token(Token = "0x17000351")]
	private bool isWorldSpace
	{
		[Address(RVA = "0x1C7AA30", Offset = "0x1C79C30", Length = "0x80")]
		[CalledBy(Type = typeof(UIDocument), Member = "get_isTransformControlledByGameObject", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "AddOrRemoveRendererComponent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "SetupRootClassList", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001157")]
		private get { } //Length: 128
	}

	[Token(Token = "0x17000348")]
	public PanelSettings panelSettings
	{
		[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001146")]
		 get { } //Length: 7
		[Address(RVA = "0x1C7AB60", Offset = "0x1C79D60", Length = "0x2CC")]
		[CalledBy(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6001147")]
		 set { } //Length: 716
	}

	[Token(Token = "0x17000349")]
	public private UIDocument parentUI
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001148")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001149")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000354")]
	public Pivot pivot
	{
		[Address(RVA = "0x1C7AAD0", Offset = "0x1C79CD0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600115B")]
		 get { } //Length: 9
		[Address(RVA = "0xE0C2B0", Offset = "0xE0B4B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600115C")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000353")]
	public PivotReferenceSize pivotReferenceSize
	{
		[Address(RVA = "0x1C7AAC0", Offset = "0x1C79CC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001159")]
		 get { } //Length: 9
		[Address(RVA = "0xE0C2C0", Offset = "0xE0B4C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600115A")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000358")]
	private float pixelsPerUnit
	{
		[Address(RVA = "0x1C7AAE0", Offset = "0x1C79CE0", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
		[Calls(Type = typeof(BaseRuntimePanel), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Token(Token = "0x6001172")]
		private get { } //Length: 43
	}

	[Token(Token = "0x1700034E")]
	public Position position
	{
		[Address(RVA = "0x1C7AB10", Offset = "0x1C79D10", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001151")]
		 get { } //Length: 6
		[Address(RVA = "0x1C7AE30", Offset = "0x1C7A030", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIDocument), Member = "SetupPosition", ReturnType = typeof(void))]
		[Token(Token = "0x6001152")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700034B")]
	public private VisualElement rootVisualElement
	{
		[Address(RVA = "0x19AA830", Offset = "0x19A9A30", Length = "0x7")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600114C")]
		 get { } //Length: 7
		[Address(RVA = "0x1C7AE40", Offset = "0x1C7A040", Length = "0x112")]
		[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(VisualElementFocusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(DefaultFocusOrder)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600114D")]
		private set { } //Length: 274
	}

	[Token(Token = "0x17000356")]
	public IRuntimePanel runtimePanel
	{
		[Address(RVA = "0x1C7AB20", Offset = "0x1C79D20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
		[Token(Token = "0x6001165")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000355")]
	public float sortingOrder
	{
		[Address(RVA = "0x1C7AB30", Offset = "0x1C79D30", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600115D")]
		 get { } //Length: 6
		[Address(RVA = "0x1C7AF60", Offset = "0x1C7A160", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600115E")]
		 set { } //Length: 25
	}

	[Token(Token = "0x1700034A")]
	public VisualTreeAsset visualTreeAsset
	{
		[Address(RVA = "0x19AA910", Offset = "0x19A9B10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600114A")]
		 get { } //Length: 7
		[Address(RVA = "0x1C7AF80", Offset = "0x1C7A180", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
		[Token(Token = "0x600114B")]
		 set { } //Length: 37
	}

	[Token(Token = "0x17000350")]
	public Vector2 worldSpaceSize
	{
		[Address(RVA = "0x1C7AB40", Offset = "0x1C79D40", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001155")]
		 get { } //Length: 22
		[Address(RVA = "0x1C7AFC0", Offset = "0x1C7A1C0", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIDocument), Member = "SetupWorldSpaceSize", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001156")]
		 set { } //Length: 65
	}

	[Token(Token = "0x1700034F")]
	public WorldSpaceSizeMode worldSpaceSizeMode
	{
		[Address(RVA = "0x1A75C70", Offset = "0x1A74E70", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001153")]
		 get { } //Length: 6
		[Address(RVA = "0x1C7AFB0", Offset = "0x1C7A1B0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIDocument), Member = "SetupWorldSpaceSize", ReturnType = typeof(void))]
		[Token(Token = "0x6001154")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x1C7A760", Offset = "0x1C79960", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001164")]
	private void _Enable() { }

	[Address(RVA = "0x1C7A860", Offset = "0x1C79A60", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001161")]
	private UIDocument() { }

	[Address(RVA = "0x1C76960", Offset = "0x1C75B60", Length = "0xFB")]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "SetupPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UIDocumentList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIDocumentList), Member = "AddToListAndToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(VisualElement), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600117C")]
	internal void AddChildAndInsertContentToVisualTree(UIDocument child) { }

	[Address(RVA = "0x1C76A60", Offset = "0x1C75C60", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "get_isWorldSpace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600116B")]
	private void AddOrRemoveRendererComponent() { }

	[Address(RVA = "0x1C76B60", Offset = "0x1C75D60", Length = "0xCE")]
	[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ApplySortingOrder", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "_Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIDocument), Member = "AddChildAndInsertContentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Token(Token = "0x6001182")]
	private void AddRootVisualElementToTree() { }

	[Address(RVA = "0x1C76C30", Offset = "0x1C75E30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[Token(Token = "0x600115F")]
	internal void ApplySortingOrder() { }

	[Address(RVA = "0x1C76C40", Offset = "0x1C75E40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "SetupFromHierarchy", ReturnType = typeof(void))]
	[Token(Token = "0x6001162")]
	private void Awake() { }

	[Address(RVA = "0x1C76C50", Offset = "0x1C75E50", Length = "0x3D5")]
	[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001171")]
	private void ClearTransform() { }

	[Address(RVA = "0x1C77030", Offset = "0x1C76230", Length = "0x3EA")]
	[CalledBy(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "ScaleAndFlipMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "get_localToWorldMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UIDocument), Member = "PivotOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UIDocument), Member = "TransformToGameObjectMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001177")]
	private void ComputeTransform(Transform transform, out Matrix4x4 matrix) { }

	[Address(RVA = "0x1C77420", Offset = "0x1C76620", Length = "0x220")]
	[CalledBy(Type = typeof(UIDocument), Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "SetTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "get_isTransformControlledByGameObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(UIDocument), Member = "UpdateIsWorldSpaceRootFlag", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "ClearTransform", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UIDocument), Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColliderUpdateMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "get_isWorldSpace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIDocument), Member = "RemoveWorldSpaceCollider", ReturnType = typeof(void))]
	[Token(Token = "0x6001168")]
	internal void DoUpdate() { }

	[Address(RVA = "0x1C77650", Offset = "0x1C76850", Length = "0xB1")]
	[CalledBy(Type = typeof(GenericDropdownMenu), Member = "DropDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(VisualElement), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PointerDeviceState), Member = "SetElementWithSoftPointerCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(VisualElement), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PhysicsDocumentPicker), Member = "GetCapturingDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UIDocument&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "GetNextFocusable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(FocusChangeDirection)}, ReturnType = typeof(Focusable))]
	[CalledBy(Type = typeof(NavigateFocusRing), Member = "IsWorldSpaceNavigationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Focusable), typeof(UIDocument&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "GetFirstOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001160")]
	internal static UIDocument FindRootUIDocument(VisualElement element) { }

	[Address(RVA = "0x1C77710", Offset = "0x1C76910", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600117A")]
	private UIDocument FindUIDocumentParent() { }

	[Address(RVA = "0x1C7A920", Offset = "0x1C79B20", Length = "0x7B")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldDocumentRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.VisualElement>)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = typeof(PickResult))]
	[CalledBy(Type = typeof(WorldSpaceInput), Member = "Pick3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument), typeof(Ray), typeof(Single&)}, ReturnType = typeof(VisualElement))]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColliderUpdateMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ScaleAndFlipMatrix", ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(UIDocument), Member = "get_runtimePanel", ReturnType = typeof(IRuntimePanel))]
	[CalledBy(Type = typeof(PhysicsDocumentPicker), Member = "TryPickWithCapture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Ray), typeof(float), typeof(int), typeof(Collider&), typeof(UIDocument&), typeof(VisualElement&), typeof(Single&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultEventSystem), Member = "FindTargetAtPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(int), typeof(System.Nullable`1<System.Int32>), typeof(VisualElement&), typeof(RuntimePanel&), typeof(Vector3&), typeof(VisualElement&), typeof(Camera&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001166")]
	internal RuntimePanel get_containerPanel() { }

	[Address(RVA = "0x5215C0", Offset = "0x5207C0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001150")]
	internal int get_firstChildInserIndex() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600114E")]
	internal VisualElementFocusRing get_focusRing() { }

	[Address(RVA = "0x1C7A9A0", Offset = "0x1C79BA0", Length = "0x87")]
	[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "SetupPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "SetupWorldSpaceSize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIDocument), Member = "get_isWorldSpace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001158")]
	internal bool get_isTransformControlledByGameObject() { }

	[Address(RVA = "0x1C7AA30", Offset = "0x1C79C30", Length = "0x80")]
	[CalledBy(Type = typeof(UIDocument), Member = "get_isTransformControlledByGameObject", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "AddOrRemoveRendererComponent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "SetupRootClassList", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001157")]
	private bool get_isWorldSpace() { }

	[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001146")]
	public PanelSettings get_panelSettings() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001148")]
	public UIDocument get_parentUI() { }

	[Address(RVA = "0x1C7AAD0", Offset = "0x1C79CD0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600115B")]
	public Pivot get_pivot() { }

	[Address(RVA = "0x1C7AAC0", Offset = "0x1C79CC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001159")]
	public PivotReferenceSize get_pivotReferenceSize() { }

	[Address(RVA = "0x1C7AAE0", Offset = "0x1C79CE0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Token(Token = "0x6001172")]
	private float get_pixelsPerUnit() { }

	[Address(RVA = "0x1C7AB10", Offset = "0x1C79D10", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001151")]
	public Position get_position() { }

	[Address(RVA = "0x19AA830", Offset = "0x19A9A30", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600114C")]
	public VisualElement get_rootVisualElement() { }

	[Address(RVA = "0x1C7AB20", Offset = "0x1C79D20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
	[Token(Token = "0x6001165")]
	public IRuntimePanel get_runtimePanel() { }

	[Address(RVA = "0x1C7AB30", Offset = "0x1C79D30", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600115D")]
	public float get_sortingOrder() { }

	[Address(RVA = "0x19AA910", Offset = "0x19A9B10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600114A")]
	public VisualTreeAsset get_visualTreeAsset() { }

	[Address(RVA = "0x1C7AB40", Offset = "0x1C79D40", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001155")]
	public Vector2 get_worldSpaceSize() { }

	[Address(RVA = "0x1A75C70", Offset = "0x1A74E70", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001153")]
	public WorldSpaceSizeMode get_worldSpaceSizeMode() { }

	[Address(RVA = "0x1C777C0", Offset = "0x1C769C0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001178")]
	private static Vector2 GetPivotAsPercent(Pivot origin) { }

	[Address(RVA = "0x1C778C0", Offset = "0x1C76AC0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600116E")]
	private static bool IsValidBounds(in Bounds b) { }

	[Address(RVA = "0x1C77910", Offset = "0x1C76B10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
	[Token(Token = "0x6001167")]
	private void LateUpdate() { }

	[Address(RVA = "0x1C77920", Offset = "0x1C76B20", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VisualElement), Member = "get_localBounds3DWithoutNested3D", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UIDocument), Member = "SanitizeRendererBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001174")]
	private Bounds LocalBoundsFromPivotSource() { }

	[Address(RVA = "0x1C77AA0", Offset = "0x1C76CA0", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PointerDeviceState), Member = "RemoveDocumentData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "RemoveWorldSpaceCollider", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001184")]
	private void OnDisable() { }

	[Address(RVA = "0x1C77BC0", Offset = "0x1C76DC0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Renderer), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001163")]
	private void OnEnable() { }

	[Address(RVA = "0x1C77D00", Offset = "0x1C76F00", Length = "0x1E7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001185")]
	private void OnTransformChildrenChanged() { }

	[Address(RVA = "0x1C77EF0", Offset = "0x1C770F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[Token(Token = "0x6001186")]
	private void OnTransformParentChanged() { }

	[Address(RVA = "0x1C77F00", Offset = "0x1C77100", Length = "0x250")]
	[CalledBy(Type = typeof(UIDocument), Member = "TransformToGameObjectMatrix", ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(UIDocument), Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_localBounds3DWithoutNested3D", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UIDocument), Member = "SanitizeRendererBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001175")]
	private Vector2 PivotOffset() { }

	[Address(RVA = "0x1C78180", Offset = "0x1C77380", Length = "0xA8")]
	[CalledBy(Type = typeof(UIDocument), Member = "OnTransformChildrenChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIDocument), Member = "SetupFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "SetupRootClassList", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001187")]
	internal void ReactToHierarchyChanged() { }

	[Address(RVA = "0x1C78230", Offset = "0x1C77430", Length = "0x51F")]
	[CalledBy(Type = typeof(UIDocument), Member = "set_visualTreeAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "_Enable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "set_pickingMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_childCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "AddChildAndInsertContentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(UIDocument), Member = "SetupRootClassList", ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualTreeAsset), Member = "CloneTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "set_rootVisualElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TemplateContainer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(VisualTreeAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIDocument), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600117E")]
	private void RecreateUI() { }

	[Address(RVA = "0x1C78750", Offset = "0x1C77950", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600117D")]
	private void RemoveChild(UIDocument child) { }

	[Address(RVA = "0x1C787C0", Offset = "0x1C779C0", Length = "0x102")]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001183")]
	private void RemoveFromHierarchy() { }

	[Address(RVA = "0x1C788D0", Offset = "0x1C77AD0", Length = "0x72")]
	[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateWorldSpaceCollider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColliderUpdateMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600116D")]
	internal void RemoveWorldSpaceCollider() { }

	[Address(RVA = "0x1C78950", Offset = "0x1C77B50", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "SetupFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600117B")]
	internal void Reset() { }

	[Address(RVA = "0x1C78A60", Offset = "0x1C77C60", Length = "0x1BD")]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "LocalBoundsFromPivotSource", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(UIDocument), Member = "PivotOffset", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600116A")]
	private Bounds SanitizeRendererBounds(Bounds b) { }

	[Address(RVA = "0x1C78C20", Offset = "0x1C77E20", Length = "0x262")]
	[CalledBy(Type = typeof(UIDocument), Member = "TransformToGameObjectMatrix", ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(UIDocument), Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Token(Token = "0x6001173")]
	private Matrix4x4 ScaleAndFlipMatrix() { }

	[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600114F")]
	private void set_focusRing(VisualElementFocusRing value) { }

	[Address(RVA = "0x1C7AB60", Offset = "0x1C79D60", Length = "0x2CC")]
	[CalledBy(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIDocument), Member = "set_panelSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PanelSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(PanelSettings), Member = "DetachUIDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PanelSettings), Member = "AttachAndInsertUIDocumentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001147")]
	public void set_panelSettings(PanelSettings value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001149")]
	private void set_parentUI(UIDocument value) { }

	[Address(RVA = "0xE0C2B0", Offset = "0xE0B4B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600115C")]
	public void set_pivot(Pivot value) { }

	[Address(RVA = "0xE0C2C0", Offset = "0xE0B4C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600115A")]
	public void set_pivotReferenceSize(PivotReferenceSize value) { }

	[Address(RVA = "0x1C7AE30", Offset = "0x1C7A030", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "SetupPosition", ReturnType = typeof(void))]
	[Token(Token = "0x6001152")]
	public void set_position(Position value) { }

	[Address(RVA = "0x1C7AE40", Offset = "0x1C7A040", Length = "0x112")]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VisualElementFocusRing), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(DefaultFocusOrder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600114D")]
	private void set_rootVisualElement(VisualElement value) { }

	[Address(RVA = "0x1C7AF60", Offset = "0x1C7A160", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "AddRootVisualElementToTree", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600115E")]
	public void set_sortingOrder(float value) { }

	[Address(RVA = "0x1C7AF80", Offset = "0x1C7A180", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[Token(Token = "0x600114B")]
	public void set_visualTreeAsset(VisualTreeAsset value) { }

	[Address(RVA = "0x1C7AFC0", Offset = "0x1C7A1C0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "SetupWorldSpaceSize", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001156")]
	public void set_worldSpaceSize(Vector2 value) { }

	[Address(RVA = "0x1C7AFB0", Offset = "0x1C7A1B0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIDocument), Member = "SetupWorldSpaceSize", ReturnType = typeof(void))]
	[Token(Token = "0x6001154")]
	public void set_worldSpaceSizeMode(WorldSpaceSizeMode value) { }

	[Address(RVA = "0x1C78E90", Offset = "0x1C78090", Length = "0x55F")]
	[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleTransformOrigin), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformOrigin)}, ReturnType = typeof(StyleTransformOrigin))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Rotate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Translate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetPosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(TransformOrigin), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Scale), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(UIDocument), Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6001170")]
	private void SetTransform() { }

	[Address(RVA = "0x1C793F0", Offset = "0x1C785F0", Length = "0x160")]
	[CalledBy(Type = typeof(UIDocument), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "RemoveFromHierarchy", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001179")]
	private void SetupFromHierarchy() { }

	[Address(RVA = "0x1C79560", Offset = "0x1C78760", Length = "0xF3")]
	[CalledBy(Type = typeof(UIDocument), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Position)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "SetupRootClassList", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIDocument), Member = "get_isTransformControlledByGameObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(UIDocument), Member = "AddChildAndInsertContentToVisualTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIDocument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600117F")]
	internal void SetupPosition() { }

	[Address(RVA = "0x1C79660", Offset = "0x1C78860", Length = "0x2E4")]
	[CalledBy(Type = typeof(UIDocument), Member = "RecreateUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ReactToHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleKeyword)}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(VisualElement), Member = "EnableInClassList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIDocument), Member = "SetupPosition", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "SetupWorldSpaceSize", ReturnType = typeof(void))]
	[Calls(Type = typeof(UIDocument), Member = "get_isWorldSpace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001180")]
	private void SetupRootClassList() { }

	[Address(RVA = "0x1C79950", Offset = "0x1C78B50", Length = "0x3C7")]
	[CalledBy(Type = typeof(UIDocument), Member = "set_worldSpaceSizeMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WorldSpaceSizeMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "set_worldSpaceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "SetupRootClassList", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VisualElement), Member = "get_style", ReturnType = typeof(IStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIDocument), Member = "get_isTransformControlledByGameObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleEnum`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "UnityEngine.UIElements.StyleEnum`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BF20")]
	[Calls(Type = typeof(StyleLength), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(StyleLength))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001181")]
	private void SetupWorldSpaceSize() { }

	[Address(RVA = "0x1C79D20", Offset = "0x1C78F20", Length = "0x12F")]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIDocument), Member = "ScaleAndFlipMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UIDocument), Member = "PivotOffset", ReturnType = typeof(Vector2))]
	[Token(Token = "0x6001176")]
	private Matrix4x4 TransformToGameObjectMatrix() { }

	[Address(RVA = "0x1C79E50", Offset = "0x1C79050", Length = "0xE5")]
	[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIDocument), Member = "UpdateRenderer", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.UIElements.PanelSettings+RuntimePanelAccess", Member = "get_panel", ReturnType = typeof(BaseRuntimePanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "MarkDirtyRepaint", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600116F")]
	private void UpdateIsWorldSpaceRootFlag() { }

	[Address(RVA = "0x1C79F40", Offset = "0x1C79140", Length = "0x360")]
	[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(UIDocument), Member = "UpdateIsWorldSpaceRootFlag", ReturnType = typeof(void))]
	[Calls(Type = typeof(Renderer), Member = "set_localBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(UIDocument), Member = "TransformToGameObjectMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UIDocument), Member = "SanitizeRendererBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(VisualElement), Member = "get_localBounds3D", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseRuntimePanel), Member = "get_drawsInCameras", ReturnType = typeof(bool))]
	[Calls(Type = typeof(VisualElement), Member = "get_panel", ReturnType = typeof(IPanel))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001169")]
	private void UpdateRenderer() { }

	[Address(RVA = "0x1C7A2B0", Offset = "0x1C794B0", Length = "0x4AA")]
	[CalledBy(Type = typeof(UIDocument), Member = "DoUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualElement), Member = "get_worldTransformRef", ReturnType = typeof(Matrix4x4&))]
	[Calls(Type = typeof(BoxCollider), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxCollider), Member = "set_center", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BoxCollider), Member = "get_size", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(BoxCollider), Member = "get_center", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Collider), Member = "set_isTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UIDocument), Member = "RemoveWorldSpaceCollider", ReturnType = typeof(void))]
	[Calls(Type = typeof(WorldSpaceInput), Member = "GetPicking3DLocalBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(VisualElement), Member = "get_worldBound", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(UIDocument), Member = "get_containerPanel", ReturnType = typeof(RuntimePanel))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600116C")]
	internal void UpdateWorldSpaceCollider(ColliderUpdateMode mode) { }

}

