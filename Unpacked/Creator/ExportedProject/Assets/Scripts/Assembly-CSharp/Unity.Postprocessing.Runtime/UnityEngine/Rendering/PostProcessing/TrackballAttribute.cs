namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
[Token(Token = "0x2000009")]
public sealed class TrackballAttribute : Attribute
{
	[Token(Token = "0x200000A")]
	internal enum Mode
	{
		None = 0,
		Lift = 1,
		Gamma = 2,
		Gain = 3,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000010")]
	public readonly Mode mode; //Field offset: 0x10

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public TrackballAttribute(Mode mode) { }

}

