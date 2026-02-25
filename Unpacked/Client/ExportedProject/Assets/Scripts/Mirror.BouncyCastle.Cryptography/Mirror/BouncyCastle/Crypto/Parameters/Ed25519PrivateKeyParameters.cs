namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000134")]
public sealed class Ed25519PrivateKeyParameters : AsymmetricKeyParameter
{
	[Token(Token = "0x4000270")]
	public static readonly int KeySize; //Field offset: 0x0
	[Token(Token = "0x4000271")]
	public static readonly int SignatureSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000272")]
	private readonly Byte[] data; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000273")]
	private Ed25519PublicKeyParameters cachedPublicKey; //Field offset: 0x20

	[Address(RVA = "0x11E56C0", Offset = "0x11E48C0", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000BE1")]
	private static Ed25519PrivateKeyParameters() { }

	[Address(RVA = "0x11E5750", Offset = "0x11E4950", Length = "0x1EF")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BDB")]
	public Ed25519PrivateKeyParameters(Byte[] buf) { }

	[Address(RVA = "0x11E5940", Offset = "0x11E4B40", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BDC")]
	public Ed25519PrivateKeyParameters(Byte[] buf, int off) { }

	[Address(RVA = "0x11E53C0", Offset = "0x11E45C0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Ed25519), Member = "GeneratePublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(PublicPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BDF")]
	private static Ed25519PublicKeyParameters CreatePublicKey(Byte[] data) { }

	[Address(RVA = "0x11E54B0", Offset = "0x11E46B0", Length = "0x92")]
	[CalledBy(Type = typeof(PrivateKeyInfoFactory), Member = "CreatePrivateKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter), typeof(Asn1Set)}, ReturnType = typeof(PrivateKeyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BDE")]
	public Ed25519PublicKeyParameters GeneratePublicKey() { }

	[Address(RVA = "0x11E5550", Offset = "0x11E4750", Length = "0x4D")]
	[CalledBy(Type = typeof(PrivateKeyInfoFactory), Member = "CreatePrivateKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter), typeof(Asn1Set)}, ReturnType = typeof(PrivateKeyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6000BDD")]
	public Byte[] GetEncoded() { }

	[Address(RVA = "0x11E55A0", Offset = "0x11E47A0", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000BE0")]
	private static Byte[] Validate(Byte[] buf) { }

}

