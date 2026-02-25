namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x20000D2")]
internal class Positions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000477")]
	private ArrayList positions; //Field offset: 0x10

	[Token(Token = "0x170001FA")]
	public int Count
	{
		[Address(RVA = "0x143D440", Offset = "0x143C640", Length = "0x2A")]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000895")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001F9")]
	public Position Item
	{
		[Address(RVA = "0x16B0DB0", Offset = "0x16AFFB0", Length = "0x9A")]
		[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
		[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000894")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x16B0D40", Offset = "0x16AFF40", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000896")]
	public Positions() { }

	[Address(RVA = "0x16B0C90", Offset = "0x16AFE90", Length = "0xA5")]
	[CalledBy(Type = typeof(NamespaceListNode), Member = "ExpandTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode), typeof(SymbolsDictionary), typeof(Positions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000893")]
	public int Add(int symbol, object particle) { }

	[Address(RVA = "0x143D440", Offset = "0x143C640", Length = "0x2A")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000895")]
	public int get_Count() { }

	[Address(RVA = "0x16B0DB0", Offset = "0x16AFFB0", Length = "0x9A")]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000894")]
	public Position get_Item(int pos) { }

}

