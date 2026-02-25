namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x200047C")]
public class StateMachineAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001256")]
	private readonly Type <StateMachineType>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000400")]
	public Type StateMachineType
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600203C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600203B")]
	public StateMachineAttribute(Type stateMachineType) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600203C")]
	public Type get_StateMachineType() { }

}

