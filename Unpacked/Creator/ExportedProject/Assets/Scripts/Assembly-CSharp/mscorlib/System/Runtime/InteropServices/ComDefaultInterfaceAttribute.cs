namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x2000439")]
public sealed class ComDefaultInterfaceAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011A2")]
	internal Type _val; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F74")]
	public ComDefaultInterfaceAttribute(Type defaultInterface) { }

}

