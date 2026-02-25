namespace RLD;

[Token(Token = "0x200020D")]
public class RTCustomObjectInteractionSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40007EC")]
	private Vector3 _noVolumeObjectSize; //Field offset: 0x28

	[Token(Token = "0x1700065F")]
	public Vector3 NoVolumeObjectSize
	{
		[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001404")]
		 get { } //Length: 19
		[Address(RVA = "0x59B070", Offset = "0x59A270", Length = "0xB3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[Token(Token = "0x6001405")]
		 set { } //Length: 179
	}

	[Address(RVA = "0x59B030", Offset = "0x59A230", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001406")]
	public RTCustomObjectInteractionSettings() { }

	[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001404")]
	public Vector3 get_NoVolumeObjectSize() { }

	[Address(RVA = "0x59B070", Offset = "0x59A270", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Token(Token = "0x6001405")]
	public void set_NoVolumeObjectSize(Vector3 value) { }

}

