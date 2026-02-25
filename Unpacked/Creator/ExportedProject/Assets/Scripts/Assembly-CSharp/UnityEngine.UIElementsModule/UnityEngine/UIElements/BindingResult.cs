namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x2000020")]
public struct BindingResult
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000043")]
	private readonly BindingStatus <status>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000044")]
	private readonly string <message>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000022")]
	public string message
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000090")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000021")]
	public BindingStatus status
	{
		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600008F")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x880C00", Offset = "0x87FE00", Length = "0x12")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000091")]
	public BindingResult(BindingStatus status, string message = null) { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000090")]
	public string get_message() { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600008F")]
	public BindingStatus get_status() { }

}

