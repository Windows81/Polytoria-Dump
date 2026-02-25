namespace UnityEngine.UIElements;

[Token(Token = "0x20003E2")]
internal struct TransformData : IStyleDataGroup<TransformData>, IEquatable<TransformData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D11")]
	public Rotate rotate; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D12")]
	public Scale scale; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D13")]
	public TransformOrigin transformOrigin; //Field offset: 0x28
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D14")]
	public Translate translate; //Field offset: 0x3C

	[Address(RVA = "0x1B1BC50", Offset = "0x1B1AE50", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D8C")]
	public override TransformData Copy() { }

	[Address(RVA = "0x1B1BC20", Offset = "0x1B1AE20", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001D8D")]
	public override void CopyFrom(ref TransformData other) { }

	[Address(RVA = "0x1B1BC80", Offset = "0x1B1AE80", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformData), typeof(TransformData)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001D8F")]
	public override bool Equals(TransformData other) { }

	[Address(RVA = "0x1B1BD10", Offset = "0x1B1AF10", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(TransformData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformData), typeof(TransformData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001D90")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B1BE40", Offset = "0x1B1B040", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Rotate), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x6001D91")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B1BF80", Offset = "0x1B1B180", Length = "0x31F")]
	[CalledBy(Type = typeof(TransformData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransformData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TransformData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D8E")]
	public static bool op_Equality(TransformData lhs, TransformData rhs) { }

}

