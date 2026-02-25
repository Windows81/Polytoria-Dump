namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000562")]
internal class EntryPreProcessor
{
	[Token(Token = "0x2000563")]
	internal struct AllocSize
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001241")]
		public int vertexCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001242")]
		public int indexCount; //Field offset: 0x4

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001239")]
	private int m_ChildrenIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400123A")]
	private List<AllocSize> m_Allocs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400123B")]
	private List<AllocSize> m_HeadAllocs; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400123C")]
	private List<AllocSize> m_TailAllocs; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400123D")]
	private List<Entry> m_FlattenedEntries; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400123E")]
	private AllocSize m_Pending; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400123F")]
	private Stack<AllocSize> m_Mask; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001240")]
	private bool m_IsPushingMask; //Field offset: 0x48

	[Token(Token = "0x170009D7")]
	public int childrenIndex
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026A0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170009DA")]
	public List<Entry> flattenedEntries
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60026A3")]
		 get { } //Length: 95
	}

	[Token(Token = "0x170009D8")]
	public List<AllocSize> headAllocs
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026A1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170009D9")]
	public List<AllocSize> tailAllocs
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026A2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1B7EC60", Offset = "0x1B7DE60", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60026A9")]
	public EntryPreProcessor() { }

	[Address(RVA = "0x1B7E330", Offset = "0x1B7D530", Length = "0xD0")]
	[CalledBy(Type = typeof(EntryPreProcessor), Member = "PreProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryPreProcessor), Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B7A550")]
	[Calls(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026A7")]
	private void Add(int vertexCount, int indexCount) { }

	[Address(RVA = "0x1B7E410", Offset = "0x1B7D610", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026A5")]
	public void ClearReferences() { }

	[Address(RVA = "0x1B7E470", Offset = "0x1B7D670", Length = "0x2E8")]
	[CalledBy(Type = typeof(EntryPreProcessor), Member = "PreProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EntryPreProcessor), Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EntryPreProcessor), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Stack`1), Member = "TryPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B7A550")]
	[Calls(Type = typeof(EntryPreProcessor), Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026A6")]
	private void DoEvaluate(Entry entry) { }

	[Address(RVA = "0x1B7E790", Offset = "0x1B7D990", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60026A8")]
	private void Flush() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026A0")]
	public int get_childrenIndex() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026A3")]
	public List<Entry> get_flattenedEntries() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026A1")]
	public List<AllocSize> get_headAllocs() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026A2")]
	public List<AllocSize> get_tailAllocs() { }

	[Address(RVA = "0x1B7E840", Offset = "0x1B7DA40", Length = "0x3F0")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Stack`1), Member = "TryPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B7A550")]
	[Calls(Type = typeof(EntryPreProcessor), Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EntryPreProcessor), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60026A4")]
	public void PreProcess(Entry root) { }

}

