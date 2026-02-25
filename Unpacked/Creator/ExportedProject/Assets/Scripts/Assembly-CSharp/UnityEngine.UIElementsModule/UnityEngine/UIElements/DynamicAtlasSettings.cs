namespace UnityEngine.UIElements;

[Token(Token = "0x2000261")]
public class DynamicAtlasSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400094B")]
	private int m_MinAtlasSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400094C")]
	private int m_MaxAtlasSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400094D")]
	private int m_MaxSubTextureSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400094E")]
	private DynamicAtlasFilters m_ActiveFilters; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400094F")]
	private DynamicAtlasCustomFilter m_CustomFilter; //Field offset: 0x20

	[Token(Token = "0x17000311")]
	public DynamicAtlasFilters activeFilters
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001098")]
		 get { } //Length: 4
		[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001099")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000313")]
	public DynamicAtlasCustomFilter customFilter
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600109B")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600109C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000312")]
	public static DynamicAtlasFilters defaultFilters
	{
		[Address(RVA = "0x1C66430", Offset = "0x1C65630", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600109A")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000314")]
	public static DynamicAtlasSettings defaults
	{
		[Address(RVA = "0x1C66440", Offset = "0x1C65640", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600109D")]
		 get { } //Length: 128
	}

	[Token(Token = "0x1700030F")]
	public int maxAtlasSize
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001094")]
		 get { } //Length: 4
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001095")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000310")]
	public int maxSubTextureSize
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001096")]
		 get { } //Length: 4
		[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001097")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700030E")]
	public int minAtlasSize
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001092")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001093")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600109E")]
	public DynamicAtlasSettings() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001098")]
	public DynamicAtlasFilters get_activeFilters() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600109B")]
	public DynamicAtlasCustomFilter get_customFilter() { }

	[Address(RVA = "0x1C66430", Offset = "0x1C65630", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600109A")]
	public static DynamicAtlasFilters get_defaultFilters() { }

	[Address(RVA = "0x1C66440", Offset = "0x1C65640", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600109D")]
	public static DynamicAtlasSettings get_defaults() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001094")]
	public int get_maxAtlasSize() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001096")]
	public int get_maxSubTextureSize() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001092")]
	public int get_minAtlasSize() { }

	[Address(RVA = "0x389410", Offset = "0x388610", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001099")]
	public void set_activeFilters(DynamicAtlasFilters value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600109C")]
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001095")]
	public void set_maxAtlasSize(int value) { }

	[Address(RVA = "0x2F79C0", Offset = "0x2F6BC0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001097")]
	public void set_maxSubTextureSize(int value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001093")]
	public void set_minAtlasSize(int value) { }

}

