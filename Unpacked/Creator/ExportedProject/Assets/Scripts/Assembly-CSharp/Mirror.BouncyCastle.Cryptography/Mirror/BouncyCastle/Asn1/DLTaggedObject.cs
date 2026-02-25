namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001E8")]
public class DLTaggedObject : DerTaggedObject
{

	[Address(RVA = "0x1102DB0", Offset = "0x1101FB0", Length = "0xE")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Asn1TaggedObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001177")]
	public DLTaggedObject(bool isExplicit, int tagNo, Asn1Encodable obj) { }

	[Address(RVA = "0x1102DA0", Offset = "0x1101FA0", Length = "0xE")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Asn1TaggedObject), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001178")]
	internal DLTaggedObject(int explicitness, int tagClass, int tagNo, Asn1Encodable obj) { }

	[Address(RVA = "0x1102B80", Offset = "0x1101D80", Length = "0x18D")]
	[CalledBy(Type = typeof(BerTaggedObject), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1TaggedObject), Member = "IsExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TaggedDLEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(IAsn1Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6001179")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x11029F0", Offset = "0x1101BF0", Length = "0x188")]
	[CalledBy(Type = typeof(BerTaggedObject), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1TaggedObject), Member = "IsExplicit", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TaggedDLEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(IAsn1Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600117A")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

	[Address(RVA = "0x1102D10", Offset = "0x1101F10", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1Sequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[Token(Token = "0x600117B")]
	internal virtual Asn1Sequence RebuildConstructed(Asn1Object asn1Object) { }

}

