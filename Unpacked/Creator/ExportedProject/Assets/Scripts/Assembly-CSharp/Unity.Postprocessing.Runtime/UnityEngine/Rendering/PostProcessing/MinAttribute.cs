namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
[Token(Token = "0x2000006")]
public sealed class MinAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000008")]
	public readonly float min; //Field offset: 0x10

	[Address(RVA = "0x1833A30", Offset = "0x1832C30", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public MinAttribute(float min) { }

}

