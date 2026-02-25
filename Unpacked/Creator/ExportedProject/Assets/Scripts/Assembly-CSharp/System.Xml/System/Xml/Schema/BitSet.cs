namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x20000CE")]
internal sealed class BitSet
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400046B")]
	private int count; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400046C")]
	private UInt32[] bits; //Field offset: 0x18

	[Token(Token = "0x170001F5")]
	public int Count
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000879")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001F6")]
	public bool Item
	{
		[Address(RVA = "0x16984A0", Offset = "0x16976A0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600087A")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000877")]
	private BitSet() { }

	[Address(RVA = "0x1698790", Offset = "0x1697990", Length = "0x64")]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000878")]
	public BitSet(int count) { }

	[Address(RVA = "0x1698010", Offset = "0x1697210", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600087F")]
	public void And(BitSet other) { }

	[Address(RVA = "0x16980F0", Offset = "0x16972F0", Length = "0x53")]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600087B")]
	public void Clear() { }

	[Address(RVA = "0x1698150", Offset = "0x1697350", Length = "0xE7")]
	[CalledBy(Type = typeof(SequenceNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(BitSet))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000883")]
	public BitSet Clone() { }

	[Address(RVA = "0x1698240", Offset = "0x1697440", Length = "0x8E")]
	[CalledBy(Type = typeof(BitSet), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BitSet), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LeafNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SequenceNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlusNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StarNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(BitSet))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000886")]
	private void EnsureLength(int nRequiredLength) { }

	[Address(RVA = "0x16982D0", Offset = "0x16974D0", Length = "0x182")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000882")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x16984A0", Offset = "0x16976A0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600087D")]
	public bool Get(int index) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000879")]
	public int get_Count() { }

	[Address(RVA = "0x16984A0", Offset = "0x16976A0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600087A")]
	public bool get_Item(int index) { }

	[Address(RVA = "0x1698460", Offset = "0x1697660", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000881")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x16984F0", Offset = "0x16976F0", Length = "0xD8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000884")]
	public bool Intersects(BitSet other) { }

	[Address(RVA = "0x16985D0", Offset = "0x16977D0", Length = "0x9B")]
	[CalledBy(Type = typeof(PlusNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StarNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckCMUPAWithLeafRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(BitSet))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600087E")]
	public int NextSet(int startFrom) { }

	[Address(RVA = "0x1698670", Offset = "0x1697870", Length = "0x9D")]
	[CalledBy(Type = typeof(ChoiceNode), Member = "ConstructChildPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SyntaxTreeNode), typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChoiceNode), Member = "ConstructPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "GetApplicableMinMaxFollowPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet), typeof(BitSet[])}, ReturnType = typeof(BitSet))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "BuildTransitionTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(int)}, ReturnType = typeof(Int32[][]))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000880")]
	public void Or(BitSet other) { }

	[Address(RVA = "0x1698710", Offset = "0x1697910", Length = "0x60")]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "CalculateTotalFollowposForRangeNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet), typeof(BitSet[]), typeof(BitSet&)}, ReturnType = typeof(BitSet[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600087C")]
	public void Set(int index) { }

	[Address(RVA = "0x1698780", Offset = "0x1697980", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000885")]
	private int Subscript(int bitIndex) { }

}

