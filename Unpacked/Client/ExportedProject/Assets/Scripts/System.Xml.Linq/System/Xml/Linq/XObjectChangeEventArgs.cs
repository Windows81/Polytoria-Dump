namespace System.Xml.Linq;

[Token(Token = "0x2000018")]
public class XObjectChangeEventArgs : EventArgs
{
	[Token(Token = "0x4000039")]
	public static readonly XObjectChangeEventArgs Add; //Field offset: 0x0
	[Token(Token = "0x400003A")]
	public static readonly XObjectChangeEventArgs Remove; //Field offset: 0x8
	[Token(Token = "0x400003B")]
	public static readonly XObjectChangeEventArgs Name; //Field offset: 0x10
	[Token(Token = "0x400003C")]
	public static readonly XObjectChangeEventArgs Value; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000038")]
	private XObjectChange _objectChange; //Field offset: 0x10

	[Address(RVA = "0x1642360", Offset = "0x1641560", Length = "0x216")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600008C")]
	private static XObjectChangeEventArgs() { }

	[Address(RVA = "0x1642580", Offset = "0x1641780", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008B")]
	public XObjectChangeEventArgs(XObjectChange objectChange) { }

}

