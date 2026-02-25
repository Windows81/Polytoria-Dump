namespace UnityEngine.UIElements;

[Token(Token = "0x20003E4")]
internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D19")]
	public Color backgroundColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D1A")]
	public Background backgroundImage; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D1B")]
	public BackgroundPosition backgroundPositionX; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D1C")]
	public BackgroundPosition backgroundPositionY; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D1D")]
	public BackgroundRepeat backgroundRepeat; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D1E")]
	public BackgroundSize backgroundSize; //Field offset: 0x50
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000D1F")]
	public Color borderBottomColor; //Field offset: 0x64
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000D20")]
	public Length borderBottomLeftRadius; //Field offset: 0x74
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000D21")]
	public Length borderBottomRightRadius; //Field offset: 0x7C
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000D22")]
	public Color borderLeftColor; //Field offset: 0x84
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000D23")]
	public Color borderRightColor; //Field offset: 0x94
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000D24")]
	public Color borderTopColor; //Field offset: 0xA4
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000D25")]
	public Length borderTopLeftRadius; //Field offset: 0xB4
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000D26")]
	public Length borderTopRightRadius; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000D27")]
	public float opacity; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000D28")]
	public OverflowInternal overflow; //Field offset: 0xC8

	[Address(RVA = "0x1B0D1C0", Offset = "0x1B0C3C0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D98")]
	public override VisualData Copy() { }

	[Address(RVA = "0x1B21790", Offset = "0x1B20990", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001D99")]
	public override void CopyFrom(ref VisualData other) { }

	[Address(RVA = "0x1B218B0", Offset = "0x1B20AB0", Length = "0x127")]
	[CalledBy(Type = typeof(VisualData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VisualData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData), typeof(VisualData)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001D9B")]
	public override bool Equals(VisualData other) { }

	[Address(RVA = "0x1B219E0", Offset = "0x1B20BE0", Length = "0x124")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(VisualData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001D9C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B21B10", Offset = "0x1B20D10", Length = "0x19C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Background), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundPosition), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(BackgroundSize), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001D9D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B21CB0", Offset = "0x1B20EB0", Length = "0x1428")]
	[CalledBy(Type = typeof(VisualData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Background), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Background), typeof(Background)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundPosition), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition), typeof(BackgroundPosition)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundRepeat), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat), typeof(BackgroundRepeat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize), typeof(BackgroundSize)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D9A")]
	public static bool op_Equality(VisualData lhs, VisualData rhs) { }

}

