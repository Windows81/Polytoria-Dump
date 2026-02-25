namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000555")]
internal class BestFitAllocator
{
	[Token(Token = "0x2000557")]
	private class Block : LinkedPoolItem<Block>
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011EF")]
		public uint start; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40011F0")]
		public uint end; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40011F1")]
		public Block prev; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40011F2")]
		public Block next; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40011F3")]
		public Block prevAvailable; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40011F4")]
		public Block nextAvailable; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40011F5")]
		public bool allocated; //Field offset: 0x40

		[Token(Token = "0x170009D2")]
		public uint size
		{
			[Address(RVA = "0x1B7D600", Offset = "0x1B7C800", Length = "0x9")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x6002675")]
			 get { } //Length: 9
		}

		[Address(RVA = "0x1B7D5C0", Offset = "0x1B7C7C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002676")]
		public Block() { }

		[Address(RVA = "0x1B7D600", Offset = "0x1B7C800", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002675")]
		public uint get_size() { }

	}

	[Token(Token = "0x2000556")]
	private class BlockPool : LinkedPool<Block>
	{

		[Address(RVA = "0x1B7D4E0", Offset = "0x1B7C6E0", Length = "0xD4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6002674")]
		public BlockPool() { }

		[Address(RVA = "0x1B7D470", Offset = "0x1B7C670", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002672")]
		private static Block CreateBlock() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002673")]
		private static void ResetBlock(Block block) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40011EA")]
	private readonly uint <totalSize>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40011EB")]
	private Block m_FirstBlock; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40011EC")]
	private Block m_FirstAvailableBlock; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011ED")]
	private BlockPool m_BlockPool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011EE")]
	private uint m_HighWatermark; //Field offset: 0x30

	[Token(Token = "0x170009D1")]
	public uint highWatermark
	{
		[Address(RVA = "0x1B7D460", Offset = "0x1B7C660", Length = "0x6")]
		[CalledBy(Type = typeof(Allocator2D), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600266C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170009D0")]
	public uint totalSize
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600266B")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1B7D2D0", Offset = "0x1B7C4D0", Length = "0x189")]
	[CalledBy(Type = typeof(Area), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Allocator2D), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Alloc2D&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Allocator2D), Member = "BuildAreas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.Allocator2D+Area>), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUBufferAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600266A")]
	public BestFitAllocator(uint size) { }

	[Address(RVA = "0x1B7CA50", Offset = "0x1B7BC50", Length = "0x32E")]
	[CalledBy(Type = typeof(Allocator2D), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Alloc2D&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GPUBufferAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(Alloc))]
	[CalledBy(Type = typeof(GradientSettingsAtlas), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Alloc))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600266D")]
	public Alloc Allocate(uint size) { }

	[Address(RVA = "0x1B7CD80", Offset = "0x1B7BF80", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002670")]
	private Block BestFitFindAvailableBlock(uint size) { }

	[Address(RVA = "0x1B7CDC0", Offset = "0x1B7BFC0", Length = "0x13B")]
	[CalledBy(Type = typeof(BestFitAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600266F")]
	private Block CoalesceBlockWithPrevious(Block block) { }

	[Address(RVA = "0x1B7CF00", Offset = "0x1B7C100", Length = "0x25F")]
	[CalledBy(Type = typeof(Allocator2D), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GPUBufferAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool)}, ReturnType = typeof(Alloc))]
	[CalledBy(Type = typeof(GPUBufferAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BestFitAllocator), Member = "CoalesceBlockWithPrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Block)}, ReturnType = typeof(Block))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600266E")]
	public void Free(Alloc alloc) { }

	[Address(RVA = "0x1B7D460", Offset = "0x1B7C660", Length = "0x6")]
	[CalledBy(Type = typeof(Allocator2D), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600266C")]
	public uint get_highWatermark() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600266B")]
	public uint get_totalSize() { }

	[Address(RVA = "0x1B7D160", Offset = "0x1B7C360", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002671")]
	private void SplitBlock(Block block, uint size) { }

}

