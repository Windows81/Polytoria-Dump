namespace UnityEngine.UIElements;

[Token(Token = "0x2000503")]
public sealed class VectorImage : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400108E")]
	internal int version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400108F")]
	internal Texture2D atlas; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4001090")]
	internal VectorImageVertex[] vertices; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4001091")]
	internal UInt16[] indices; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4001092")]
	internal GradientSettings[] settings; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4001093")]
	internal Vector2 size; //Field offset: 0x40

	[Token(Token = "0x170009A8")]
	public float height
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024DF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170009A7")]
	public float width
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024DE")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1B70F50", Offset = "0x1B70150", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60024E0")]
	public VectorImage() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024DF")]
	public float get_height() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024DE")]
	public float get_width() { }

}

