namespace UnityEngine;

[Token(Token = "0x2000011")]
public sealed class GUILayoutOption
{
	[Token(Token = "0x2000012")]
	public enum Type
	{
		fixedWidth = 0,
		fixedHeight = 1,
		minWidth = 2,
		maxWidth = 3,
		minHeight = 4,
		maxHeight = 5,
		stretchWidth = 6,
		stretchHeight = 7,
		alignStart = 8,
		alignMiddle = 9,
		alignEnd = 10,
		alignJustify = 11,
		equalSize = 12,
		spacing = 13,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000063")]
	internal Type type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000064")]
	internal object value; //Field offset: 0x18

	[Address(RVA = "0x2BE0F0", Offset = "0x2BD2F0", Length = "0x40")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000105")]
	internal GUILayoutOption(Type type, object value) { }

}

