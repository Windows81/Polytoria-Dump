namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000559")]
internal class Page : IDisposable
{
	[Token(Token = "0x200055A")]
	internal class DataSet : IDisposable
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011FD")]
		private bool <disposed>k__BackingField; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011FE")]
		public GPUBuffer<T> gpuData; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011FF")]
		public NativeArray<T> cpuData; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001200")]
		public NativeArray<GfxUpdateBufferRange> updateRanges; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001201")]
		public GPUBufferAllocator allocator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001202")]
		private readonly uint m_UpdateRangePoolSize; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001203")]
		private uint m_ElemStride; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001204")]
		private uint m_UpdateRangeMin; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001205")]
		private uint m_UpdateRangeMax; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001206")]
		private uint m_UpdateRangesEnqueued; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001207")]
		private uint m_UpdateRangesBatchStart; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001208")]
		private bool m_UpdateRangesSaturated; //Field offset: 0x0

		[Token(Token = "0x170009D6")]
		protected private bool disposed
		{
			[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002683")]
			 get { } //Length: 5
			[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002684")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x9E5140", Offset = "0x9E4340", Length = "0x1B1")]
		[CalledBy(Type = typeof(Page), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(GPUBuffer`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(GPUBufferType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(NativeArray`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GPUBufferAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002682")]
		public DataSet`1(GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize) { }

		[Address(RVA = "0x9E3BA0", Offset = "0x9E2DA0", Length = "0xCF")]
		[CalledBy(Type = typeof(Page), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GPUBuffer`1), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002685")]
		public override void Dispose() { }

		[Address(RVA = "0x9E38F0", Offset = "0x9E2AF0", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(GPUBuffer`1), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002686")]
		public void Dispose(bool disposing) { }

		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002683")]
		protected bool get_disposed() { }

		[Address(RVA = "0x9E3CF0", Offset = "0x9E2EF0", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Utility), Member = "HasMappedBufferRange", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002688")]
		private bool HasMappedBufferRange() { }

		[Address(RVA = "0x9E4150", Offset = "0x9E3350", Length = "0x1FB")]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "UpdateAfterGPUUsedData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(UInt16&), typeof(AllocToUpdate&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "AdvanceFrame", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002687")]
		public void RegisterUpdate(uint start, uint size) { }

		[Address(RVA = "0x9E4350", Offset = "0x9E3550", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600268C")]
		private void ResetUpdateState() { }

		[Address(RVA = "0x9E44D0", Offset = "0x9E36D0", Length = "0x13E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
		[Calls(Type = typeof(GPUBuffer`1), Member = "UpdateRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.GfxUpdateBufferRange>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600268A")]
		public void SendFullRange() { }

		[Address(RVA = "0x9E4750", Offset = "0x9E3950", Length = "0x202")]
		[CalledBy(Type = typeof(DataSet`1), Member = "SendUpdates", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<System.UInt16>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
		[Calls(Type = typeof(GPUBuffer`1), Member = "UpdateRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.GfxUpdateBufferRange>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600268B")]
		public void SendPartialRanges() { }

		[Address(RVA = "0x9E4F10", Offset = "0x9E4110", Length = "0x1AF")]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "OnFrameRenderingBegin", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Utility), Member = "HasMappedBufferRange", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
		[Calls(Type = typeof(GPUBuffer`1), Member = "UpdateRanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.GfxUpdateBufferRange>), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DataSet`1), Member = "SendPartialRanges", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002689")]
		public void SendUpdates() { }

		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002684")]
		private void set_disposed(bool value) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011F8")]
	private bool <disposed>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011F9")]
	public DataSet<Vertex> vertices; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011FA")]
	public DataSet<UInt16> indices; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011FB")]
	public Page next; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011FC")]
	public int framesEmpty; //Field offset: 0x30

	[Token(Token = "0x170009D4")]
	protected private bool disposed
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600267D")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600267E")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170009D5")]
	public bool isEmpty
	{
		[Address(RVA = "0x1B8A240", Offset = "0x1B89440", Length = "0x7A")]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "AdvanceFrame", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIRenderDevice), Member = "PruneUnusedPages", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002681")]
		 get { } //Length: 122
	}

	[Address(RVA = "0x1B8A0F0", Offset = "0x1B892F0", Length = "0x144")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUBufferType), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DataSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUBufferType), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600267C")]
	public Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount) { }

	[Address(RVA = "0x1B8A080", Offset = "0x1B89280", Length = "0x61")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "AdvanceFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "PruneUnusedPages", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600267F")]
	public override void Dispose() { }

	[Address(RVA = "0x1B89FF0", Offset = "0x1B891F0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DataSet`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.Page+DataSet`1<UnityEngine.UIElements.Vertex>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002680")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600267D")]
	protected bool get_disposed() { }

	[Address(RVA = "0x1B8A240", Offset = "0x1B89440", Length = "0x7A")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "AdvanceFrame", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "PruneUnusedPages", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002681")]
	public bool get_isEmpty() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600267E")]
	private void set_disposed(bool value) { }

}

