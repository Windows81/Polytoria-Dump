namespace RLD;

[Token(Token = "0x200009F")]
public class BoxGizmoHotkeys : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000245")]
	private Hotkeys _enableSnapping; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000246")]
	private Hotkeys _enableCenterPivot; //Field offset: 0x30

	[Token(Token = "0x170001C7")]
	public Hotkeys EnableCenterPivot
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C3")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170001C6")]
	public Hotkeys EnableSnapping
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60005C2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x4F9910", Offset = "0x4F8B10", Length = "0xEE")]
	[CalledBy(Type = typeof(RTGizmosEngine), Member = "CreateBoxGizmo", ReturnType = typeof(BoxGizmo))]
	[CalledBy(Type = typeof(BoxGizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelectionGizmos), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hotkeys), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HotkeysStaticData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60005C4")]
	public BoxGizmoHotkeys() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C3")]
	public Hotkeys get_EnableCenterPivot() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60005C2")]
	public Hotkeys get_EnableSnapping() { }

}

