namespace RLD;

[Token(Token = "0x2000129")]
public class CameraHotkeys : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400054E")]
	private Hotkeys _moveForward; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400054F")]
	private Hotkeys _moveBack; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000550")]
	private Hotkeys _strafeLeft; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000551")]
	private Hotkeys _strafeRight; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000552")]
	private Hotkeys _moveUp; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000553")]
	private Hotkeys _moveDown; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000554")]
	private Hotkeys _pan; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000555")]
	private Hotkeys _lookAround; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000556")]
	private Hotkeys _orbit; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000557")]
	private Hotkeys _alternateMoveSpeed; //Field offset: 0x70

	[Token(Token = "0x170004C6")]
	public Hotkeys AlternateMoveSpeed
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004C4")]
	public Hotkeys LookAround
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004BE")]
	public Hotkeys MoveBack
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E14")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170004C2")]
	public Hotkeys MoveDown
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E18")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004BD")]
	public Hotkeys MoveForward
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E13")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004C1")]
	public Hotkeys MoveUp
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E17")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004C5")]
	public Hotkeys Orbit
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E1B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004C3")]
	public Hotkeys Pan
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E19")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004BF")]
	public Hotkeys StrafeLeft
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E15")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004C0")]
	public Hotkeys StrafeRight
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E16")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x53B4E0", Offset = "0x53A6E0", Length = "0x3ED")]
	[CalledBy(Type = typeof(RTFocusCamera), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hotkeys), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hotkeys), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E1D")]
	public CameraHotkeys() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1C")]
	public Hotkeys get_AlternateMoveSpeed() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1A")]
	public Hotkeys get_LookAround() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E14")]
	public Hotkeys get_MoveBack() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E18")]
	public Hotkeys get_MoveDown() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E13")]
	public Hotkeys get_MoveForward() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E17")]
	public Hotkeys get_MoveUp() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E1B")]
	public Hotkeys get_Orbit() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E19")]
	public Hotkeys get_Pan() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E15")]
	public Hotkeys get_StrafeLeft() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E16")]
	public Hotkeys get_StrafeRight() { }

}

