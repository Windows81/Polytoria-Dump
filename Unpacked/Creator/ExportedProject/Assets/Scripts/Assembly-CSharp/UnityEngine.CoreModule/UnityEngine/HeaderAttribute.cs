namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = True)]
[Token(Token = "0x2000110")]
public class HeaderAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F8")]
	public readonly string header; //Field offset: 0x18

	[Address(RVA = "0x1963460", Offset = "0x1962660", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600088D")]
	public HeaderAttribute(string header) { }

}

