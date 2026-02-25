namespace Mono.Xml;

[Token(Token = "0x200004C")]
internal class SmallXmlParserException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000150")]
	private int line; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000151")]
	private int column; //Field offset: 0x94

	[Address(RVA = "0x12E4680", Offset = "0x12E3880", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000B6")]
	public SmallXmlParserException(string msg, int line, int column) { }

}

