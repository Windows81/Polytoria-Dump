namespace RLD;

[Token(Token = "0x20002CE")]
public class UniversalGizmoConfig : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000AE9")]
	private UniversalGizmoSettingsCategory _inheritCategory; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000AEA")]
	private UniversalGizmoSettingsType _inheritType; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000AEB")]
	private UniversalGizmoSettingsCategory _displayCategory; //Field offset: 0x30

	[Token(Token = "0x170008C3")]
	public UniversalGizmoSettingsCategory DisplayCategory
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8E")]
		 get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008C1")]
	public UniversalGizmoSettingsCategory InheritCategory
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8A")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8B")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170008C2")]
	public UniversalGizmoSettingsType InheritType
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8C")]
		 get { } //Length: 4
		[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001A8D")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3FFD00", Offset = "0x3FEF00", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = "Polytoria.Networking.PTAuthenticator+<ValidateToken>d__5", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = "Polytoria.Networking.PTNetworkManager+<HeartbeatLoop>d__33", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Token(Token = "0x6001A90")]
	public UniversalGizmoConfig() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8E")]
	public UniversalGizmoSettingsCategory get_DisplayCategory() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8A")]
	public UniversalGizmoSettingsCategory get_InheritCategory() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8C")]
	public UniversalGizmoSettingsType get_InheritType() { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8F")]
	public void set_DisplayCategory(UniversalGizmoSettingsCategory value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8B")]
	public void set_InheritCategory(UniversalGizmoSettingsCategory value) { }

	[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001A8D")]
	public void set_InheritType(UniversalGizmoSettingsType value) { }

}

