namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000558")]
internal class GPUBufferAllocator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011F6")]
	private BestFitAllocator m_Low; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011F7")]
	private BestFitAllocator m_High; //Field offset: 0x18

	[Token(Token = "0x170009D3")]
	public bool isEmpty
	{
		[Address(RVA = "0x1B82210", Offset = "0x1B81410", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600267A")]
		 get { } //Length: 53
	}

	[Address(RVA = "0x1B82160", Offset = "0x1B81360", Length = "0xA1")]
	[CalledBy(Type = typeof(DataSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUBufferType), typeof(uint), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002677")]
	public GPUBufferAllocator(uint maxSize) { }

	[Address(RVA = "0x1B81EA0", Offset = "0x1B810A0", Length = "0x209")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "TryAllocFromPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Page), typeof(uint), typeof(uint), typeof(Alloc&), typeof(Alloc&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BestFitAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Alloc))]
	[Calls(Type = typeof(BestFitAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002678")]
	public Alloc Allocate(uint size, bool shortLived) { }

	[Address(RVA = "0x1B820B0", Offset = "0x1B812B0", Length = "0x7D")]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "TryAllocFromPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Page), typeof(uint), typeof(uint), typeof(Alloc&), typeof(Alloc&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle), typeof(uint), typeof(uint), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRenderDevice), Member = "AdvanceFrame", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BestFitAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002679")]
	public void Free(Alloc alloc) { }

	[Address(RVA = "0x1B82210", Offset = "0x1B81410", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600267A")]
	public bool get_isEmpty() { }

	[Address(RVA = "0x1B82130", Offset = "0x1B81330", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600267B")]
	private bool HighLowCollide() { }

}

