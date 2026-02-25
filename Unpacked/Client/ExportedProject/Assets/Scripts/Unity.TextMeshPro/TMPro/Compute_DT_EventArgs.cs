namespace TMPro;

[Token(Token = "0x200001D")]
public class Compute_DT_EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B1")]
	public Compute_DistanceTransform_EventTypes EventType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000B2")]
	public float ProgressPercentage; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B3")]
	public Color[] Colors; //Field offset: 0x18

	[Address(RVA = "0x1888A60", Offset = "0x1887C60", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000124")]
	public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress) { }

	[Address(RVA = "0x2BE0F0", Offset = "0x2BD2F0", Length = "0x40")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000125")]
	public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors) { }

}

