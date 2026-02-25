namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000367")]
public class UIField : Instance, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000E7C")]
	public LuaEvent MouseUp; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000E7D")]
	public LuaEvent MouseDown; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SyncVar(hook = "SyncSetPositionOffset")]
	[Token(Token = "0x4000E7E")]
	private Vector2 positionOffset; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SyncVar(hook = "SyncSetSizeOffset")]
	[Token(Token = "0x4000E7F")]
	private Vector2 sizeOffset; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SyncVar(hook = "SyncSetPositionRelative")]
	[Token(Token = "0x4000E80")]
	private Vector2 positionRelative; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SyncVar(hook = "SyncSetSizeRelative")]
	[Token(Token = "0x4000E81")]
	private Vector2 sizeRelative; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SyncVar(hook = "SyncSetRotation")]
	[Token(Token = "0x4000E82")]
	private float rotation; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[SyncVar(hook = "SyncSetPivotPoint")]
	[Token(Token = "0x4000E83")]
	private Vector2 pivotPoint; //Field offset: 0x12C
	[FieldOffset(Offset = "0x134")]
	[SyncVar(hook = "SyncSetVisible")]
	[Token(Token = "0x4000E84")]
	private bool visible; //Field offset: 0x134
	[FieldOffset(Offset = "0x135")]
	[SyncVar(hook = "SyncSetClipDescendants")]
	[Token(Token = "0x4000E85")]
	private bool clipDescendants; //Field offset: 0x135
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000E86")]
	private RectTransform parentRect; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000E87")]
	private RectTransform recttransform; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000E88")]
	private SoftMask mask; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000E89")]
	private bool hasHVLayoutParent; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000E8A")]
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionOffset; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000E8B")]
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeOffset; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000E8C")]
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_positionRelative; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000E8D")]
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_sizeRelative; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000E8E")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_rotation; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000E8F")]
	public Action<Vector2, Vector2> _Mirror_SyncVarHookDelegate_pivotPoint; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000E90")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_visible; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000E91")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_clipDescendants; //Field offset: 0x190

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000ACA")]
	public bool ClipDescendants
	{
		[Address(RVA = "0x494600", Offset = "0x493800", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600240E")]
		 get { } //Length: 8
		[Address(RVA = "0x494720", Offset = "0x493920", Length = "0xDB")]
		[CalledBy(Type = typeof(UIField), Member = "SyncSetClipDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIFieldProxy), Member = "set_ClipDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600240F")]
		 set { } //Length: 219
	}

	[Token(Token = "0x17000AD2")]
	public bool NetworkclipDescendants
	{
		[Address(RVA = "0x494600", Offset = "0x493800", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002434")]
		 get { } //Length: 8
		[Address(RVA = "0x494800", Offset = "0x493A00", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002435")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000AD0")]
	public Vector2 NetworkpivotPoint
	{
		[Address(RVA = "0x494610", Offset = "0x493810", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002430")]
		 get { } //Length: 25
		[Address(RVA = "0x494870", Offset = "0x493A70", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[Token(Token = "0x6002431")]
		 set { } //Length: 108
	}

	[Token(Token = "0x17000ACB")]
	public Vector2 NetworkpositionOffset
	{
		[Address(RVA = "0x494630", Offset = "0x493830", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002426")]
		 get { } //Length: 25
		[Address(RVA = "0x4948E0", Offset = "0x493AE0", Length = "0x6C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002427")]
		 set { } //Length: 108
	}

	[Token(Token = "0x17000ACD")]
	public Vector2 NetworkpositionRelative
	{
		[Address(RVA = "0x494650", Offset = "0x493850", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600242A")]
		 get { } //Length: 25
		[Address(RVA = "0x494950", Offset = "0x493B50", Length = "0x6C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[DeduplicatedMethod]
		[Token(Token = "0x600242B")]
		 set { } //Length: 108
	}

	[Token(Token = "0x17000ACF")]
	public float Networkrotation
	{
		[Address(RVA = "0x424BF0", Offset = "0x423DF0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600242E")]
		 get { } //Length: 9
		[Address(RVA = "0x4949C0", Offset = "0x493BC0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x600242F")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000ACC")]
	public Vector2 NetworksizeOffset
	{
		[Address(RVA = "0x494670", Offset = "0x493870", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002428")]
		 get { } //Length: 25
		[Address(RVA = "0x494A30", Offset = "0x493C30", Length = "0x6C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002429")]
		 set { } //Length: 108
	}

	[Token(Token = "0x17000ACE")]
	public Vector2 NetworksizeRelative
	{
		[Address(RVA = "0x494690", Offset = "0x493890", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600242C")]
		 get { } //Length: 25
		[Address(RVA = "0x494AA0", Offset = "0x493CA0", Length = "0x6C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[DeduplicatedMethod]
		[Token(Token = "0x600242D")]
		 set { } //Length: 108
	}

	[Token(Token = "0x17000AD1")]
	public bool Networkvisible
	{
		[Address(RVA = "0x4946B0", Offset = "0x4938B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002432")]
		 get { } //Length: 8
		[Address(RVA = "0x494B10", Offset = "0x493D10", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002433")]
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AC8")]
	public Vector2 PivotPoint
	{
		[Address(RVA = "0x4946C0", Offset = "0x4938C0", Length = "0x27")]
		[CalledBy(Type = typeof(UIFieldProxy), Member = "get_PivotPoint", ReturnType = typeof(Vector2))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[Token(Token = "0x600240A")]
		 get { } //Length: 39
		[Address(RVA = "0x494B80", Offset = "0x493D80", Length = "0x95")]
		[CalledBy(Type = typeof(UIField), Member = "SyncSetPivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIFieldProxy), Member = "set_PivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600240B")]
		 set { } //Length: 149
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AC3")]
	public Vector2 PositionOffset
	{
		[Address(RVA = "0x494630", Offset = "0x493830", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002400")]
		 get { } //Length: 25
		[Address(RVA = "0x4948E0", Offset = "0x493AE0", Length = "0x6C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002401")]
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AC4")]
	public Vector2 PositionRelative
	{
		[Address(RVA = "0x494650", Offset = "0x493850", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002402")]
		 get { } //Length: 25
		[Address(RVA = "0x494950", Offset = "0x493B50", Length = "0x6C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002403")]
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AC5")]
	public float Rotation
	{
		[Address(RVA = "0x4946F0", Offset = "0x4938F0", Length = "0x2F")]
		[CalledBy(Type = typeof(UIFieldProxy), Member = "get_Rotation", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002404")]
		 get { } //Length: 47
		[Address(RVA = "0x494C20", Offset = "0x493E20", Length = "0xA9")]
		[CalledBy(Type = typeof(UIField), Member = "SyncSetRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIFieldProxy), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002405")]
		 set { } //Length: 169
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AC6")]
	public Vector2 SizeOffset
	{
		[Address(RVA = "0x494670", Offset = "0x493870", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002406")]
		 get { } //Length: 25
		[Address(RVA = "0x494A30", Offset = "0x493C30", Length = "0x6C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002407")]
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AC7")]
	public Vector2 SizeRelative
	{
		[Address(RVA = "0x494690", Offset = "0x493890", Length = "0x19")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002408")]
		 get { } //Length: 25
		[Address(RVA = "0x494AA0", Offset = "0x493CA0", Length = "0x6C")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002409")]
		 set { } //Length: 108
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AC9")]
	public bool Visible
	{
		[Address(RVA = "0x4946B0", Offset = "0x4938B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600240C")]
		 get { } //Length: 8
		[Address(RVA = "0x494CD0", Offset = "0x493ED0", Length = "0x7A")]
		[CalledBy(Type = typeof(UIField), Member = "SyncSetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIField), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHorizontalLayout), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIHVLayout), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIImage), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIView), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIFieldProxy), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(UIField), Member = "UpdateVisibility", ReturnType = typeof(void))]
		[Token(Token = "0x600240D")]
		 set { } //Length: 122
	}

	[Address(RVA = "0x494220", Offset = "0x493420", Length = "0x3DD")]
	[CalledBy(Type = typeof(UIHVLayout), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LuaEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002423")]
	public UIField() { }

	[Address(RVA = "0x493E30", Offset = "0x493030", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002424")]
	private void <Awake>b__46_0() { }

	[Address(RVA = "0x492FC0", Offset = "0x4921C0", Length = "0x12E")]
	[CalledBy(Type = typeof(UIHorizontalLayout), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIVerticalLayout), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Instance), Member = "add__ParentChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002418")]
	protected virtual void Awake() { }

	[Address(RVA = "0x4930F0", Offset = "0x4922F0", Length = "0x2B8")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Calls(Type = typeof(UIField), Member = "set_ClipDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIField), Member = "set_PivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(UIField), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Instance), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[Token(Token = "0x600241E")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x4933B0", Offset = "0x4925B0", Length = "0x3F0")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(System.Action`2<UnityEngine.Vector2, UnityEngine.Vector2>), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002437")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x494600", Offset = "0x493800", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600240E")]
	public bool get_ClipDescendants() { }

	[Address(RVA = "0x494600", Offset = "0x493800", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002434")]
	public bool get_NetworkclipDescendants() { }

	[Address(RVA = "0x494610", Offset = "0x493810", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002430")]
	public Vector2 get_NetworkpivotPoint() { }

	[Address(RVA = "0x494630", Offset = "0x493830", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002426")]
	public Vector2 get_NetworkpositionOffset() { }

	[Address(RVA = "0x494650", Offset = "0x493850", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600242A")]
	public Vector2 get_NetworkpositionRelative() { }

	[Address(RVA = "0x424BF0", Offset = "0x423DF0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600242E")]
	public float get_Networkrotation() { }

	[Address(RVA = "0x494670", Offset = "0x493870", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002428")]
	public Vector2 get_NetworksizeOffset() { }

	[Address(RVA = "0x494690", Offset = "0x493890", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600242C")]
	public Vector2 get_NetworksizeRelative() { }

	[Address(RVA = "0x4946B0", Offset = "0x4938B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002432")]
	public bool get_Networkvisible() { }

	[Address(RVA = "0x4946C0", Offset = "0x4938C0", Length = "0x27")]
	[CalledBy(Type = typeof(UIFieldProxy), Member = "get_PivotPoint", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Token(Token = "0x600240A")]
	public Vector2 get_PivotPoint() { }

	[Address(RVA = "0x494630", Offset = "0x493830", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002400")]
	public Vector2 get_PositionOffset() { }

	[Address(RVA = "0x494650", Offset = "0x493850", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002402")]
	public Vector2 get_PositionRelative() { }

	[Address(RVA = "0x4946F0", Offset = "0x4938F0", Length = "0x2F")]
	[CalledBy(Type = typeof(UIFieldProxy), Member = "get_Rotation", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_eulerAngles", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002404")]
	public float get_Rotation() { }

	[Address(RVA = "0x494670", Offset = "0x493870", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002406")]
	public Vector2 get_SizeOffset() { }

	[Address(RVA = "0x494690", Offset = "0x493890", Length = "0x19")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002408")]
	public Vector2 get_SizeRelative() { }

	[Address(RVA = "0x4946B0", Offset = "0x4938B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600240C")]
	public bool get_Visible() { }

	[Address(RVA = "0x400CA0", Offset = "0x3FFEA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600241C")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x4937A0", Offset = "0x4929A0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002422")]
	public override void OnPointerDown(PointerEventData eventData) { }

	[Address(RVA = "0x493800", Offset = "0x492A00", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600241F")]
	public override void OnPointerEnter(PointerEventData eventData) { }

	[Address(RVA = "0x493860", Offset = "0x492A60", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002420")]
	public override void OnPointerExit(PointerEventData eventData) { }

	[Address(RVA = "0x4938C0", Offset = "0x492AC0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002421")]
	public override void OnPointerUp(PointerEventData eventData) { }

	[Address(RVA = "0x493920", Offset = "0x492B20", Length = "0x87")]
	[CalledBy(Type = typeof(UIImage), Member = "OnShow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "OnShow", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Instance), Member = "OnShow", ReturnType = typeof(void))]
	[Token(Token = "0x600241D")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x4939B0", Offset = "0x492BB0", Length = "0x239")]
	[CalledBy(Type = typeof(UIHVLayout), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Instance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002436")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x494720", Offset = "0x493920", Length = "0xDB")]
	[CalledBy(Type = typeof(UIField), Member = "SyncSetClipDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIFieldProxy), Member = "set_ClipDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600240F")]
	public void set_ClipDescendants(bool value) { }

	[Address(RVA = "0x494800", Offset = "0x493A00", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002435")]
	public void set_NetworkclipDescendants(in bool value) { }

	[Address(RVA = "0x494870", Offset = "0x493A70", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Token(Token = "0x6002431")]
	public void set_NetworkpivotPoint(in Vector2 value) { }

	[Address(RVA = "0x4948E0", Offset = "0x493AE0", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002427")]
	public void set_NetworkpositionOffset(in Vector2 value) { }

	[Address(RVA = "0x494950", Offset = "0x493B50", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[DeduplicatedMethod]
	[Token(Token = "0x600242B")]
	public void set_NetworkpositionRelative(in Vector2 value) { }

	[Address(RVA = "0x4949C0", Offset = "0x493BC0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x600242F")]
	public void set_Networkrotation(in float value) { }

	[Address(RVA = "0x494A30", Offset = "0x493C30", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002429")]
	public void set_NetworksizeOffset(in Vector2 value) { }

	[Address(RVA = "0x494AA0", Offset = "0x493CA0", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[DeduplicatedMethod]
	[Token(Token = "0x600242D")]
	public void set_NetworksizeRelative(in Vector2 value) { }

	[Address(RVA = "0x494B10", Offset = "0x493D10", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002433")]
	public void set_Networkvisible(in bool value) { }

	[Address(RVA = "0x494B80", Offset = "0x493D80", Length = "0x95")]
	[CalledBy(Type = typeof(UIField), Member = "SyncSetPivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIFieldProxy), Member = "set_PivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600240B")]
	public void set_PivotPoint(Vector2 value) { }

	[Address(RVA = "0x4948E0", Offset = "0x493AE0", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002401")]
	public void set_PositionOffset(Vector2 value) { }

	[Address(RVA = "0x494950", Offset = "0x493B50", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002403")]
	public void set_PositionRelative(Vector2 value) { }

	[Address(RVA = "0x494C20", Offset = "0x493E20", Length = "0xA9")]
	[CalledBy(Type = typeof(UIField), Member = "SyncSetRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIFieldProxy), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002405")]
	public void set_Rotation(float value) { }

	[Address(RVA = "0x494A30", Offset = "0x493C30", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002407")]
	public void set_SizeOffset(Vector2 value) { }

	[Address(RVA = "0x494AA0", Offset = "0x493CA0", Length = "0x6C")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002409")]
	public void set_SizeRelative(Vector2 value) { }

	[Address(RVA = "0x494CD0", Offset = "0x493ED0", Length = "0x7A")]
	[CalledBy(Type = typeof(UIField), Member = "SyncSetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIField), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIField), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHorizontalLayout), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIHVLayout), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIImage), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIView), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIFieldProxy), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(UIField), Member = "UpdateVisibility", ReturnType = typeof(void))]
	[Token(Token = "0x600240D")]
	public void set_Visible(bool value) { }

	[Address(RVA = "0x493BF0", Offset = "0x492DF0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600241A")]
	protected virtual void Start() { }

	[Address(RVA = "0x493C20", Offset = "0x492E20", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_ClipDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002417")]
	private void SyncSetClipDescendants(bool oldValue, bool newValue) { }

	[Address(RVA = "0x493C30", Offset = "0x492E30", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_PivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002415")]
	private void SyncSetPivotPoint(Vector2 oldValue, Vector2 newValue) { }

	[Address(RVA = "0x493C50", Offset = "0x492E50", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Token(Token = "0x6002410")]
	private void SyncSetPositionOffset(Vector2 oldValue, Vector2 newValue) { }

	[Address(RVA = "0x493CC0", Offset = "0x492EC0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Token(Token = "0x6002412")]
	private void SyncSetPositionRelative(Vector2 oldValue, Vector2 newValue) { }

	[Address(RVA = "0x493D30", Offset = "0x492F30", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002414")]
	private void SyncSetRotation(float oldValue, float newValue) { }

	[Address(RVA = "0x493D40", Offset = "0x492F40", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Token(Token = "0x6002411")]
	private void SyncSetSizeOffset(Vector2 oldValue, Vector2 newValue) { }

	[Address(RVA = "0x493DB0", Offset = "0x492FB0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C240")]
	[Token(Token = "0x6002413")]
	private void SyncSetSizeRelative(Vector2 oldValue, Vector2 newValue) { }

	[Address(RVA = "0x493E20", Offset = "0x493020", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002416")]
	private void SyncSetVisible(bool oldValue, bool newValue) { }

	[Address(RVA = "0x493FF0", Offset = "0x4931F0", Length = "0x220")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600241B")]
	private void Update() { }

	[Address(RVA = "0x493F20", Offset = "0x493120", Length = "0xC6")]
	[CalledBy(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002419")]
	private void UpdateVisibility() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002425")]
	public virtual bool Weaved() { }

}

