namespace UnityEngine.UIElements.Layout;

[NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutModel.h")]
[RequiredByNativeCode]
[Token(Token = "0x20005F0")]
internal struct LayoutStyleData
{
	[Token(Token = "0x40015A9")]
	public static LayoutStyleData Default; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015AA")]
	public LayoutDirection Direction; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40015AB")]
	public LayoutFlexDirection FlexDirection; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40015AC")]
	public LayoutJustify JustifyContent; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40015AD")]
	public LayoutAlign AlignContent; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40015AE")]
	public LayoutAlign AlignItems; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40015AF")]
	public LayoutAlign AlignSelf; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40015B0")]
	public LayoutPositionType PositionType; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40015B1")]
	public float AspectRatio; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40015B2")]
	public LayoutWrap FlexWrap; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40015B3")]
	public LayoutOverflow Overflow; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40015B4")]
	public LayoutDisplay Display; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40015B5")]
	public float FlexGrow; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015B6")]
	public float FlexShrink; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40015B7")]
	public LayoutValue FlexBasis; //Field offset: 0x34
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40015B8")]
	public FixedBuffer9<LayoutValue> border; //Field offset: 0x3C
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40015B9")]
	public FixedBuffer9<LayoutValue> position; //Field offset: 0x84
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40015BA")]
	public FixedBuffer9<LayoutValue> margin; //Field offset: 0xCC
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40015BB")]
	public FixedBuffer9<LayoutValue> padding; //Field offset: 0x114
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x40015BC")]
	public FixedBuffer2<LayoutValue> maxDimensions; //Field offset: 0x15C
	[FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x40015BD")]
	public FixedBuffer2<LayoutValue> minDimensions; //Field offset: 0x16C
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x40015BE")]
	public FixedBuffer2<LayoutValue> dimensions; //Field offset: 0x17C

	[Address(RVA = "0x1BAF030", Offset = "0x1BAE230", Length = "0x221")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60029A3")]
	private static LayoutStyleData() { }

}

