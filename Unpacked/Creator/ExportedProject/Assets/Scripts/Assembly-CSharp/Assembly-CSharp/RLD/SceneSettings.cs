namespace RLD;

[Token(Token = "0x2000217")]
public class SceneSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000814")]
	private ScenePhysicsMode _physicsMode; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000815")]
	private float _noVolumeObjectSize; //Field offset: 0x2C

	[Token(Token = "0x17000677")]
	public float NoVolumeObjectSize
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001450")]
		 get { } //Length: 6
		[Address(RVA = "0x5A2900", Offset = "0x5A1B00", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Token(Token = "0x6001451")]
		 set { } //Length: 105
	}

	[Token(Token = "0x17000676")]
	public ScenePhysicsMode PhysicsMode
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600144E")]
		 get { } //Length: 4
		[Address(RVA = "0x5A2970", Offset = "0x5A1B70", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Token(Token = "0x600144F")]
		 set { } //Length: 89
	}

	[Address(RVA = "0x5A28E0", Offset = "0x5A1AE0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001452")]
	public SceneSettings() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001450")]
	public float get_NoVolumeObjectSize() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600144E")]
	public ScenePhysicsMode get_PhysicsMode() { }

	[Address(RVA = "0x5A2900", Offset = "0x5A1B00", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Token(Token = "0x6001451")]
	public void set_NoVolumeObjectSize(float value) { }

	[Address(RVA = "0x5A2970", Offset = "0x5A1B70", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Token(Token = "0x600144F")]
	public void set_PhysicsMode(ScenePhysicsMode value) { }

}

