namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002EA")]
public abstract class DSA : AsymmetricAlgorithm
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60017C0")]
	protected DSA() { }

	[Address(RVA = "0x1324060", Offset = "0x1323260", Length = "0x44")]
	[CalledBy(Type = "Mono.Security.Cryptography.PKCS8+PrivateKeyInfo", Member = "DecodeDSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(DSAParameters)}, ReturnType = typeof(DSA))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60017C1")]
	public static DSA Create() { }

	[Token(Token = "0x60017C5")]
	public abstract DSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x13240B0", Offset = "0x13232B0", Length = "0xAAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Utils), Member = "ConvertByteArrayToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Utils), Member = "DiscardWhiteSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SecurityDocument), Member = "InternalGetElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(bool)}, ReturnType = typeof(SecurityElement))]
	[Calls(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tokenizer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(StringMaker))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60017C3")]
	public virtual void FromXmlString(string xmlString) { }

	[Token(Token = "0x60017C6")]
	public abstract void ImportParameters(DSAParameters parameters) { }

	[Address(RVA = "0x1324B60", Offset = "0x1323D60", Length = "0x411")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Utils), Member = "ConvertIntToByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60017C4")]
	public virtual string ToXmlString(bool includePrivateParameters) { }

	[Token(Token = "0x60017C2")]
	public abstract bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

