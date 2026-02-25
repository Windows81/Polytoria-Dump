namespace UnityEngine.Bindings;

[AttributeUsage(192)]
[Token(Token = "0x200000C")]
[VisibleToOtherModules]
internal class NativeMethodAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000009")]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000A")]
	private bool <IsThreadSafe>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x400000B")]
	private bool <IsFreeFunction>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x400000C")]
	private bool <ThrowsException>k__BackingField; //Field offset: 0x1A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1B")]
	[Token(Token = "0x400000D")]
	private bool <HasExplicitThis>k__BackingField; //Field offset: 0x1B

	[Token(Token = "0x1700000B")]
	public override bool HasExplicitThis
	{
		[Address(RVA = "0x5611E0", Offset = "0x5603E0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000017")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public override bool IsFreeFunction
	{
		[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000015")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public override bool IsThreadSafe
	{
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000014")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000007")]
	public override string Name
	{
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000013")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000A")]
	public override bool ThrowsException
	{
		[Address(RVA = "0x5611C0", Offset = "0x5603C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000016")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000018")]
	public NativeMethodAttribute() { }

	[Address(RVA = "0x1A195E0", Offset = "0x1A187E0", Length = "0x10E")]
	[CalledBy(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePropertyAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NativePropertyAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(TargetType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FreeFunctionAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FreeFunctionAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000019")]
	public NativeMethodAttribute(string name) { }

	[Address(RVA = "0x1A196F0", Offset = "0x1A188F0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600001A")]
	public NativeMethodAttribute(string name, bool isFreeFunction) { }

	[Address(RVA = "0x1A195A0", Offset = "0x1A187A0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600001B")]
	public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe) { }

	[Address(RVA = "0x5611E0", Offset = "0x5603E0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000017")]
	public override void set_HasExplicitThis(bool value) { }

	[Address(RVA = "0x5611D0", Offset = "0x5603D0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000015")]
	public override void set_IsFreeFunction(bool value) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	public override void set_IsThreadSafe(bool value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public override void set_Name(string value) { }

	[Address(RVA = "0x5611C0", Offset = "0x5603C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000016")]
	public override void set_ThrowsException(bool value) { }

}

