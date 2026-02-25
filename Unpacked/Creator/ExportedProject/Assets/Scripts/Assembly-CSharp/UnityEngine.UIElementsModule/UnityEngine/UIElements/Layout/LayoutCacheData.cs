namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005C7")]
internal struct LayoutCacheData
{
	[Token(Token = "0x40014ED")]
	public static LayoutCacheData Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014EE")]
	public uint NextCachedMeasurementsIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40014EF")]
	public FixedBuffer16<LayoutCachedMeasurement> cachedMeasurements; //Field offset: 0x4
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x40014F0")]
	public LayoutCachedMeasurement CachedLayout; //Field offset: 0x204

	[Address(RVA = "0x1BA83A0", Offset = "0x1BA75A0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6002959")]
	private static LayoutCacheData() { }

}

