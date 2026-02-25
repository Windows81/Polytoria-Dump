namespace GLTFast.Schema;

[Token(Token = "0x20000A6")]
public class Sheen
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000278")]
	public Single[] sheenColorFactor; //Field offset: 0x10

	[Address(RVA = "0x107A550", Offset = "0x1079750", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000205")]
	public Sheen() { }

}

