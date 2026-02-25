namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000321")]
public class GUI : Instance
{
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000C80")]
	private CreatorViewport vp; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SyncVar(hook = "SyncSetVisible")]
	[Token(Token = "0x4000C81")]
	private bool visible; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000C82")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_visible; //Field offset: 0x108

	[Token(Token = "0x17000961")]
	public bool Networkvisible
	{
		[Address(RVA = "0x402690", Offset = "0x401890", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DF3")]
		 get { } //Length: 8
		[Address(RVA = "0x422480", Offset = "0x421680", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6001DF4")]
		 set { } //Length: 104
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000960")]
	public bool Visible
	{
		[Address(RVA = "0x402690", Offset = "0x401890", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001DE9")]
		 get { } //Length: 8
		[Address(RVA = "0x4224F0", Offset = "0x4216F0", Length = "0xA2")]
		[CalledBy(Type = typeof(GUI), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "SyncSetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIProxy), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001DEA")]
		 set { } //Length: 162
	}

	[Address(RVA = "0x4223D0", Offset = "0x4215D0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001DF1")]
	public GUI() { }

	[Address(RVA = "0x421E70", Offset = "0x421070", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001DF0")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x421F10", Offset = "0x421110", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001DF6")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x402690", Offset = "0x401890", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF3")]
	public bool get_Networkvisible() { }

	[Address(RVA = "0x402690", Offset = "0x401890", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DE9")]
	public bool get_Visible() { }

	[Address(RVA = "0x400CA0", Offset = "0x3FFEA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DEE")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x421FB0", Offset = "0x4211B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnShow", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DEF")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x421FC0", Offset = "0x4211C0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001DF5")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x422480", Offset = "0x421680", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6001DF4")]
	public void set_Networkvisible(in bool value) { }

	[Address(RVA = "0x4224F0", Offset = "0x4216F0", Length = "0xA2")]
	[CalledBy(Type = typeof(GUI), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "SyncSetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIProxy), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001DEA")]
	public void set_Visible(bool value) { }

	[Address(RVA = "0x422050", Offset = "0x421250", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "FindAnyObjectByType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GUI), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DEB")]
	protected virtual void Start() { }

	[Address(RVA = "0x4220D0", Offset = "0x4212D0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUI), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DED")]
	public void SyncSetVisible(bool oldValue, bool newValue) { }

	[Address(RVA = "0x4220E0", Offset = "0x4212E0", Length = "0x2EA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_offsetMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_offsetMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001DEC")]
	public void Update() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001DF2")]
	public virtual bool Weaved() { }

}

