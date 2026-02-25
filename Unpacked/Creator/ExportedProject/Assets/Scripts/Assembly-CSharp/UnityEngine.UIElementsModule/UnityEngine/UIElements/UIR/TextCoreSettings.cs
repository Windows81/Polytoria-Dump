namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A7")]
internal struct TextCoreSettings : IEquatable<TextCoreSettings>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400145C")]
	public Color faceColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400145D")]
	public Color outlineColor; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400145E")]
	public float outlineWidth; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400145F")]
	public Color underlayColor; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001460")]
	public Vector2 underlayOffset; //Field offset: 0x34
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001461")]
	public float underlaySoftness; //Field offset: 0x3C

	[Address(RVA = "0x1B9FF00", Offset = "0x1B9F100", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(TextCoreSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextCoreSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600285E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B9FFB0", Offset = "0x1B9F1B0", Length = "0x197")]
	[CalledBy(Type = typeof(TextCoreSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600285F")]
	public override bool Equals(TextCoreSettings other) { }

	[Address(RVA = "0x1BA0150", Offset = "0x1B9F350", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6002860")]
	public virtual int GetHashCode() { }

}

