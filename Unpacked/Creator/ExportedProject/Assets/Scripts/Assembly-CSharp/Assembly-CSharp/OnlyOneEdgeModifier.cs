//Type is in global namespace

[ModifierID("Only One Edge")]
[Token(Token = "0x2000005")]
public class OnlyOneEdgeModifier : ProceduralImageModifier
{
	[Token(Token = "0x2000006")]
	internal enum ProceduralImageEdge
	{
		Top = 0,
		Bottom = 1,
		Left = 2,
		Right = 3,
	}

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000005")]
	private float radius; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000006")]
	private ProceduralImageEdge side; //Field offset: 0x2C

	[Token(Token = "0x17000002")]
	public float Radius
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000B")]
		 get { } //Length: 6
		[Address(RVA = "0x3C4650", Offset = "0x3C3850", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralImageModifier), Member = "get__Graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000C")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000003")]
	public ProceduralImageEdge Side
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000D")]
		 get { } //Length: 4
		[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000E")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	public OnlyOneEdgeModifier() { }

	[Address(RVA = "0x3C45D0", Offset = "0x3C37D0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000F")]
	public virtual Vector4 CalculateRadius(Rect imageRect) { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public float get_Radius() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public ProceduralImageEdge get_Side() { }

	[Address(RVA = "0x3C4650", Offset = "0x3C3850", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralImageModifier), Member = "get__Graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public void set_Side(ProceduralImageEdge value) { }

}

