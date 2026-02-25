namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
[Token(Token = "0x2000005")]
public sealed class MaxAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000007")]
	public readonly float max; //Field offset: 0x10

	[Address(RVA = "0x1833A30", Offset = "0x1832C30", Length = "0x28")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public MaxAttribute(float max) { }

}

