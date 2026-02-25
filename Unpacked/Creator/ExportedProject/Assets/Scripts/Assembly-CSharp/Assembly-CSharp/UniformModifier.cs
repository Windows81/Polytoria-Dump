//Type is in global namespace

[ModifierID("Uniform")]
[Token(Token = "0x2000008")]
public class UniformModifier : ProceduralImageModifier
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400000C")]
	private float radius; //Field offset: 0x28

	[Token(Token = "0x17000004")]
	public float Radius
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000013")]
		 get { } //Length: 6
		[Address(RVA = "0x3C4650", Offset = "0x3C3850", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralImageModifier), Member = "get__Graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000014")]
		 set { } //Length: 53
	}

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000016")]
	public UniformModifier() { }

	[Address(RVA = "0x3C8E40", Offset = "0x3C8040", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000015")]
	public virtual Vector4 CalculateRadius(Rect imageRect) { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public float get_Radius() { }

	[Address(RVA = "0x3C4650", Offset = "0x3C3850", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralImageModifier), Member = "get__Graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	public void set_Radius(float value) { }

}

