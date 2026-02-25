namespace MoonSharp.Interpreter;

[Token(Token = "0x200004D")]
public class RefIdObject
{
	[Token(Token = "0x40001E5")]
	private static int s_RefIDCounter; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E6")]
	private int m_RefID; //Field offset: 0x10

	[Token(Token = "0x170000A6")]
	public int ReferenceID
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600052B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x3087A0", Offset = "0x3079A0", Length = "0x4B")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052D")]
	public RefIdObject() { }

	[Address(RVA = "0x308730", Offset = "0x307930", Length = "0x64")]
	[CalledBy(Type = typeof(DynValue), Member = "ToPrintString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DynValue), Member = "ToDebugPrintString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600052C")]
	public string FormatTypeString(string typeString) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052B")]
	public int get_ReferenceID() { }

}

