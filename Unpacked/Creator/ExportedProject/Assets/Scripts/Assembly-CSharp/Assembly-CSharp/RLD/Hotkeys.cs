namespace RLD;

[Token(Token = "0x2000174")]
public class Hotkeys
{
	[Token(Token = "0x400064E")]
	private static List<KeyCode> _availableKeys; //Field offset: 0x0
	[Token(Token = "0x4000650")]
	private const int _maxNumberOfKeys = 2; //Field offset: 0x0
	[Token(Token = "0x400064F")]
	private static List<String> _availableKeyNames; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000651")]
	private bool _isEnabled; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	[Token(Token = "0x4000652")]
	private KeyCode _key; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000653")]
	private bool _lCtrl; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	[Token(Token = "0x4000654")]
	private bool _lCmd; //Field offset: 0x19
	[FieldOffset(Offset = "0x1A")]
	[SerializeField]
	[Token(Token = "0x4000655")]
	private bool _lAlt; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1B")]
	[SerializeField]
	[Token(Token = "0x4000656")]
	private bool _lShift; //Field offset: 0x1B
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000657")]
	private bool _useStrictModifierCheck; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[SerializeField]
	[Token(Token = "0x4000658")]
	private bool _lMouseBtn; //Field offset: 0x1D
	[FieldOffset(Offset = "0x1E")]
	[SerializeField]
	[Token(Token = "0x4000659")]
	private bool _rMouseBtn; //Field offset: 0x1E
	[FieldOffset(Offset = "0x1F")]
	[SerializeField]
	[Token(Token = "0x400065A")]
	private bool _mMouseBtn; //Field offset: 0x1F
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400065B")]
	private bool _useStrictMouseCheck; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400065C")]
	private string _name; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400065D")]
	private List<Hotkeys> _potentialOverlaps; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400065E")]
	private HotkeysStaticData _staticData; //Field offset: 0x38

	[Token(Token = "0x17000558")]
	public static List<String> AvailableKeyNames
	{
		[Address(RVA = "0x560FA0", Offset = "0x5601A0", Length = "0x97")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Token(Token = "0x600105F")]
		 get { } //Length: 151
	}

	[Token(Token = "0x17000557")]
	public static List<KeyCode> AvailableKeys
	{
		[Address(RVA = "0x561040", Offset = "0x560240", Length = "0x96")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32Enum>)}, ReturnType = typeof(void))]
		[Token(Token = "0x600105E")]
		 get { } //Length: 150
	}

	[Token(Token = "0x17000559")]
	public bool IsEnabled
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001060")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001061")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700055B")]
	public KeyCode Key
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001063")]
		 get { } //Length: 4
		[Address(RVA = "0x561130", Offset = "0x560330", Length = "0x8A")]
		[CalledBy(Type = typeof(CameraHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectSelectionHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectSelectionGizmosHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectGridSnapHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectGrabHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Object2ObjectSnapHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGridHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTSceneGrid), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ScaleGizmo), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectSelectionRotationHotkeys), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 52)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001064")]
		 set { } //Length: 138
	}

	[Token(Token = "0x1700055E")]
	public bool LAlt
	{
		[Address(RVA = "0x5610E0", Offset = "0x5602E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001069")]
		 get { } //Length: 5
		[Address(RVA = "0x5611C0", Offset = "0x5603C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600106A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700055D")]
	public bool LCmd
	{
		[Address(RVA = "0x5610F0", Offset = "0x5602F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001067")]
		 get { } //Length: 5
		[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001068")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700055C")]
	public bool LCtrl
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001065")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001066")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000560")]
	public bool LMouseButton
	{
		[Address(RVA = "0x2F6C10", Offset = "0x2F5E10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600106D")]
		 get { } //Length: 5
		[Address(RVA = "0x2F6CD0", Offset = "0x2F5ED0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600106E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700055F")]
	public bool LShift
	{
		[Address(RVA = "0x561100", Offset = "0x560300", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600106B")]
		 get { } //Length: 5
		[Address(RVA = "0x5611E0", Offset = "0x5603E0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600106C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000562")]
	public bool MMouseButton
	{
		[Address(RVA = "0x561110", Offset = "0x560310", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001071")]
		 get { } //Length: 5
		[Address(RVA = "0x5611F0", Offset = "0x5603F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001072")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700055A")]
	public string Name
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001062")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000561")]
	public bool RMouseButton
	{
		[Address(RVA = "0x561120", Offset = "0x560320", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600106F")]
		 get { } //Length: 5
		[Address(RVA = "0x561200", Offset = "0x560400", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001070")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000564")]
	public bool UseStrictModifierCheck
	{
		[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001075")]
		 get { } //Length: 5
		[Address(RVA = "0x339460", Offset = "0x338660", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001076")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000563")]
	public bool UseStrictMouseCheck
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001073")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001074")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x560730", Offset = "0x55F930", Length = "0x6BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600105D")]
	private static Hotkeys() { }

	[Address(RVA = "0x560ED0", Offset = "0x5600D0", Length = "0xCF")]
	[CalledBy(Type = typeof(CameraHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001077")]
	public Hotkeys(string name) { }

	[Address(RVA = "0x560DF0", Offset = "0x55FFF0", Length = "0xDC")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionRotationHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionGizmosHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGridSnapHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGrabHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object2ObjectSnapHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGridHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 56)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001078")]
	public Hotkeys(string name, HotkeysStaticData staticData) { }

	[Address(RVA = "0x55F4A0", Offset = "0x55E6A0", Length = "0xF0")]
	[CalledBy(Type = typeof(Hotkeys), Member = "EstablishPotentialOverlaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.Hotkeys>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6001080")]
	public void AddPotentialOverlap(Hotkeys hotkeys) { }

	[Address(RVA = "0x55F5A0", Offset = "0x55E7A0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001081")]
	public bool ContainsPotentialOverlap(Hotkeys hotkeys) { }

	[Address(RVA = "0x55F600", Offset = "0x55E800", Length = "0x1E2")]
	[CalledBy(Type = typeof(ObjectGrabHotkeys), Member = "EstablishPotentialOverlaps", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkeys), Member = "AddPotentialOverlap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001079")]
	public static void EstablishPotentialOverlaps(List<Hotkeys> hotkeysCollection) { }

	[Address(RVA = "0x560FA0", Offset = "0x5601A0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600105F")]
	public static List<String> get_AvailableKeyNames() { }

	[Address(RVA = "0x561040", Offset = "0x560240", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32Enum>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600105E")]
	public static List<KeyCode> get_AvailableKeys() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001060")]
	public bool get_IsEnabled() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001063")]
	public KeyCode get_Key() { }

	[Address(RVA = "0x5610E0", Offset = "0x5602E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001069")]
	public bool get_LAlt() { }

	[Address(RVA = "0x5610F0", Offset = "0x5602F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001067")]
	public bool get_LCmd() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001065")]
	public bool get_LCtrl() { }

	[Address(RVA = "0x2F6C10", Offset = "0x2F5E10", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600106D")]
	public bool get_LMouseButton() { }

	[Address(RVA = "0x561100", Offset = "0x560300", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600106B")]
	public bool get_LShift() { }

	[Address(RVA = "0x561110", Offset = "0x560310", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001071")]
	public bool get_MMouseButton() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001062")]
	public string get_Name() { }

	[Address(RVA = "0x561120", Offset = "0x560320", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600106F")]
	public bool get_RMouseButton() { }

	[Address(RVA = "0x339420", Offset = "0x338620", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001075")]
	public bool get_UseStrictModifierCheck() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001073")]
	public bool get_UseStrictMouseCheck() { }

	[Address(RVA = "0x55F7F0", Offset = "0x55E9F0", Length = "0x207")]
	[CalledBy(Type = typeof(Hotkeys), Member = "UsesModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.KeyCode>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsOverlappedBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600107E")]
	public List<KeyCode> GetAllUsedModifiers() { }

	[Address(RVA = "0x55FA00", Offset = "0x55EC00", Length = "0x204")]
	[CalledBy(Type = typeof(Hotkeys), Member = "UsesMouseButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.MouseButton>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsOverlappedBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600107C")]
	public List<MouseButton> GetAllUsedMouseButtons() { }

	[Address(RVA = "0x55FC10", Offset = "0x55EE10", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600107A")]
	public int GetNumModifiers() { }

	[Address(RVA = "0x55FC30", Offset = "0x55EE30", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600107B")]
	public int GetNumMouseButtons() { }

	[Address(RVA = "0x55FC50", Offset = "0x55EE50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001085")]
	public bool HasNoKeys() { }

	[Address(RVA = "0x55FC60", Offset = "0x55EE60", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001086")]
	public bool HasNoModifiers() { }

	[Address(RVA = "0x55FC80", Offset = "0x55EE80", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001087")]
	public bool HasNoMouseButtons() { }

	[Address(RVA = "0x55FF70", Offset = "0x55F170", Length = "0x338")]
	[CalledBy(Type = typeof(ObjectGridSnapSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformClickSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "PerformMultiSelect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "OnInputDevicePickButtonUp", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "SnapTargets", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "OnInputDeviceDoubleTap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputDevice), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "HandleMouseAndKeyboardInput", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeviceObjectGrabSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RLDApp), Member = "OnCanObjectSelectionClickAndMultiSelectDeselect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(YesNoAnswer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnGizmoDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkeys), Member = "IsAnyModifierKeyPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkeys), Member = "IsAnyMouseButtonPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Hotkeys), Member = "IsOverlappedBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001083")]
	public bool IsActive(bool checkForOverlaps = true) { }

	[Address(RVA = "0x55FCA0", Offset = "0x55EEA0", Length = "0x2C8")]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeviceObjectGrabSession), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkeys), Member = "IsAnyMouseButtonPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Hotkeys), Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Hotkeys), Member = "IsAnyModifierKeyPressed", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkeys), Member = "IsOverlappedBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001084")]
	public bool IsActiveInFrame(bool checkForOverlaps = true) { }

	[Address(RVA = "0x5602B0", Offset = "0x55F4B0", Length = "0x50")]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001089")]
	private bool IsAnyModifierKeyPressed() { }

	[Address(RVA = "0x560300", Offset = "0x55F500", Length = "0x3D")]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600108A")]
	private bool IsAnyMouseButtonPressed() { }

	[Address(RVA = "0x560340", Offset = "0x55F540", Length = "0x35")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001088")]
	public bool IsEmpty() { }

	[Address(RVA = "0x560380", Offset = "0x55F580", Length = "0x104")]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsActiveInFrame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hotkeys), Member = "GetAllUsedModifiers", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.KeyCode>))]
	[Calls(Type = typeof(Hotkeys), Member = "UsesModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.KeyCode>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Hotkeys), Member = "GetAllUsedMouseButtons", ReturnType = typeof(System.Collections.Generic.List`1<RLD.MouseButton>))]
	[Calls(Type = typeof(Hotkeys), Member = "UsesMouseButtons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<RLD.MouseButton>)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001082")]
	public bool IsOverlappedBy(Hotkeys hotkeys) { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001061")]
	public void set_IsEnabled(bool value) { }

	[Address(RVA = "0x561130", Offset = "0x560330", Length = "0x8A")]
	[CalledBy(Type = typeof(ObjectSelectionRotationHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGridHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object2ObjectSnapHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGrabHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGridSnapHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionGizmosHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmoHotkeys), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001064")]
	public void set_Key(KeyCode value) { }

	[Address(RVA = "0x5611C0", Offset = "0x5603C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600106A")]
	public void set_LAlt(bool value) { }

	[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001068")]
	public void set_LCmd(bool value) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001066")]
	public void set_LCtrl(bool value) { }

	[Address(RVA = "0x2F6CD0", Offset = "0x2F5ED0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600106E")]
	public void set_LMouseButton(bool value) { }

	[Address(RVA = "0x5611E0", Offset = "0x5603E0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600106C")]
	public void set_LShift(bool value) { }

	[Address(RVA = "0x5611F0", Offset = "0x5603F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001072")]
	public void set_MMouseButton(bool value) { }

	[Address(RVA = "0x561200", Offset = "0x560400", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001070")]
	public void set_RMouseButton(bool value) { }

	[Address(RVA = "0x339460", Offset = "0x338660", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001076")]
	public void set_UseStrictModifierCheck(bool value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001074")]
	public void set_UseStrictMouseCheck(bool value) { }

	[Address(RVA = "0x560490", Offset = "0x55F690", Length = "0x147")]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsOverlappedBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hotkeys), Member = "GetAllUsedModifiers", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.KeyCode>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600107F")]
	public bool UsesModifiers(List<KeyCode> modifiers) { }

	[Address(RVA = "0x5605E0", Offset = "0x55F7E0", Length = "0x147")]
	[CalledBy(Type = typeof(Hotkeys), Member = "IsOverlappedBy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hotkeys)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Hotkeys), Member = "GetAllUsedMouseButtons", ReturnType = typeof(System.Collections.Generic.List`1<RLD.MouseButton>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600107D")]
	public bool UsesMouseButtons(List<MouseButton> buttons) { }

}

