namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
[Token(Token = "0x2000007")]
public sealed class MinMaxAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000009")]
	public readonly float min; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400000A")]
	public readonly float max; //Field offset: 0x14

	[Address(RVA = "0x1833A60", Offset = "0x1832C60", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public MinMaxAttribute(float min, float max) { }

}

