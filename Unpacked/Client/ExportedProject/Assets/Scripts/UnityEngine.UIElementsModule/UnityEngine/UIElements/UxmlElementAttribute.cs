namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
[Token(Token = "0x20004D7")]
public class UxmlElementAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001012")]
	public readonly string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001013")]
	public LibraryVisibility visibility; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001014")]
	internal readonly Type[] supportedChildTypes; //Field offset: 0x20

	[Address(RVA = "0x1B50DA0", Offset = "0x1B4FFA0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002419")]
	public UxmlElementAttribute(string uxmlName) { }

	[Address(RVA = "0x1B50D40", Offset = "0x1B4FF40", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600241A")]
	public UxmlElementAttribute(string uxmlName, Type[] supportedTypes) { }

}

