//Type is in global namespace

[ModifierID("Free")]
[Token(Token = "0x2000004")]
public class FreeModifier : ProceduralImageModifier
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000004")]
	private Vector4 radius; //Field offset: 0x28

	[Token(Token = "0x17000001")]
	public Vector4 Radius
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		 get { } //Length: 11
		[Address(RVA = "0x3B01D0", Offset = "0x3AF3D0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralImageModifier), Member = "get__Graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000007")]
		 set { } //Length: 55
	}

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public FreeModifier() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public virtual Vector4 CalculateRadius(Rect imageRect) { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public Vector4 get_Radius() { }

	[Address(RVA = "0x3B0180", Offset = "0x3AF380", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000009")]
	protected void OnValidate() { }

	[Address(RVA = "0x3B01D0", Offset = "0x3AF3D0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralImageModifier), Member = "get__Graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public void set_Radius(Vector4 value) { }

}

