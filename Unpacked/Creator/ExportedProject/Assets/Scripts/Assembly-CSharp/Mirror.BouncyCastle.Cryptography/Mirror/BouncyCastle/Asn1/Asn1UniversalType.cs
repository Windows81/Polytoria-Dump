namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001AF")]
internal abstract class Asn1UniversalType : Asn1Type
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000442")]
	internal readonly Asn1Tag m_tag; //Field offset: 0x18

	[Address(RVA = "0x10ECF60", Offset = "0x10EC160", Length = "0x8D")]
	[CalledBy(Type = typeof(Meta), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Meta), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000FE2")]
	internal Asn1UniversalType(Type platformType, int tagNo) { }

	[Address(RVA = "0x10ECCE0", Offset = "0x10EBEE0", Length = "0xBC")]
	[CalledBy(Type = typeof(Asn1OctetString), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Asn1OctetString))]
	[CalledBy(Type = typeof(Asn1Sequence), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Asn1Sequence))]
	[CalledBy(Type = typeof(Asn1TaggedObject), Member = "GetBaseUniversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Asn1UniversalType)}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1UniversalType), Member = "FromByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1UniversalType), Member = "GetContextInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(bool)}, ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(Platform), Member = "GetTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FE3")]
	internal Asn1Object CheckedCast(Asn1Object asn1Object) { }

	[Address(RVA = "0x10ECDA0", Offset = "0x10EBFA0", Length = "0x29")]
	[CalledBy(Type = typeof(DerInteger), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DerInteger))]
	[CalledBy(Type = typeof(DerObjectIdentifier), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DerObjectIdentifier))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Asn1Object), Member = "FromByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(Asn1UniversalType), Member = "CheckedCast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Object)}, ReturnType = typeof(Asn1Object))]
	[Token(Token = "0x6000FE6")]
	internal Asn1Object FromByteArray(Byte[] bytes) { }

	[Address(RVA = "0x10ECDD0", Offset = "0x10EBFD0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000FE5")]
	internal override Asn1Object FromImplicitConstructed(Asn1Sequence sequence) { }

	[Address(RVA = "0x10ECE20", Offset = "0x10EC020", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000FE4")]
	internal override Asn1Object FromImplicitPrimitive(DerOctetString octetString) { }

	[Address(RVA = "0x10ECE70", Offset = "0x10EC070", Length = "0xEB")]
	[CalledBy(Type = typeof(Asn1OctetString), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(bool)}, ReturnType = typeof(Asn1OctetString))]
	[CalledBy(Type = typeof(Asn1Set), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(bool)}, ReturnType = typeof(Asn1Set))]
	[CalledBy(Type = typeof(DerBitString), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(bool)}, ReturnType = typeof(DerBitString))]
	[CalledBy(Type = typeof(DerExternal), Member = "GetExternalContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Asn1UniversalType), Member = "CheckedCast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Object)}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Asn1Utilities), Member = "GetTagClassText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1TaggedObject), Member = "GetBaseUniversal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Asn1UniversalType)}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(Asn1Utilities), Member = "GetTagClassText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000FE7")]
	internal Asn1Object GetContextInstance(Asn1TaggedObject taggedObject, bool declaredExplicit) { }

}

