namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001D9")]
public class DerSet : Asn1Set
{
	[Token(Token = "0x400048E")]
	public static readonly DerSet Empty; //Field offset: 0x0

	[Address(RVA = "0x110B890", Offset = "0x110AA90", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600111A")]
	private static DerSet() { }

	[Address(RVA = "0x110B920", Offset = "0x110AB20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001111")]
	public DerSet() { }

	[Address(RVA = "0x110B900", Offset = "0x110AB00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001112")]
	internal DerSet(Asn1EncodableVector elementVector, bool doSort) { }

	[Address(RVA = "0x110B910", Offset = "0x110AB10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Asn1Set), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001113")]
	internal DerSet(bool isSorted, Asn1Encodable[] elements) { }

	[Address(RVA = "0x110B590", Offset = "0x110A790", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1OutputStream), Member = "GetContentsEncodingsDer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable[])}, ReturnType = typeof(DerEncoding[]))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001119")]
	private static DerEncoding[] CreateSortedDerEncodings(Asn1Encodable[] elements) { }

	[Address(RVA = "0x110B780", Offset = "0x110A980", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSet), Member = "GetSortedDerEncodings", ReturnType = typeof(DerEncoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDLEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(IAsn1Encoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001114")]
	internal virtual IAsn1Encoding GetEncoding(int encoding) { }

	[Address(RVA = "0x110B680", Offset = "0x110A880", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSet), Member = "GetSortedDerEncodings", ReturnType = typeof(DerEncoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDerEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DerEncoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001116")]
	internal virtual DerEncoding GetEncodingDer() { }

	[Address(RVA = "0x110B5F0", Offset = "0x110A7F0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSet), Member = "GetSortedDerEncodings", ReturnType = typeof(DerEncoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDerEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(DerEncoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001117")]
	internal virtual DerEncoding GetEncodingDerImplicit(int tagClass, int tagNo) { }

	[Address(RVA = "0x110B6F0", Offset = "0x110A8F0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DerSet), Member = "GetSortedDerEncodings", ReturnType = typeof(DerEncoding[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConstructedDLEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(IAsn1Encoding[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6001115")]
	internal virtual IAsn1Encoding GetEncodingImplicit(int encoding, int tagClass, int tagNo) { }

	[Address(RVA = "0x110B7F0", Offset = "0x110A9F0", Length = "0x92")]
	[CalledBy(Type = typeof(DerSet), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DerSet), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DerSet), Member = "GetEncodingDer", ReturnType = typeof(DerEncoding))]
	[CalledBy(Type = typeof(DerSet), Member = "GetEncodingDerImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(DerEncoding))]
	[CalledBy(Type = typeof(DLSet), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CalledBy(Type = typeof(DLSet), Member = "GetEncodingImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(IAsn1Encoding))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001118")]
	private DerEncoding[] GetSortedDerEncodings() { }

}

