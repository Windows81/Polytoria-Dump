namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001E7")]
public class DLSet : DerSet
{
	[Token(Token = "0x4000499")]
	public static readonly DLSet Empty; //Field offset: 0x0

	[Address(RVA = "0x1102740", Offset = "0x1101940", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001176")]
	private static DLSet() { }

	[Address(RVA = "0x11027E0", Offset = "0x11019E0", Length = "0x49")]
	[CalledBy(Type = typeof(BerSet), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BerSet), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001171")]
	public DLSet() { }

	[Address(RVA = "0x11028A0", Offset = "0x1101AA0", Length = "0x5C")]
	[CalledBy(Type = typeof(BerSet), Member = "FromVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(BerSet))]
	[CalledBy(Type = typeof(BerSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BerSetParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1StreamParser)}, ReturnType = typeof(BerSet))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001172")]
	public DLSet(Asn1EncodableVector elementVector) { }

	[Address(RVA = "0x1102830", Offset = "0x1101A30", Length = "0x6A")]
	[CalledBy(Type = typeof(BerSequence), Member = "ToAsn1Set", ReturnType = typeof(Asn1Set))]
	[CalledBy(Type = typeof(BerSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001173")]
	internal DLSet(bool isSorted, Asn1Encodable[] elements) { }

	[Address(RVA = "0x1102500", Offset = "0x1101700", Length = "0xCC")]
	[CalledBy(Type = typeof(Asn1InputStream), Member = "BuildObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001170")]
	public static DLSet FromVector(Asn1EncodableVector elementVector) { }

	[Address(RVA = "0x1102690", Offset = "0x1101890", Length = "0xA5")]
	[CalledBy(Type = typeof(BerSet), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(DerSet), Member = "GetSortedDerEncodings", ReturnType = typeof(DerEncoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDLEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(IAsn1Encoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001174")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x11025D0", Offset = "0x11017D0", Length = "0xBC")]
	[CalledBy(Type = typeof(BerSet), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Asn1Encodable[])}, ReturnType = typeof(IAsn1Encoding[]))]
	[Calls(Type = typeof(DerSet), Member = "GetSortedDerEncodings", ReturnType = typeof(DerEncoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDLEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(IAsn1Encoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001175")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

}

