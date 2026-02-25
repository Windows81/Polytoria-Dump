namespace Unity.Burst;

[AttributeUsage(77)]
[Token(Token = "0x2000004")]
public class BurstCompileAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000B")]
	private FloatMode <FloatMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400000C")]
	private FloatPrecision <FloatPrecision>k__BackingField; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000D")]
	internal Nullable<Boolean> _compileSynchronously; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000E")]
	private String[] <Options>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000003")]
	public bool CompileSynchronously
	{
		[Address(RVA = "0x18188B0", Offset = "0x1817AB0", Length = "0x5B")]
		[CalledBy(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Token(Token = "0x6000003")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000001")]
	public FloatMode FloatMode
	{
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000001")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000002")]
	public FloatPrecision FloatPrecision
	{
		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000002")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000004")]
	internal String[] Options
	{
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000004")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public BurstCompileAttribute() { }

	[Address(RVA = "0x1818870", Offset = "0x1817A70", Length = "0x34")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode) { }

	[Address(RVA = "0x18188B0", Offset = "0x1817AB0", Length = "0x5B")]
	[CalledBy(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000003")]
	public void set_CompileSynchronously(bool value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000001")]
	public void set_FloatMode(FloatMode value) { }

	[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000002")]
	public void set_FloatPrecision(FloatPrecision value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	internal void set_Options(String[] value) { }

}

