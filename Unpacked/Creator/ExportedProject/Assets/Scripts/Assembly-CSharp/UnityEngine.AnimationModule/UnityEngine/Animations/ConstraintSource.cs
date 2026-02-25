namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Constraints/Constraint.bindings.h")]
[NativeType(CodegenOptions = CodegenOptions::Custom (1), Header = "Modules/Animation/Constraints/ConstraintSource.h", IntermediateScriptingStructName = "MonoConstraintSource")]
[Token(Token = "0x200002A")]
[UsedByNativeCode]
public struct ConstraintSource
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("sourceTransform")]
	[Token(Token = "0x400006E")]
	private Transform m_SourceTransform; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("weight")]
	[Token(Token = "0x400006F")]
	private float m_Weight; //Field offset: 0x8

	[Token(Token = "0x17000016")]
	public Transform sourceTransform
	{
		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CB")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000017")]
	public float weight
	{
		[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CC")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CB")]
	public void set_sourceTransform(Transform value) { }

	[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CC")]
	public void set_weight(float value) { }

}

