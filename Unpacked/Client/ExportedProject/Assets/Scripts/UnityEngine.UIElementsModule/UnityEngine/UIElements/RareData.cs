namespace UnityEngine.UIElements;

[Token(Token = "0x20003E1")]
internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D05")]
	public Cursor cursor; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D06")]
	public TextOverflow textOverflow; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000D07")]
	public Color unityBackgroundImageTintColor; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000D08")]
	public OverflowClipBox unityOverflowClipBox; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D09")]
	public int unitySliceBottom; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000D0A")]
	public int unitySliceLeft; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D0B")]
	public int unitySliceRight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D0C")]
	public float unitySliceScale; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D0D")]
	public int unitySliceTop; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000D0E")]
	public SliceType unitySliceType; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D0F")]
	public TextAutoSize unityTextAutoSize; //Field offset: 0x48
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000D10")]
	public TextOverflowPosition unityTextOverflowPosition; //Field offset: 0x5C

	[Address(RVA = "0x1B11E80", Offset = "0x1B11080", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D86")]
	public override RareData Copy() { }

	[Address(RVA = "0x1B11E40", Offset = "0x1B11040", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001D87")]
	public override void CopyFrom(ref RareData other) { }

	[Address(RVA = "0x1B11FA0", Offset = "0x1B111A0", Length = "0x2D0")]
	[CalledBy(Type = typeof(RareData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextAutoSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize), typeof(TextAutoSize)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D89")]
	public override bool Equals(RareData other) { }

	[Address(RVA = "0x1B11EC0", Offset = "0x1B110C0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(RareData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RareData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001D8A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B12270", Offset = "0x1B11470", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextAutoSize), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001D8B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B12310", Offset = "0x1B11510", Length = "0x32F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Cursor), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cursor), typeof(Cursor)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextAutoSize), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAutoSize), typeof(TextAutoSize)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D88")]
	public static bool op_Equality(RareData lhs, RareData rhs) { }

}

