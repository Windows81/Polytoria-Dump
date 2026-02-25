namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000540")]
internal class Allocator2D
{
	[Token(Token = "0x2000543")]
	internal struct Alloc2D
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001170")]
		public RectInt rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001171")]
		public Row row; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001172")]
		public Alloc alloc; //Field offset: 0x18

		[Address(RVA = "0x1B5C9C0", Offset = "0x1B5BBC0", Length = "0x134")]
		[CalledBy(Type = typeof(Allocator2D), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Alloc2D&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600260C")]
		public Alloc2D(Row row, Alloc alloc, int width, int height) { }

	}

	[Token(Token = "0x2000541")]
	internal class Area
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001168")]
		public RectInt rect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001169")]
		public BestFitAllocator allocator; //Field offset: 0x20

		[Address(RVA = "0x1B5D950", Offset = "0x1B5CB50", Length = "0x7E")]
		[CalledBy(Type = typeof(Allocator2D), Member = "BuildAreas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.Allocator2D+Area>), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002607")]
		public Area(RectInt rect) { }

	}

	[Token(Token = "0x2000542")]
	internal class Row : LinkedPoolItem<Row>
	{
		[Token(Token = "0x400116F")]
		public static readonly LinkedPool<Row> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400116A")]
		public RectInt rect; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400116B")]
		public Area area; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400116C")]
		public BestFitAllocator allocator; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400116D")]
		public Alloc alloc; //Field offset: 0x38
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400116E")]
		public Row next; //Field offset: 0x50

		[Address(RVA = "0x1B66E20", Offset = "0x1B66020", Length = "0x11E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(LinkedPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600260B")]
		private static Row() { }

		[Address(RVA = "0x1B66F40", Offset = "0x1B66140", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600260A")]
		public Row() { }

		[Address(RVA = "0x1B66D40", Offset = "0x1B65F40", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002608")]
		private static Row Create() { }

		[Address(RVA = "0x1B66DB0", Offset = "0x1B65FB0", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002609")]
		private static void Reset(Row row) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001162")]
	private readonly Vector2Int m_MinSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001163")]
	private readonly Vector2Int m_MaxSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001164")]
	private readonly Vector2Int m_MaxAllocSize; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001165")]
	private readonly int m_RowHeightBias; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001166")]
	private readonly Row[] m_Rows; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001167")]
	private readonly List<Area> m_Areas; //Field offset: 0x38

	[Address(RVA = "0x1B5D640", Offset = "0x1B5C840", Length = "0x305")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat), typeof(FilterMode), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Allocator2D), Member = "BuildAreas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.Allocator2D+Area>), typeof(Vector2Int), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRUtility), Member = "GetPrevPow2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2Exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002601")]
	public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	[Address(RVA = "0x1B5CB00", Offset = "0x1B5BD00", Length = "0x231")]
	[CalledBy(Type = typeof(Allocator2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int), typeof(Vector2Int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Area), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectInt)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002604")]
	private static void BuildAreas(List<Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	[Address(RVA = "0x1B5CD40", Offset = "0x1B5BF40", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2Exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x6002606")]
	private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) { }

	[Address(RVA = "0x1B5CDB0", Offset = "0x1B5BFB0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "GetPrevPow2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002605")]
	private static Vector2Int ComputeMaxAllocSize(List<Area> areas, int rowHeightBias) { }

	[Address(RVA = "0x1B5CE90", Offset = "0x1B5C090", Length = "0x26B")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc2D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(LinkedPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(BestFitAllocator), Member = "get_highWatermark", ReturnType = typeof(uint))]
	[Calls(Type = typeof(BestFitAllocator), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Alloc)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2Exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002603")]
	public void Free(Alloc2D alloc2D) { }

	[Address(RVA = "0x1B5D100", Offset = "0x1B5C300", Length = "0x538")]
	[CalledBy(Type = typeof(DynamicAtlasPage), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Alloc2D&), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18191B6F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18191B610")]
	[Calls(Type = typeof(BestFitAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LinkedPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(BestFitAllocator), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Alloc))]
	[Calls(Type = typeof(UIRUtility), Member = "GetNextPow2Exp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Alloc2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Row), typeof(Alloc), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002602")]
	public bool TryAllocate(int width, int height, out Alloc2D alloc2D) { }

}

