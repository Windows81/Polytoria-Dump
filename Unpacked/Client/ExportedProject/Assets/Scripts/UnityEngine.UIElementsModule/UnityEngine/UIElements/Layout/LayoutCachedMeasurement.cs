namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005C8")]
internal struct LayoutCachedMeasurement
{
	[Token(Token = "0x40014F1")]
	public static LayoutCachedMeasurement Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014F2")]
	public float AvailableWidth; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40014F3")]
	public float AvailableHeight; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40014F4")]
	public float ParentWidth; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40014F5")]
	public float ParentHeight; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014F6")]
	public LayoutMeasureMode WidthMeasureMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40014F7")]
	public LayoutMeasureMode HeightMeasureMode; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40014F8")]
	public float ComputedWidth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40014F9")]
	public float ComputedHeight; //Field offset: 0x1C

	[Address(RVA = "0x1BA84B0", Offset = "0x1BA76B0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600295A")]
	private static LayoutCachedMeasurement() { }

}

