namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000115")]
public sealed class ColorUsageAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004FF")]
	public readonly bool showAlpha; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000500")]
	public readonly bool hdr; //Field offset: 0x19
	[FieldOffset(Offset = "0x1C")]
	[Obsolete("This field is no longer used for anything.")]
	[Token(Token = "0x4000501")]
	public readonly float minBrightness; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Obsolete("This field is no longer used for anything.")]
	[Token(Token = "0x4000502")]
	public readonly float maxBrightness; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Obsolete("This field is no longer used for anything.")]
	[Token(Token = "0x4000503")]
	public readonly float minExposureValue; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Obsolete("This field is no longer used for anything.")]
	[Token(Token = "0x4000504")]
	public readonly float maxExposureValue; //Field offset: 0x28

	[Address(RVA = "0x195DAE0", Offset = "0x195CCE0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000892")]
	public ColorUsageAttribute(bool showAlpha) { }

	[Address(RVA = "0x195DA80", Offset = "0x195CC80", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000893")]
	public ColorUsageAttribute(bool showAlpha, bool hdr) { }

}

