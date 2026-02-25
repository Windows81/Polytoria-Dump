namespace Mirror.BouncyCastle.Asn1;

[DefaultMember("Item")]
[Token(Token = "0x20001A9")]
public abstract class Asn1Set : Asn1Object, IEnumerable<Asn1Encodable>, IEnumerable
{
	[Token(Token = "0x20001AA")]
	public class Meta : Asn1UniversalType
	{
		[Token(Token = "0x4000437")]
		internal static readonly Asn1UniversalType Instance; //Field offset: 0x0

		[Address(RVA = "0x10F1AA0", Offset = "0x10F0CA0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Asn1UniversalType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000FC0")]
		private static Meta() { }

		[Address(RVA = "0x10F1B60", Offset = "0x10F0D60", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Asn1UniversalType), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000FBE")]
		private Meta() { }

		[Address(RVA = "0x10F18F0", Offset = "0x10F0AF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000FBF")]
		internal virtual Asn1Object FromImplicitConstructed(Asn1Sequence sequence) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000435")]
	internal readonly Asn1Encodable[] m_elements; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000436")]
	internal DerEncoding[] m_sortedDerEncodings; //Field offset: 0x18

	[Token(Token = "0x17000185")]
	public override int Count
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000FB9")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x10EB060", Offset = "0x10EA260", Length = "0x7D")]
	[CalledBy(Type = typeof(DerSet), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSet), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DLSet), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DLSet), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FB4")]
	protected private Asn1Set() { }

	[Address(RVA = "0x10EADD0", Offset = "0x10E9FD0", Length = "0x23F")]
	[CalledBy(Type = typeof(DerSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DerSetParser), Member = "ToAsn1Object", ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(DLSet), Member = "FromVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(DLSet))]
	[CalledBy(Type = typeof(DLSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Asn1EncodableVector), Member = "TakeElements", ReturnType = typeof(Asn1Encodable[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1EncodableVector), Member = "CopyElements", ReturnType = typeof(Asn1Encodable[]))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000FB5")]
	protected private Asn1Set(Asn1EncodableVector elementVector, bool doSort) { }

	[Address(RVA = "0x10EB010", Offset = "0x10EA210", Length = "0x44")]
	[CalledBy(Type = typeof(DerSequence), Member = "ToAsn1Set", ReturnType = typeof(Asn1Set))]
	[CalledBy(Type = typeof(DerSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DLSequence), Member = "ToAsn1Set", ReturnType = typeof(Asn1Set))]
	[CalledBy(Type = typeof(DLSet), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Asn1Encodable[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000FB6")]
	protected private Asn1Set(bool isSorted, Asn1Encodable[] elements) { }

	[Address(RVA = "0x10EA850", Offset = "0x10E9A50", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000FBB")]
	protected virtual bool Asn1Equals(Asn1Object asn1Object) { }

	[Address(RVA = "0x10EAA10", Offset = "0x10E9C10", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000FBA")]
	protected virtual int Asn1GetHashCode() { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB9")]
	public override int get_Count() { }

	[Address(RVA = "0x10EAAD0", Offset = "0x10E9CD0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FB8")]
	public override IEnumerator<Asn1Encodable> GetEnumerator() { }

	[Address(RVA = "0x10EAB20", Offset = "0x10E9D20", Length = "0xC4")]
	[CalledBy(Type = typeof(PrivateKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Asn1UniversalType), Member = "GetContextInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(bool)}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000FB3")]
	public static Asn1Set GetInstance(Asn1TaggedObject taggedObject, bool declaredExplicit) { }

	[Address(RVA = "0x10EABF0", Offset = "0x10E9DF0", Length = "0x194")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000FBD")]
	private static DerEncoding[] SortElements(Asn1Encodable[] elements) { }

	[Address(RVA = "0x5C5140", Offset = "0x5C4340", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FB7")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x10EAD90", Offset = "0x10E9F90", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CollectionUtilities), Member = "ToString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(string))]
	[Token(Token = "0x6000FBC")]
	public virtual string ToString() { }

}

