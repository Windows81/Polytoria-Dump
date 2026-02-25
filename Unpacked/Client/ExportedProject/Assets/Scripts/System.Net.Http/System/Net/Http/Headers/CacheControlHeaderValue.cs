namespace System.Net.Http.Headers;

[Token(Token = "0x200001A")]
public class CacheControlHeaderValue : ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000073")]
	private List<NameValueHeaderValue> extensions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000074")]
	private List<String> no_cache_headers; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000075")]
	private List<String> private_headers; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000076")]
	private Nullable<TimeSpan> <MaxAge>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000077")]
	private bool <MaxStale>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000078")]
	private Nullable<TimeSpan> <MaxStaleLimit>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000079")]
	private Nullable<TimeSpan> <MinFresh>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400007A")]
	private bool <MustRevalidate>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x400007B")]
	private bool <NoCache>k__BackingField; //Field offset: 0x61
	[CompilerGenerated]
	[FieldOffset(Offset = "0x62")]
	[Token(Token = "0x400007C")]
	private bool <NoStore>k__BackingField; //Field offset: 0x62
	[CompilerGenerated]
	[FieldOffset(Offset = "0x63")]
	[Token(Token = "0x400007D")]
	private bool <NoTransform>k__BackingField; //Field offset: 0x63
	[CompilerGenerated]
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400007E")]
	private bool <OnlyIfCached>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	[FieldOffset(Offset = "0x65")]
	[Token(Token = "0x400007F")]
	private bool <Private>k__BackingField; //Field offset: 0x65
	[CompilerGenerated]
	[FieldOffset(Offset = "0x66")]
	[Token(Token = "0x4000080")]
	private bool <ProxyRevalidate>k__BackingField; //Field offset: 0x66
	[CompilerGenerated]
	[FieldOffset(Offset = "0x67")]
	[Token(Token = "0x4000081")]
	private bool <Public>k__BackingField; //Field offset: 0x67
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000082")]
	private Nullable<TimeSpan> <SharedMaxAge>k__BackingField; //Field offset: 0x68

	[Token(Token = "0x1700001B")]
	public ICollection<NameValueHeaderValue> Extensions
	{
		[Address(RVA = "0x16090A0", Offset = "0x16082A0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000096")]
		 get { } //Length: 123
	}

	[Token(Token = "0x1700001C")]
	public Nullable<TimeSpan> MaxAge
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000097")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000098")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700001D")]
	public bool MaxStale
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000099")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600009A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001E")]
	public Nullable<TimeSpan> MaxStaleLimit
	{
		[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600009B")]
		 get { } //Length: 11
		[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600009C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700001F")]
	public Nullable<TimeSpan> MinFresh
	{
		[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600009D")]
		 get { } //Length: 11
		[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600009E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000020")]
	public bool MustRevalidate
	{
		[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600009F")]
		 get { } //Length: 5
		[Address(RVA = "0x3D02A0", Offset = "0x3CF4A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public bool NoCache
	{
		[Address(RVA = "0x3D0200", Offset = "0x3CF400", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 5
		[Address(RVA = "0x3D02C0", Offset = "0x3CF4C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000022")]
	public ICollection<String> NoCacheHeaders
	{
		[Address(RVA = "0x1609120", Offset = "0x1608320", Length = "0x7B")]
		[CalledBy(Type = typeof(CacheControlHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CacheControlHeaderValue&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000023")]
	public bool NoStore
	{
		[Address(RVA = "0x3D01F0", Offset = "0x3CF3F0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A4")]
		 get { } //Length: 5
		[Address(RVA = "0x3D02B0", Offset = "0x3CF4B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A5")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public bool NoTransform
	{
		[Address(RVA = "0x3D0210", Offset = "0x3CF410", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A6")]
		 get { } //Length: 5
		[Address(RVA = "0x3D02D0", Offset = "0x3CF4D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000025")]
	public bool OnlyIfCached
	{
		[Address(RVA = "0x16091A0", Offset = "0x16083A0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A8")]
		 get { } //Length: 5
		[Address(RVA = "0x1609260", Offset = "0x1608460", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60000A9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000026")]
	public bool Private
	{
		[Address(RVA = "0x1609230", Offset = "0x1608430", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AA")]
		 get { } //Length: 5
		[Address(RVA = "0x1609270", Offset = "0x1608470", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x60000AB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000027")]
	public ICollection<String> PrivateHeaders
	{
		[Address(RVA = "0x16091B0", Offset = "0x16083B0", Length = "0x7B")]
		[CalledBy(Type = typeof(CacheControlHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CacheControlHeaderValue&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000AC")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000028")]
	public bool ProxyRevalidate
	{
		[Address(RVA = "0x1609240", Offset = "0x1608440", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AD")]
		 get { } //Length: 5
		[Address(RVA = "0x1609280", Offset = "0x1608480", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000029")]
	public bool Public
	{
		[Address(RVA = "0x1609250", Offset = "0x1608450", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000AF")]
		 get { } //Length: 5
		[Address(RVA = "0x1609290", Offset = "0x1608490", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B0")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700002A")]
	public Nullable<TimeSpan> SharedMaxAge
	{
		[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B1")]
		 get { } //Length: 11
		[Address(RVA = "0x504760", Offset = "0x503960", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B2")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B8")]
	public CacheControlHeaderValue() { }

	[Address(RVA = "0x16072B0", Offset = "0x16064B0", Length = "0x2C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionExtensions), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<TSource>", "System.Collections.Generic.List`1<TSource>"}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60000B4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x16090A0", Offset = "0x16082A0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000096")]
	public ICollection<NameValueHeaderValue> get_Extensions() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000097")]
	public Nullable<TimeSpan> get_MaxAge() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000099")]
	public bool get_MaxStale() { }

	[Address(RVA = "0x3B21A0", Offset = "0x3B13A0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600009B")]
	public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[Address(RVA = "0x3B2160", Offset = "0x3B1360", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600009D")]
	public Nullable<TimeSpan> get_MinFresh() { }

	[Address(RVA = "0x3D01E0", Offset = "0x3CF3E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600009F")]
	public bool get_MustRevalidate() { }

	[Address(RVA = "0x3D0200", Offset = "0x3CF400", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A1")]
	public bool get_NoCache() { }

	[Address(RVA = "0x1609120", Offset = "0x1608320", Length = "0x7B")]
	[CalledBy(Type = typeof(CacheControlHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CacheControlHeaderValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000A3")]
	public ICollection<String> get_NoCacheHeaders() { }

	[Address(RVA = "0x3D01F0", Offset = "0x3CF3F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A4")]
	public bool get_NoStore() { }

	[Address(RVA = "0x3D0210", Offset = "0x3CF410", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A6")]
	public bool get_NoTransform() { }

	[Address(RVA = "0x16091A0", Offset = "0x16083A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A8")]
	public bool get_OnlyIfCached() { }

	[Address(RVA = "0x1609230", Offset = "0x1608430", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AA")]
	public bool get_Private() { }

	[Address(RVA = "0x16091B0", Offset = "0x16083B0", Length = "0x7B")]
	[CalledBy(Type = typeof(CacheControlHeaderValue), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CacheControlHeaderValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000AC")]
	public ICollection<String> get_PrivateHeaders() { }

	[Address(RVA = "0x1609240", Offset = "0x1608440", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AD")]
	public bool get_ProxyRevalidate() { }

	[Address(RVA = "0x1609250", Offset = "0x1608450", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AF")]
	public bool get_Public() { }

	[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B1")]
	public Nullable<TimeSpan> get_SharedMaxAge() { }

	[Address(RVA = "0x1607570", Offset = "0x1606770", Length = "0x260")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashCodeCalculator), Member = "Calculate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ICollection`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Nullable`1<System.TimeSpan>), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x60000B5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000098")]
	public void set_MaxAge(Nullable<TimeSpan> value) { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600009A")]
	public void set_MaxStale(bool value) { }

	[Address(RVA = "0x3B2220", Offset = "0x3B1420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600009C")]
	public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[Address(RVA = "0x3B21F0", Offset = "0x3B13F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600009E")]
	public void set_MinFresh(Nullable<TimeSpan> value) { }

	[Address(RVA = "0x3D02A0", Offset = "0x3CF4A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A0")]
	public void set_MustRevalidate(bool value) { }

	[Address(RVA = "0x3D02C0", Offset = "0x3CF4C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A2")]
	public void set_NoCache(bool value) { }

	[Address(RVA = "0x3D02B0", Offset = "0x3CF4B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A5")]
	public void set_NoStore(bool value) { }

	[Address(RVA = "0x3D02D0", Offset = "0x3CF4D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A7")]
	public void set_NoTransform(bool value) { }

	[Address(RVA = "0x1609260", Offset = "0x1608460", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60000A9")]
	public void set_OnlyIfCached(bool value) { }

	[Address(RVA = "0x1609270", Offset = "0x1608470", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x60000AB")]
	public void set_Private(bool value) { }

	[Address(RVA = "0x1609280", Offset = "0x1608480", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000AE")]
	public void set_ProxyRevalidate(bool value) { }

	[Address(RVA = "0x1609290", Offset = "0x1608490", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B0")]
	public void set_Public(bool value) { }

	[Address(RVA = "0x504760", Offset = "0x503960", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B2")]
	public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

	[Address(RVA = "0x16077D0", Offset = "0x16069D0", Length = "0x5AC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x60000B3")]
	private override object System.ICloneable.Clone() { }

	[Address(RVA = "0x1607D80", Offset = "0x1606F80", Length = "0x752")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CollectionExtensions), Member = "ToStringBuilder", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B7")]
	public virtual string ToString() { }

	[Address(RVA = "0x16084E0", Offset = "0x16076E0", Length = "0xBB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Lexer), Member = "TryGetTimeSpanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(System.Nullable`1<System.TimeSpan>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CacheControlHeaderValue), Member = "get_PrivateHeaders", ReturnType = typeof(System.Collections.Generic.ICollection`1<System.String>))]
	[Calls(Type = typeof(CacheControlHeaderValue), Member = "get_NoCacheHeaders", ReturnType = typeof(System.Collections.Generic.ICollection`1<System.String>))]
	[Calls(Type = typeof(string), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Lexer), Member = "Scan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Token))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B6")]
	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

}

