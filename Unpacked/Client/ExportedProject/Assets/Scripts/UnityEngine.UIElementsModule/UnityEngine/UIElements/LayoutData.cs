namespace UnityEngine.UIElements;

[Token(Token = "0x20003E0")]
internal struct LayoutData : IStyleDataGroup<LayoutData>, IEquatable<LayoutData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CE4")]
	public Align alignContent; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CE5")]
	public Align alignItems; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CE6")]
	public Align alignSelf; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000CE7")]
	public float borderBottomWidth; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CE8")]
	public float borderLeftWidth; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CE9")]
	public float borderRightWidth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CEA")]
	public float borderTopWidth; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000CEB")]
	public Length bottom; //Field offset: 0x1C
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000CEC")]
	public DisplayStyle display; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CED")]
	public Length flexBasis; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CEE")]
	public FlexDirection flexDirection; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000CEF")]
	public float flexGrow; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CF0")]
	public float flexShrink; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000CF1")]
	public Wrap flexWrap; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000CF2")]
	public Length height; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CF3")]
	public Justify justifyContent; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000CF4")]
	public Length left; //Field offset: 0x4C
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000CF5")]
	public Length marginBottom; //Field offset: 0x54
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000CF6")]
	public Length marginLeft; //Field offset: 0x5C
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000CF7")]
	public Length marginRight; //Field offset: 0x64
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000CF8")]
	public Length marginTop; //Field offset: 0x6C
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000CF9")]
	public Length maxHeight; //Field offset: 0x74
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000CFA")]
	public Length maxWidth; //Field offset: 0x7C
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000CFB")]
	public Length minHeight; //Field offset: 0x84
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000CFC")]
	public Length minWidth; //Field offset: 0x8C
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000CFD")]
	public Length paddingBottom; //Field offset: 0x94
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000CFE")]
	public Length paddingLeft; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000CFF")]
	public Length paddingRight; //Field offset: 0xA4
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000D00")]
	public Length paddingTop; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000D01")]
	public Position position; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000D02")]
	public Length right; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000D03")]
	public Length top; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000D04")]
	public Length width; //Field offset: 0xC8

	[Address(RVA = "0x1B0D1C0", Offset = "0x1B0C3C0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D80")]
	public override LayoutData Copy() { }

	[Address(RVA = "0x1B0D0B0", Offset = "0x1B0C2B0", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D81")]
	public override void CopyFrom(ref LayoutData other) { }

	[Address(RVA = "0x1B0D370", Offset = "0x1B0C570", Length = "0x127")]
	[CalledBy(Type = typeof(LayoutData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutData), typeof(LayoutData)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001D83")]
	public override bool Equals(LayoutData other) { }

	[Address(RVA = "0x1B0D240", Offset = "0x1B0C440", Length = "0x124")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(LayoutData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001D84")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B0D4A0", Offset = "0x1B0C6A0", Length = "0x337")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001D85")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B0D7E0", Offset = "0x1B0C9E0", Length = "0x29E3")]
	[CalledBy(Type = typeof(LayoutData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D82")]
	public static bool op_Equality(LayoutData lhs, LayoutData rhs) { }

}

