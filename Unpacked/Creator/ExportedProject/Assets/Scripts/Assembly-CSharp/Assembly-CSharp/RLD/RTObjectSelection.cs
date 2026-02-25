namespace RLD;

[Token(Token = "0x20002C2")]
public class RTObjectSelection : MonoSingleton<RTObjectSelection>
{
	[CompilerGenerated]
	[Token(Token = "0x20002C5")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AB3")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000AB4")]
		public static Predicate<GameObject> <>9__155_0; //Field offset: 0x8
		[Token(Token = "0x4000AB5")]
		public static Predicate<GameObject> <>9__155_1; //Field offset: 0x10

		[Address(RVA = "0x3FF950", Offset = "0x3FEB50", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001A32")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A33")]
		public <>c() { }

		[Address(RVA = "0x3FF590", Offset = "0x3FE790", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A34")]
		internal bool <RemoveNullAndInactiveObjectRefs>b__155_0(GameObject item) { }

		[Address(RVA = "0x3FF600", Offset = "0x3FE800", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A35")]
		internal bool <RemoveNullAndInactiveObjectRefs>b__155_1(GameObject item) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20002C6")]
	private sealed class <>c__DisplayClass144_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AB6")]
		public RTObjectSelection <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AB7")]
		public QueryConfig boundsQConfig; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A36")]
		public <>c__DisplayClass144_0() { }

		[Address(RVA = "0x3FF6E0", Offset = "0x3FE8E0", Length = "0x1F8")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
		[Calls(Type = typeof(ObjectBounds), Member = "CalcScreenRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(QueryConfig)}, ReturnType = typeof(Rect))]
		[Calls(Type = typeof(RectEx), Member = "GetCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
		[Calls(Type = typeof(RectEx), Member = "ContainsAllPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector2>)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Rect), Member = "Overlaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001A37")]
		internal bool <PerformMultiSelect>b__0(GameObject item) { }

	}

	[Token(Token = "0x20002C4")]
	private struct CyclicalClickSelectInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AB1")]
		public int LastSelectedIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AB2")]
		public GameObject LastPickedObject; //Field offset: 0x8

	}

	[Flags]
	[Token(Token = "0x20002C3")]
	private enum SelectRestrictFlags
	{
		None = 0,
		ObjectLayer = 1,
		ObjectType = 2,
		Object = 4,
		SelectionListener = 8,
		All = 15,
	}

	[Token(Token = "0x4000A7C")]
	private static readonly int _objectPickDeviceBtnIndex; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A7D")]
	private ObjectSelectionManipSessionBeginHandler ManipSessionBegin; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A7E")]
	private ObjectSelectionManipSessionEndHandler ManipSessionEnd; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A7F")]
	private ObjectSelectionCanClickSelectDeselectHandler CanClickSelectDeselect; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A80")]
	private ObjectSelectionCanMultiSelectDeselectHandler CanMultiSelectDeselect; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A81")]
	private ObjectSelectionChangedHandler Changed; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A82")]
	private ObjectSelectionWillBeDeletedHandler WillBeDeleted; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A83")]
	private ObjectSelectionDeletedHandler Deleted; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A84")]
	private ObjectSelectionWillBeDuplicatedHandler WillBeDuplicated; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A85")]
	private ObjectSelectionDuplicatedHandler Duplicated; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A86")]
	private ObjectSelectionRotatedHandler Rotated; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A87")]
	private ObjectSelectionPreSelectCustomizeHandler PreSelectCustomize; //Field offset: 0x70
	[CompilerGenerated]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A88")]
	private ObjectSelectionPreDeselectCustomizeHandler PreDeselectCustomize; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A89")]
	private ObjectSelectionEnabled Enabled; //Field offset: 0x80
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A8A")]
	private ObjectSelectionDisabled Disabled; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A8B")]
	private List<GameObject> _visibleObjectBuffer; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A8C")]
	private List<GameObject> _overlappedObjectBuffer; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A8D")]
	private List<GameObjectRayHit> _objectHitBuffer; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000A8E")]
	private bool _isEnabled; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A8F")]
	private List<Camera> _renderIgnoreCameras; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A90")]
	private List<GameObject> _selectedObjects; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000A91")]
	private MultiSelectShape _multiSelectShape; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000A92")]
	private ObjectSelectionSnapshot _multiSelectPreChangeSnapshot; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000A93")]
	private bool _wasSelectionChangedViaMultiSelectShape; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD1")]
	[Token(Token = "0x4000A94")]
	private bool _willBeDeleted; //Field offset: 0xD1
	[FieldOffset(Offset = "0xD2")]
	[Token(Token = "0x4000A95")]
	private bool _doingPreSelectCustomize; //Field offset: 0xD2
	[FieldOffset(Offset = "0xD3")]
	[Token(Token = "0x4000A96")]
	private bool _doingPreDeselectCustomize; //Field offset: 0xD3
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x4000A97")]
	private bool _firingSelectionChanged; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000A98")]
	private ObjectSelectionManipSession _activeManipSession; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000A99")]
	private CyclicalClickSelectInfo _cyclicalClickSelectInfo; //Field offset: 0xE0
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000A9A")]
	private ObjectSelectionHotkeys _hotkeys; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000A9B")]
	private ObjectSelectionSettings _settings; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000A9C")]
	private ObjectSelectionLookAndFeel _lookAndFeel; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000A9D")]
	private ObjectSelectionRotationSettings _rotationSettings; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000A9E")]
	private ObjectSelectionRotationHotkeys _rotationHotkeys; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000A9F")]
	private DeviceObjectGrabSession _grabSession; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4000AA0")]
	private ObjectGrabSettings _grabSettings; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000AA1")]
	private ObjectGrabLookAndFeel _grabLookAndFeel; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x4000AA2")]
	private ObjectGrabHotkeys _grabHotkeys; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000AA3")]
	private ObjectGridSnapSession _gridSnapSession; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000AA4")]
	private ObjectGridSnapLookAndFeel _gridSnapLookAndFeel; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x4000AA5")]
	private ObjectGridSnapHotkeys _gridSnapHotkeys; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000AA6")]
	private Object2ObjectSnapSession _object2ObjectSnapSession; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x4000AA7")]
	private Object2ObjectSnapSettings _object2ObjectSnapSettings; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x4000AA8")]
	private Object2ObjectSnapHotkeys _object2ObjectSnapHotkeys; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x4000AA9")]
	private EditorToolbar _settingsToolbar; //Field offset: 0x168

	[Token(Token = "0x1400003C")]
	public event ObjectSelectionCanClickSelectDeselectHandler CanClickSelectDeselect
	{
		[Address(RVA = "0x3FDF90", Offset = "0x3FD190", Length = "0x9E")]
		[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PrefabSpawnSnap), Member = "OnAppInitialized", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019D5")]
		 add { } //Length: 158
		[Address(RVA = "0x3FE9B0", Offset = "0x3FDBB0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019D6")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400003D")]
	public event ObjectSelectionCanMultiSelectDeselectHandler CanMultiSelectDeselect
	{
		[Address(RVA = "0x3FE030", Offset = "0x3FD230", Length = "0x9E")]
		[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(PrefabSpawnSnap), Member = "OnAppInitialized", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019D7")]
		 add { } //Length: 158
		[Address(RVA = "0x3FEA50", Offset = "0x3FDC50", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019D8")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400003E")]
	public event ObjectSelectionChangedHandler Changed
	{
		[Address(RVA = "0x3FE0D0", Offset = "0x3FD2D0", Length = "0x9E")]
		[CalledBy(Type = typeof(CreatorController), Member = "Awake", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019D9")]
		 add { } //Length: 158
		[Address(RVA = "0x3FEAF0", Offset = "0x3FDCF0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019DA")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000040")]
	public event ObjectSelectionDeletedHandler Deleted
	{
		[Address(RVA = "0x3FE170", Offset = "0x3FD370", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019DD")]
		 add { } //Length: 158
		[Address(RVA = "0x3FEB90", Offset = "0x3FDD90", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019DE")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000047")]
	public event ObjectSelectionDisabled Disabled
	{
		[Address(RVA = "0x3FE210", Offset = "0x3FD410", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019EB")]
		 add { } //Length: 162
		[Address(RVA = "0x3FEC30", Offset = "0x3FDE30", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019EC")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x14000042")]
	public event ObjectSelectionDuplicatedHandler Duplicated
	{
		[Address(RVA = "0x3FE2C0", Offset = "0x3FD4C0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E1")]
		 add { } //Length: 158
		[Address(RVA = "0x3FECE0", Offset = "0x3FDEE0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E2")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000046")]
	public event ObjectSelectionEnabled Enabled
	{
		[Address(RVA = "0x3FE360", Offset = "0x3FD560", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E9")]
		 add { } //Length: 162
		[Address(RVA = "0x3FED80", Offset = "0x3FDF80", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019EA")]
		 remove { } //Length: 162
	}

	[Token(Token = "0x1400003A")]
	public event ObjectSelectionManipSessionBeginHandler ManipSessionBegin
	{
		[Address(RVA = "0x3FE410", Offset = "0x3FD610", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019D1")]
		 add { } //Length: 158
		[Address(RVA = "0x3FEE30", Offset = "0x3FE030", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019D2")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400003B")]
	public event ObjectSelectionManipSessionEndHandler ManipSessionEnd
	{
		[Address(RVA = "0x3FE4B0", Offset = "0x3FD6B0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019D3")]
		 add { } //Length: 158
		[Address(RVA = "0x3FEED0", Offset = "0x3FE0D0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019D4")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000045")]
	public event ObjectSelectionPreDeselectCustomizeHandler PreDeselectCustomize
	{
		[Address(RVA = "0x3FE550", Offset = "0x3FD750", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E7")]
		 add { } //Length: 158
		[Address(RVA = "0x3FEF70", Offset = "0x3FE170", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E8")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000044")]
	public event ObjectSelectionPreSelectCustomizeHandler PreSelectCustomize
	{
		[Address(RVA = "0x3FE5F0", Offset = "0x3FD7F0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E5")]
		 add { } //Length: 158
		[Address(RVA = "0x3FF010", Offset = "0x3FE210", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E6")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000043")]
	public event ObjectSelectionRotatedHandler Rotated
	{
		[Address(RVA = "0x3FE690", Offset = "0x3FD890", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E3")]
		 add { } //Length: 158
		[Address(RVA = "0x3FF0B0", Offset = "0x3FE2B0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E4")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x1400003F")]
	public event ObjectSelectionWillBeDeletedHandler WillBeDeleted
	{
		[Address(RVA = "0x3FE730", Offset = "0x3FD930", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019DB")]
		 add { } //Length: 158
		[Address(RVA = "0x3FF150", Offset = "0x3FE350", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019DC")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000041")]
	public event ObjectSelectionWillBeDuplicatedHandler WillBeDuplicated
	{
		[Address(RVA = "0x3FE7D0", Offset = "0x3FD9D0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019DF")]
		 add { } //Length: 158
		[Address(RVA = "0x3FF1F0", Offset = "0x3FE3F0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60019E0")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000895")]
	public ObjectSelectionManipSession ActiveManipSession
	{
		[Address(RVA = "0x3FE870", Offset = "0x3FDA70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60019FD")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700088E")]
	public ObjectGrabHotkeys GrabHotkeys
	{
		[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F6")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700088F")]
	public ObjectGrabLookAndFeel GrabLookAndFeel
	{
		[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F7")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700088D")]
	public ObjectGrabSettings GrabSettings
	{
		[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F5")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000891")]
	public ObjectGridSnapHotkeys GridSnapHotkeys
	{
		[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F9")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000890")]
	public ObjectGridSnapLookAndFeel GridSnapLookAndFeel
	{
		[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F8")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000888")]
	public ObjectSelectionHotkeys Hotkeys
	{
		[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000885")]
	public bool IsEnabled
	{
		[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019ED")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000896")]
	public bool IsGrabSessionActive
	{
		[Address(RVA = "0x3FE890", Offset = "0x3FDA90", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60019FE")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000897")]
	public bool IsGridSnapSessionActive
	{
		[Address(RVA = "0x3FE8A0", Offset = "0x3FDAA0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60019FF")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000894")]
	public bool IsManipSessionActive
	{
		[Address(RVA = "0x3FE8B0", Offset = "0x3FDAB0", Length = "0xB")]
		[CalledBy(Type = typeof(RLDApp), Member = "OnCanUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoRedoOpType), typeof(YesNoAnswer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60019FC")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000886")]
	public bool IsMultiSelectShapeVisible
	{
		[Address(RVA = "0x3FE8C0", Offset = "0x3FDAC0", Length = "0x1E")]
		[CalledBy(Type = typeof(RLDApp), Member = "OnCanUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoRedoOpType), typeof(YesNoAnswer)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RLDApp), Member = "OnCanDoGizmoHoverUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(YesNoAnswer)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019EE")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000898")]
	public bool IsObject2ObjectSnapSessionActive
	{
		[Address(RVA = "0x3FE8E0", Offset = "0x3FDAE0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001A00")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700088A")]
	public ObjectSelectionLookAndFeel LookAndFeel
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000887")]
	public int NumSelectedObjects
	{
		[Address(RVA = "0x3FE8F0", Offset = "0x3FDAF0", Length = "0x3F")]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "Delete", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "CanBeDeleted", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "CanBeDuplicated", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "Duplicate", ReturnType = typeof(ObjectSelectionDuplicationResult))]
		[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60019EF")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000893")]
	public Object2ObjectSnapHotkeys Object2ObjectSnapHotkeys
	{
		[Address(RVA = "0x3FE930", Offset = "0x3FDB30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60019FB")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000892")]
	public Object2ObjectSnapSettings Object2ObjectSnapSettings
	{
		[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019FA")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700088C")]
	public ObjectSelectionRotationHotkeys RotationHotkeys
	{
		[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700088B")]
	public ObjectSelectionRotationSettings RotationSettings
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000899")]
	public List<GameObject> SelectedObjects
	{
		[Address(RVA = "0x3FE940", Offset = "0x3FDB40", Length = "0x6B")]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTObjectSelection), Member = "HandleUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionSnapshot), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "OnPostDragEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "GetSelectedInstances", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
		[CalledBy(Type = typeof(CreatorController), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001A01")]
		 get { } //Length: 107
	}

	[Token(Token = "0x17000889")]
	public ObjectSelectionSettings Settings
	{
		[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60019F1")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x3FD4F0", Offset = "0x3FC6F0", Length = "0xA97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectGrabLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EditorToolbar), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EditorToolbarTab[]), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(EditorToolbarTab), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Object2ObjectSnapHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object2ObjectSnapSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGridSnapHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGridSnapLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGridSnapSession), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGrabHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGrabSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionRotationHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectKeyRotationSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorEx), Member = "FromByteValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6001A31")]
	public RTObjectSelection() { }

	[Address(RVA = "0x3FDF90", Offset = "0x3FD190", Length = "0x9E")]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PrefabSpawnSnap), Member = "OnAppInitialized", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019D5")]
	public void add_CanClickSelectDeselect(ObjectSelectionCanClickSelectDeselectHandler value) { }

	[Address(RVA = "0x3FE030", Offset = "0x3FD230", Length = "0x9E")]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PrefabSpawnSnap), Member = "OnAppInitialized", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019D7")]
	public void add_CanMultiSelectDeselect(ObjectSelectionCanMultiSelectDeselectHandler value) { }

	[Address(RVA = "0x3FE0D0", Offset = "0x3FD2D0", Length = "0x9E")]
	[CalledBy(Type = typeof(CreatorController), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019D9")]
	public void add_Changed(ObjectSelectionChangedHandler value) { }

	[Address(RVA = "0x3FE170", Offset = "0x3FD370", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019DD")]
	public void add_Deleted(ObjectSelectionDeletedHandler value) { }

	[Address(RVA = "0x3FE210", Offset = "0x3FD410", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019EB")]
	public void add_Disabled(ObjectSelectionDisabled value) { }

	[Address(RVA = "0x3FE2C0", Offset = "0x3FD4C0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E1")]
	public void add_Duplicated(ObjectSelectionDuplicatedHandler value) { }

	[Address(RVA = "0x3FE360", Offset = "0x3FD560", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E9")]
	public void add_Enabled(ObjectSelectionEnabled value) { }

	[Address(RVA = "0x3FE410", Offset = "0x3FD610", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019D1")]
	public void add_ManipSessionBegin(ObjectSelectionManipSessionBeginHandler value) { }

	[Address(RVA = "0x3FE4B0", Offset = "0x3FD6B0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019D3")]
	public void add_ManipSessionEnd(ObjectSelectionManipSessionEndHandler value) { }

	[Address(RVA = "0x3FE550", Offset = "0x3FD750", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E7")]
	public void add_PreDeselectCustomize(ObjectSelectionPreDeselectCustomizeHandler value) { }

	[Address(RVA = "0x3FE5F0", Offset = "0x3FD7F0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E5")]
	public void add_PreSelectCustomize(ObjectSelectionPreSelectCustomizeHandler value) { }

	[Address(RVA = "0x3FE690", Offset = "0x3FD890", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E3")]
	public void add_Rotated(ObjectSelectionRotatedHandler value) { }

	[Address(RVA = "0x3FE730", Offset = "0x3FD930", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019DB")]
	public void add_WillBeDeleted(ObjectSelectionWillBeDeletedHandler value) { }

	[Address(RVA = "0x3FE7D0", Offset = "0x3FD9D0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019DF")]
	public void add_WillBeDuplicated(ObjectSelectionWillBeDuplicatedHandler value) { }

	[Address(RVA = "0x3F5900", Offset = "0x3F4B00", Length = "0xEC")]
	[CalledBy(Type = typeof(RTSceneGizmoCamera), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001A05")]
	public void AddRenderIgnoreCamera(Camera camera) { }

	[Address(RVA = "0x3F59F0", Offset = "0x3F4BF0", Length = "0x3B3")]
	[CalledBy(Type = typeof(ClipboardController), Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "GroupSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "UngroupSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(PostObjectSelectionChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(RTObjectSelection), Member = "SelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectSelectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "CanSelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SelectRestrictFlags), typeof(ObjectSelectReason)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "Snapshot", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTObjectSelection), Member = "IsObjectSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A0A")]
	public void AppendObjects(List<GameObject> gameObjects, bool allowUndoRedo) { }

	[Address(RVA = "0x3F5DB0", Offset = "0x3F4FB0", Length = "0xBB")]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A03")]
	public void AttachGizmoController(IObjectCollectionGizmoController gizmoController) { }

	[Address(RVA = "0x3F5E70", Offset = "0x3F5070", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_NumSelectedObjects", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A10")]
	public bool CanBeDeleted() { }

	[Address(RVA = "0x3F5EC0", Offset = "0x3F50C0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_NumSelectedObjects", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A11")]
	public bool CanBeDuplicated() { }

	[Address(RVA = "0x3F5F20", Offset = "0x3F5120", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A12")]
	public bool CanBeModifiedByAPI() { }

	[Address(RVA = "0x3F5F60", Offset = "0x3F5160", Length = "0x391")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "AppendObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "FilterByRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(SelectRestrictFlags), typeof(ObjectSelectReason)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "FilterByRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>), typeof(SelectRestrictFlags)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GameObjectEx), Member = "GetGameObjectType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(GameObjectType))]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A22")]
	private bool CanSelectObject(GameObject gameObject, SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason) { }

	[Address(RVA = "0x3F6500", Offset = "0x3F5700", Length = "0x311")]
	[CalledBy(Type = typeof(CreatorThumbnailGenerator), Member = "GenerateThumbnail", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(Texture2D))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(CreatorController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DoLoadMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "ClearWorkspace", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "ToolboxModelAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Model)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "UngroupSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "GroupSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DeleteSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "GameLoaded", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadMapFromFile>d__87", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ClipboardController), Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DoImportModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(PostObjectSelectionChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "DeselectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "Snapshot", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_SelectedObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A0D")]
	public void ClearSelection(bool allowUndoRedo) { }

	[Address(RVA = "0x3F6300", Offset = "0x3F5500", Length = "0x1FF")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_SelectedObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001A25")]
	private void ClearSelection(ObjectDeselectReason deselectReason) { }

	[Address(RVA = "0x3F6820", Offset = "0x3F5A20", Length = "0x501")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DeleteSelectedObjectsAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "DeselectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "Snapshot", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetAllChildrenAndSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_NumSelectedObjects", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001A0E")]
	public void Delete() { }

	[Address(RVA = "0x3F6D30", Offset = "0x3F5F30", Length = "0xD7")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "RemoveObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Delete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "ForceDelete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "HandleUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionSnapshot), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A24")]
	private void DeselectObject(GameObject gameObject, ObjectDeselectReason deselectReason) { }

	[Address(RVA = "0x3F6E10", Offset = "0x3F6010", Length = "0x192")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A1F")]
	private List<GameObject> DoPreDeselectCustomize(List<GameObject> toBeDeselected, ObjectDeselectReason deselectReason) { }

	[Address(RVA = "0x3F6FB0", Offset = "0x3F61B0", Length = "0x140")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A1E")]
	private ObjectPreSelectCustomizeInfo DoPreSelectCustomize(List<GameObject> toBeSelected, ObjectSelectReason selectReason) { }

	[Address(RVA = "0x3F7100", Offset = "0x3F6300", Length = "0x341")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DuplicateObjectsAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(DuplicateObjectsAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(LayerEx), Member = "IsLayerBitSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_NumSelectedObjects", ReturnType = typeof(int))]
	[Calls(Type = typeof(DuplicateObjectsAction), Member = "get_DuplicateResult", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(ObjectSelectionDuplicationResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A13")]
	public ObjectSelectionDuplicationResult Duplicate() { }

	[Address(RVA = "0x3F7450", Offset = "0x3F6650", Length = "0x25A")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(RTObjectSelection), Member = "CanSelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SelectRestrictFlags), typeof(ObjectSelectReason)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A20")]
	private List<GameObject> FilterByRestrictions(IEnumerable<GameObject> gameObjects, SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason) { }

	[Address(RVA = "0x3F76B0", Offset = "0x3F68B0", Length = "0x1C0")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelection), Member = "CanSelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SelectRestrictFlags), typeof(ObjectSelectReason)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001A21")]
	private List<GameObjectRayHit> FilterByRestrictions(List<GameObjectRayHit> objectHits, SelectRestrictFlags restrictFlags) { }

	[Address(RVA = "0x3F7880", Offset = "0x3F6A80", Length = "0x472")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "DeselectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObjectEx), Member = "GetAllChildrenAndSelf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGridSnapSession), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001A0F")]
	public void ForceDelete() { }

	[Address(RVA = "0x3FE870", Offset = "0x3FDA70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60019FD")]
	public ObjectSelectionManipSession get_ActiveManipSession() { }

	[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F6")]
	public ObjectGrabHotkeys get_GrabHotkeys() { }

	[Address(RVA = "0x3F5840", Offset = "0x3F4A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F7")]
	public ObjectGrabLookAndFeel get_GrabLookAndFeel() { }

	[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F5")]
	public ObjectGrabSettings get_GrabSettings() { }

	[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F9")]
	public ObjectGridSnapHotkeys get_GridSnapHotkeys() { }

	[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F8")]
	public ObjectGridSnapLookAndFeel get_GridSnapLookAndFeel() { }

	[Address(RVA = "0x3CBD70", Offset = "0x3CAF70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F0")]
	public ObjectSelectionHotkeys get_Hotkeys() { }

	[Address(RVA = "0x2FDE10", Offset = "0x2FD010", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019ED")]
	public bool get_IsEnabled() { }

	[Address(RVA = "0x3FE890", Offset = "0x3FDA90", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60019FE")]
	public bool get_IsGrabSessionActive() { }

	[Address(RVA = "0x3FE8A0", Offset = "0x3FDAA0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60019FF")]
	public bool get_IsGridSnapSessionActive() { }

	[Address(RVA = "0x3FE8B0", Offset = "0x3FDAB0", Length = "0xB")]
	[CalledBy(Type = typeof(RLDApp), Member = "OnCanUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoRedoOpType), typeof(YesNoAnswer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60019FC")]
	public bool get_IsManipSessionActive() { }

	[Address(RVA = "0x3FE8C0", Offset = "0x3FDAC0", Length = "0x1E")]
	[CalledBy(Type = typeof(RLDApp), Member = "OnCanUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoRedoOpType), typeof(YesNoAnswer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RLDApp), Member = "OnCanDoGizmoHoverUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(YesNoAnswer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019EE")]
	public bool get_IsMultiSelectShapeVisible() { }

	[Address(RVA = "0x3FE8E0", Offset = "0x3FDAE0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A00")]
	public bool get_IsObject2ObjectSnapSessionActive() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F2")]
	public ObjectSelectionLookAndFeel get_LookAndFeel() { }

	[Address(RVA = "0x3FE8F0", Offset = "0x3FDAF0", Length = "0x3F")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Delete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "CanBeDeleted", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "CanBeDuplicated", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Duplicate", ReturnType = typeof(ObjectSelectionDuplicationResult))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60019EF")]
	public int get_NumSelectedObjects() { }

	[Address(RVA = "0x3FE930", Offset = "0x3FDB30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60019FB")]
	public Object2ObjectSnapHotkeys get_Object2ObjectSnapHotkeys() { }

	[Address(RVA = "0x3D66B0", Offset = "0x3D58B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019FA")]
	public Object2ObjectSnapSettings get_Object2ObjectSnapSettings() { }

	[Address(RVA = "0x3F58A0", Offset = "0x3F4AA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F4")]
	public ObjectSelectionRotationHotkeys get_RotationHotkeys() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F3")]
	public ObjectSelectionRotationSettings get_RotationSettings() { }

	[Address(RVA = "0x3FE940", Offset = "0x3FDB40", Length = "0x6B")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "HandleUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionSnapshot), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "OnPostDragEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "GetSelectedInstances", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
	[CalledBy(Type = typeof(CreatorController), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001A01")]
	public List<GameObject> get_SelectedObjects() { }

	[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019F1")]
	public ObjectSelectionSettings get_Settings() { }

	[Address(RVA = "0x3F7D00", Offset = "0x3F6F00", Length = "0x16A")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(float), typeof(ObjectRotationPivot)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DoImportModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "ToolboxModelAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Model)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcObjectCollectionWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(AABB), Member = "GetInvalid", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A16")]
	public AABB GetWorldAABB() { }

	[Address(RVA = "0x3F7E70", Offset = "0x3F7070", Length = "0x4CB")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnUndoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUndoRedoAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnRedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUndoRedoAction)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RTObjectSelection), Member = "DeselectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "SelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectSelectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_SelectedObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A2A")]
	private void HandleUndoRedo(ObjectSelectionSnapshot undoRedoSnapshot, bool isUndo) { }

	[Address(RVA = "0x3F8340", Offset = "0x3F7540", Length = "0x419")]
	[CalledBy(Type = typeof(RLDApp), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ObjectGridSnapSession), Member = "add_SessionBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectGridSnapSessionBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "add_SessionEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object2ObjectSnapSessionEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "add_SessionBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object2ObjectSnapSessionBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "set_SharedHotkeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object2ObjectSnapHotkeys)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "set_SharedSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object2ObjectSnapSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGridSnapSession), Member = "add_SessionEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectGridSnapSessionEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGridSnapSession), Member = "set_SharedHotkeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectGridSnapHotkeys)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_UndoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UndoEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = "add_SessionEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectGrabSessionEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = "add_SessionBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectGrabSessionBeginHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = "set_SharedHotkeys", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectGrabHotkeys)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = "set_SharedSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectGrabSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RTUndoRedo), Member = "add_RedoEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RedoEndHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x6001A02")]
	public void Initialize_SystemCall() { }

	[Address(RVA = "0x3F8760", Offset = "0x3F7960", Length = "0x95")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "AppendObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "RemoveObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "IsSelectionExactMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "OnObjectSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedEventArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A15")]
	public bool IsObjectSelected(GameObject gameObject) { }

	[Address(RVA = "0x3F8800", Offset = "0x3F7A00", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A04")]
	public bool IsRenderIgnoreCamera(Camera camera) { }

	[Address(RVA = "0x3F8860", Offset = "0x3F7A60", Length = "0x1A5")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelection), Member = "IsObjectSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A14")]
	public bool IsSelectionExactMatch(List<GameObject> gameObjectsToMatch) { }

	[Address(RVA = "0x3F8A10", Offset = "0x3F7C10", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A2B")]
	private void OnGrabSessionBegin() { }

	[Address(RVA = "0x3F8A40", Offset = "0x3F7C40", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A2C")]
	private void OnGrabSessionEnd() { }

	[Address(RVA = "0x3F8A70", Offset = "0x3F7C70", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A2D")]
	private void OnGridSnapSessionBegin() { }

	[Address(RVA = "0x3F8AA0", Offset = "0x3F7CA0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A2E")]
	private void OnGridSnapSessionEnd() { }

	[Address(RVA = "0x3F8AD0", Offset = "0x3F7CD0", Length = "0x265")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTScene), Member = "IsAnySceneEntityHovered", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTFocusCamera), Member = "IsViewportHoveredByDevice", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(YesNoAnswer), Member = "get_HasOnlyYes", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "Snapshot", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A19")]
	private void OnInputDevicePickButtonDown() { }

	[Address(RVA = "0x3F8D40", Offset = "0x3F7F40", Length = "0x2A6")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "Snapshot", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[Calls(Type = typeof(YesNoAnswer), Member = "get_HasOnlyYes", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTFocusCamera), Member = "IsViewportHoveredByDevice", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostObjectSelectionChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTScene), Member = "IsAnySceneEntityHovered", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A1A")]
	private void OnInputDevicePickButtonUp() { }

	[Address(RVA = "0x3F8FF0", Offset = "0x3F81F0", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTScene), Member = "IsAnyUIElementHovered", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A1B")]
	private void OnInputDeviceWasMoved() { }

	[Address(RVA = "0x3F9160", Offset = "0x3F8360", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A2F")]
	private void OnObject2ObjectSnapSessionBegin() { }

	[Address(RVA = "0x3F9190", Offset = "0x3F8390", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A30")]
	private void OnObject2ObjectSnapSessionEnd() { }

	[Address(RVA = "0x3F91C0", Offset = "0x3F83C0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTObjectSelection), Member = "HandleUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionSnapshot), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A29")]
	private void OnRedoEnd(IUndoRedoAction action) { }

	[Address(RVA = "0x3F92D0", Offset = "0x3F84D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A26")]
	private void OnSelectionChanged(ObjectSelectionChangedEventArgs args) { }

	[Address(RVA = "0x3F9320", Offset = "0x3F8520", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTObjectSelection), Member = "HandleUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionSnapshot), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A28")]
	private void OnUndoEnd(IUndoRedoAction action) { }

	[Address(RVA = "0x3F9430", Offset = "0x3F8630", Length = "0xBE3")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonUp", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "SelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectSelectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPreSelectCustomizeInfo), Member = "get_ToBeSelected", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(RTObjectSelection), Member = "DoPreSelectCustomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectReason)}, ReturnType = typeof(ObjectPreSelectCustomizeInfo))]
	[Calls(Type = typeof(RTObjectSelection), Member = "DeselectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(RTObjectSelection), Member = "DoPreDeselectCustomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(RTObjectSelection), Member = "IsObjectSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PostObjectSelectionChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelection), Member = "FilterByRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>), typeof(SelectRestrictFlags)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>))]
	[Calls(Type = typeof(RTScene), Member = "RaycastAllObjectsSorted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(SceneRaycastPrecision), typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "Snapshot", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A1D")]
	private void PerformClickSelect() { }

	[Address(RVA = "0x3FA020", Offset = "0x3F9220", Length = "0x97F")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDeviceWasMoved", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_SelectedObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(RTObjectSelection), Member = "SelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectSelectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectPreSelectCustomizeInfo), Member = "get_ToBeSelected", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(RTObjectSelection), Member = "DoPreSelectCustomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectReason)}, ReturnType = typeof(ObjectPreSelectCustomizeInfo))]
	[Calls(Type = typeof(RTObjectSelection), Member = "FilterByRestrictions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(SelectRestrictFlags), typeof(ObjectSelectReason)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(RTObjectSelection), Member = "DeselectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "IsObjectSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RTObjectSelection), Member = "DoPreDeselectCustomize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MultiSelectShape), Member = "GetOverlappedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Camera), typeof(QueryConfig), typeof(MultiSelectOverlapMode), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTFocusCamera), Member = "GetVisibleObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A1C")]
	private void PerformMultiSelect() { }

	[Address(RVA = "0x3FE9B0", Offset = "0x3FDBB0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019D6")]
	public void remove_CanClickSelectDeselect(ObjectSelectionCanClickSelectDeselectHandler value) { }

	[Address(RVA = "0x3FEA50", Offset = "0x3FDC50", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019D8")]
	public void remove_CanMultiSelectDeselect(ObjectSelectionCanMultiSelectDeselectHandler value) { }

	[Address(RVA = "0x3FEAF0", Offset = "0x3FDCF0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019DA")]
	public void remove_Changed(ObjectSelectionChangedHandler value) { }

	[Address(RVA = "0x3FEB90", Offset = "0x3FDD90", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019DE")]
	public void remove_Deleted(ObjectSelectionDeletedHandler value) { }

	[Address(RVA = "0x3FEC30", Offset = "0x3FDE30", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019EC")]
	public void remove_Disabled(ObjectSelectionDisabled value) { }

	[Address(RVA = "0x3FECE0", Offset = "0x3FDEE0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E2")]
	public void remove_Duplicated(ObjectSelectionDuplicatedHandler value) { }

	[Address(RVA = "0x3FED80", Offset = "0x3FDF80", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019EA")]
	public void remove_Enabled(ObjectSelectionEnabled value) { }

	[Address(RVA = "0x3FEE30", Offset = "0x3FE030", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019D2")]
	public void remove_ManipSessionBegin(ObjectSelectionManipSessionBeginHandler value) { }

	[Address(RVA = "0x3FEED0", Offset = "0x3FE0D0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019D4")]
	public void remove_ManipSessionEnd(ObjectSelectionManipSessionEndHandler value) { }

	[Address(RVA = "0x3FEF70", Offset = "0x3FE170", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E8")]
	public void remove_PreDeselectCustomize(ObjectSelectionPreDeselectCustomizeHandler value) { }

	[Address(RVA = "0x3FF010", Offset = "0x3FE210", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E6")]
	public void remove_PreSelectCustomize(ObjectSelectionPreSelectCustomizeHandler value) { }

	[Address(RVA = "0x3FF0B0", Offset = "0x3FE2B0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E4")]
	public void remove_Rotated(ObjectSelectionRotatedHandler value) { }

	[Address(RVA = "0x3FF150", Offset = "0x3FE350", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019DC")]
	public void remove_WillBeDeleted(ObjectSelectionWillBeDeletedHandler value) { }

	[Address(RVA = "0x3FF1F0", Offset = "0x3FE3F0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60019E0")]
	public void remove_WillBeDuplicated(ObjectSelectionWillBeDuplicatedHandler value) { }

	[Address(RVA = "0x3FA9A0", Offset = "0x3F9BA0", Length = "0x3A7")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "FindAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "RemoveWhere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A27")]
	private void RemoveNullAndInactiveObjectRefs() { }

	[Address(RVA = "0x3FAD50", Offset = "0x3F9F50", Length = "0x39C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTObjectSelection), Member = "IsObjectSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostObjectSelectionChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(RTObjectSelection), Member = "DeselectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "Snapshot", ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A0B")]
	public void RemoveObjects(List<GameObject> gameObjects, bool allowUndoRedo) { }

	[Address(RVA = "0x3FB0F0", Offset = "0x3FA2F0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001A06")]
	public void RemoveRenderIgnoreCamera(Camera camera) { }

	[Address(RVA = "0x3FB150", Offset = "0x3FA350", Length = "0x9E8")]
	[CalledBy(Type = typeof(RLDApp), Member = "OnRenderObject", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialEx), Member = "SetZTestEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(AABB), Member = "GetInvalid", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsEx), Member = "DrawWireCornerBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(MaterialEx), Member = "SetZWriteEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGridSnapSession), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawRectBorder2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawRect2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Camera)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MaterialEx), Member = "SetCullModeOff", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialEx), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPool), Member = "get_SimpleColor", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x6001A18")]
	public void Render_SystemCall(Camera renderCamera) { }

	[Address(RVA = "0x3FBB40", Offset = "0x3FAD40", Length = "0x815")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>), typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(TransformEx), Member = "RotateAroundPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RTObjectSelection), Member = "GetWorldAABB", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(LocalTransformSnapshot), Member = "GetSnapshotCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A09")]
	public void Rotate(Axis axis, float rotationAngle, ObjectRotationPivot rotationPivot) { }

	[Address(RVA = "0x3FC360", Offset = "0x3FB560", Length = "0x190")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "AppendObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "HandleUndoRedo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionSnapshot), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A23")]
	private void SelectObject(GameObject gameObject, ObjectSelectReason selectReason) { }

	[Address(RVA = "0x3FC500", Offset = "0x3FB700", Length = "0x97")]
	[CalledBy(Type = typeof(CreatorController), Member = "SetActiveGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ObjectGridSnapSession), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A07")]
	public void SetEnabled(bool isEnabled) { }

	[Address(RVA = "0x3FC5A0", Offset = "0x3FB7A0", Length = "0x211")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostObjectTransformsChangedAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>), typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GameObjectEx), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LocalTransformSnapshot), Member = "GetSnapshotCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.LocalTransformSnapshot>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A08")]
	public void SetRotation(Quaternion rotation) { }

	[Address(RVA = "0x3FC7C0", Offset = "0x3FB9C0", Length = "0x59A")]
	[CalledBy(Type = typeof(CreatorController), Member = "DoImportModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "ToolboxModelAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Model)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "OnTreeSelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SelectionChangedArgs)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddSeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RTObjectSelection), Member = "IsObjectSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelection), Member = "CanSelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SelectRestrictFlags), typeof(ObjectSelectReason)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelection), Member = "SelectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectSelectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_SelectedObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PostObjectSelectionChangedAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(ObjectSelectionChangedEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectDeselectReason), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "DeselectObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(ObjectDeselectReason)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "Snapshot", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "IsSelectionExactMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001A0C")]
	public void SetSelectedObjects(List<GameObject> gameObjects, bool allowUndoRedo) { }

	[Address(RVA = "0x3FCD60", Offset = "0x3FBF60", Length = "0x788")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTObjectSelection), Member = "SetRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "Duplicate", ReturnType = typeof(ObjectSelectionDuplicationResult))]
	[Calls(Type = typeof(RTFocusCamera), Member = "Focus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "GetWorldAABB", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(RTObjectSelection), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Axis), typeof(float), typeof(ObjectRotationPivot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001A950")]
	[Calls(Type = typeof(RTScene), Member = "IsAnyUIElementHovered", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonDown", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonUp", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = "End", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RTObjectSelection), Member = "Delete", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectGridSnapSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DeviceObjectGrabSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "RemoveNullAndInactiveObjectRefs", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object2ObjectSnapSession), Member = "End", ReturnType = typeof(void))]
	[Token(Token = "0x6001A17")]
	public void Update_SystemCall() { }

}

