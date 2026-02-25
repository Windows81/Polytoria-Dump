namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002EC")]
public class DSASignatureFormatter : AsymmetricSignatureFormatter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CCE")]
	private string _oid; //Field offset: 0x10

	[Address(RVA = "0x1323FE0", Offset = "0x13231E0", Length = "0x73")]
	[CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CryptoConfig), Member = "MapNameToOID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60017CC")]
	public DSASignatureFormatter() { }

}

