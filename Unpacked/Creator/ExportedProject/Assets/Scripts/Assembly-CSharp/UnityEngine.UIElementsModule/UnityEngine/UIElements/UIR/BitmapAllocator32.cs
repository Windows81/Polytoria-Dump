namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005B4")]
internal struct BitmapAllocator32
{
	[Token(Token = "0x20005B5")]
	private struct Page
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40014A1")]
		public ushort x; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40014A2")]
		public ushort y; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40014A3")]
		public int freeSlots; //Field offset: 0x4

	}

	[Token(Token = "0x400149B")]
	public const int kPageWidth = 32; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400149C")]
	private int m_PageHeight; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400149D")]
	private List<Page> m_Pages; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400149E")]
	private List<UInt32> m_AllocMap; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400149F")]
	private int m_EntryWidth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40014A0")]
	private int m_EntryHeight; //Field offset: 0x1C

	[Token(Token = "0x17000A2A")]
	public int entryHeight
	{
		[Address(RVA = "0xC4A020", Offset = "0xC49220", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002899")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000A29")]
	public int entryWidth
	{
		[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002898")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1BA3950", Offset = "0x1BA2B50", Length = "0x496")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTransform", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocClipRect", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocOpacity", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocColor", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextCoreSettings)}, ReturnType = typeof(BMPAlloc))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "CountTrailingZeroes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002896")]
	public BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	[Address(RVA = "0x1BA3DF0", Offset = "0x1BA2FF0", Length = "0x117")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002894")]
	public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1) { }

	[Address(RVA = "0x1BA3F10", Offset = "0x1BA3110", Length = "0x7C")]
	[CalledBy(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600289B")]
	private static byte CountTrailingZeroes(uint val) { }

	[Address(RVA = "0x1BA3F90", Offset = "0x1BA3190", Length = "0x1A5")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002895")]
	public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY) { }

	[Address(RVA = "0x1BA4140", Offset = "0x1BA3340", Length = "0x136")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeClipRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeOpacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "FreeTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002897")]
	public void Free(BMPAlloc alloc) { }

	[Address(RVA = "0xC4A020", Offset = "0xC49220", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002899")]
	public int get_entryHeight() { }

	[Address(RVA = "0x8520C0", Offset = "0x8512C0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002898")]
	public int get_entryWidth() { }

	[Address(RVA = "0x1BA4280", Offset = "0x1BA3480", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600289A")]
	internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y) { }

}

