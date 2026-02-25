namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000582")]
internal class NativePagedList : IDisposable
{
	[Token(Token = "0x2000583")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001343")]
		private NativePagedList<T> m_NativePagedList; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001344")]
		private NativeArray<T> m_CurrentPage; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001345")]
		private int m_IndexInCurrentPage; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001346")]
		private int m_IndexOfCurrentPage; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001347")]
		private int m_CountInCurrentPage; //Field offset: 0x0

		[Address(RVA = "0xB1CEA0", Offset = "0xB1C0A0", Length = "0x2EF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600275C")]
		public Enumerator(NativePagedList<T> nativePagedList, int offset) { }

		[Address(RVA = "0xB12BF0", Offset = "0xB11DF0", Length = "0x47B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600275E")]
		public T GetNext() { }

		[Address(RVA = "0xB13070", Offset = "0xB12270", Length = "0xC")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Texture)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600275D")]
		public bool HasNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400133B")]
	private readonly int k_PoolCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400133C")]
	private List<NativeArray`1<T>> m_Pages; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400133D")]
	private NativeArray<T> m_LastPage; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400133E")]
	private int m_CountInLastPage; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400133F")]
	private Allocator m_FirstPageAllocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001340")]
	private Allocator m_OtherPagesAllocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001341")]
	private List<NativeSlice`1<T>> m_Enumerator; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001342")]
	private bool <disposed>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170009EE")]
	protected private bool disposed
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002758")]
		 get { } //Length: 5
		[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002759")]
		private set { } //Length: 4
	}

	[Address(RVA = "0xE231C0", Offset = "0xE223C0", Length = "0x167")]
	[CalledBy(Type = typeof(JobManager), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002752")]
	public NativePagedList`1(int poolCapacity, Allocator firstPageAllocator = 4, Allocator otherPagesAllocator = 4) { }

	[Address(RVA = "0xE20770", Offset = "0xE1F970", Length = "0x304")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JobManager), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConvertMeshJobData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.ConvertMeshJobData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002753")]
	public void Add(ref T data) { }

	[Address(RVA = "0xE20E50", Offset = "0xE20050", Length = "0x22F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.ConvertMeshJobData>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002754")]
	public void Add(T data) { }

	[Address(RVA = "0xE210A0", Offset = "0xE202A0", Length = "0x11D")]
	[CalledBy(Type = typeof(JobManager), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JobManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600275A")]
	public override void Dispose() { }

	[Address(RVA = "0xE212E0", Offset = "0xE204E0", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600275B")]
	protected void Dispose(bool disposing) { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002758")]
	protected bool get_disposed() { }

	[Address(RVA = "0xE21A30", Offset = "0xE20C30", Length = "0x91")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002756")]
	public int GetCount() { }

	[Address(RVA = "0xE22380", Offset = "0xE21580", Length = "0x28D")]
	[CalledBy(Type = typeof(JobManager), Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JobManager), Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002755")]
	public List<NativeSlice`1<T>> GetPages() { }

	[Address(RVA = "0xE22850", Offset = "0xE21A50", Length = "0x19D")]
	[CalledBy(Type = typeof(JobManager), Member = "CompleteNudgeJobs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JobManager), Member = "CompleteConvertMeshJobs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JobManager), Member = "CompleteCopyMeshJobs", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002757")]
	public void Reset() { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002759")]
	private void set_disposed(bool value) { }

}

