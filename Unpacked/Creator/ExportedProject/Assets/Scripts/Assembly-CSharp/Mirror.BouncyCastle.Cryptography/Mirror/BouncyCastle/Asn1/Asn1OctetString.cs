namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001A1")]
public abstract class Asn1OctetString : Asn1Object, Asn1OctetStringParser, IAsn1Convertible
{
	[Token(Token = "0x20001A2")]
	public class Meta : Asn1UniversalType
	{
		[Token(Token = "0x400042E")]
		internal static readonly Asn1UniversalType Instance; //Field offset: 0x0

		[Address(RVA = "0x10F19E0", Offset = "0x10F0BE0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Asn1UniversalType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000F72")]
		private static Meta() { }

		[Address(RVA = "0x10F1BD0", Offset = "0x10F0DD0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Asn1UniversalType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000F6F")]
		private Meta() { }

		[Address(RVA = "0x10F18C0", Offset = "0x10F0AC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000F71")]
		internal virtual Asn1Object FromImplicitConstructed(Asn1Sequence sequence) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F70")]
		internal virtual Asn1Object FromImplicitPrimitive(DerOctetString octetString) { }

	}

	[Token(Token = "0x400042C")]
	internal static readonly Byte[] EmptyOctets; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400042D")]
	internal readonly Byte[] contents; //Field offset: 0x10

	[Address(RVA = "0x10E7BF0", Offset = "0x10E6DF0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F6E")]
	private static Asn1OctetString() { }

	[Address(RVA = "0x10E7C60", Offset = "0x10E6E60", Length = "0x7E")]
	[CalledBy(Type = typeof(X9FieldElement), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(DerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerOctetStringParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(DerSequence), Member = "ToAsn1OctetString", ReturnType = typeof(Asn1OctetString))]
	[CalledBy(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECPoint), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X9ECPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECPrivateKeyStructure), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(BigInteger), typeof(DerBitString), typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F66")]
	internal Asn1OctetString(Byte[] contents) { }

	[Address(RVA = "0x10E7580", Offset = "0x10E6780", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000F6B")]
	protected virtual bool Asn1Equals(Asn1Object asn1Object) { }

	[Address(RVA = "0x10E7660", Offset = "0x10E6860", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F6A")]
	protected virtual int Asn1GetHashCode() { }

	[Address(RVA = "0x10E76D0", Offset = "0x10E68D0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerOctetString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F6D")]
	internal static Asn1OctetString CreatePrimitive(Byte[] contents) { }

	[Address(RVA = "0x10E7730", Offset = "0x10E6930", Length = "0x2E1")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "GetRawKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X9Curve), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X9FieldID), typeof(BigInteger), typeof(BigInteger), typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PrivateKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Platform), Member = "GetTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Asn1UniversalType), Member = "CheckedCast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Object)}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(Asn1Object), Member = "FromByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Token(Token = "0x6000F64")]
	public static Asn1OctetString GetInstance(object obj) { }

	[Address(RVA = "0x10E7A20", Offset = "0x10E6C20", Length = "0xC4")]
	[CalledBy(Type = typeof(DerExternal), Member = "GetExternalContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1UniversalType), Member = "GetContextInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(bool)}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000F65")]
	public static Asn1OctetString GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F68")]
	public override Byte[] GetOctets() { }

	[Address(RVA = "0x10E7B50", Offset = "0x10E6D50", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000F69")]
	public override int GetOctetsLength() { }

	[Address(RVA = "0x10E7AF0", Offset = "0x10E6CF0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000F67")]
	public override Stream GetOctetStream() { }

	[Address(RVA = "0x10E7B80", Offset = "0x10E6D80", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Hex), Member = "ToHexString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000F6C")]
	public virtual string ToString() { }

}

