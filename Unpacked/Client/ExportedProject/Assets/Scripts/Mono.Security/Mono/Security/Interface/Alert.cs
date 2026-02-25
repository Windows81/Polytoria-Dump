namespace Mono.Security.Interface;

[Token(Token = "0x200003A")]
public class Alert
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CF")]
	private AlertLevel level; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40000D0")]
	private AlertDescription description; //Field offset: 0x11

	[Token(Token = "0x1700005F")]
	public AlertDescription Description
	{
		[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000140")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700005E")]
	public AlertLevel Level
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600013F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x12C15E0", Offset = "0x12C07E0", Length = "0x84")]
	[CalledBy(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000141")]
	public Alert(AlertDescription description) { }

	[Address(RVA = "0x3CE370", Offset = "0x3CD570", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000140")]
	public AlertDescription get_Description() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013F")]
	public AlertLevel get_Level() { }

	[Address(RVA = "0x12C1680", Offset = "0x12C0880", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000142")]
	private void inferAlertLevel() { }

	[Address(RVA = "0x12C1540", Offset = "0x12C0740", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000143")]
	public virtual string ToString() { }

}

