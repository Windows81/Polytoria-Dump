namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Property (128))]
[Token(Token = "0x200000E")]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000011")]
	private TargetType <TargetType>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x1700000C")]
	public TargetType TargetType
	{
		[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600001C")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001D")]
	public NativePropertyAttribute() { }

	[Address(RVA = "0x1A19830", Offset = "0x1A18A30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600001E")]
	public NativePropertyAttribute(string name) { }

	[Address(RVA = "0x1A19840", Offset = "0x1A18A40", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600001F")]
	public NativePropertyAttribute(string name, bool isFree, TargetType targetType) { }

	[Address(RVA = "0x331A20", Offset = "0x330C20", Length = "0x4")]
	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	public void set_TargetType(TargetType value) { }

}

