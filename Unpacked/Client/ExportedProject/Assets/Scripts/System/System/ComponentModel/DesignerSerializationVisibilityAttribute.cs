namespace System.ComponentModel;

[AttributeUsage(960)]
[Token(Token = "0x2000149")]
public sealed class DesignerSerializationVisibilityAttribute : Attribute
{
	[Token(Token = "0x40005DC")]
	public static readonly DesignerSerializationVisibilityAttribute Content; //Field offset: 0x0
	[Token(Token = "0x40005DD")]
	public static readonly DesignerSerializationVisibilityAttribute Hidden; //Field offset: 0x8
	[Token(Token = "0x40005DE")]
	public static readonly DesignerSerializationVisibilityAttribute Visible; //Field offset: 0x10
	[Token(Token = "0x40005DF")]
	public static readonly DesignerSerializationVisibilityAttribute Default; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005E0")]
	private readonly DesignerSerializationVisibility <Visibility>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700017D")]
	public DesignerSerializationVisibility Visibility
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000817")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x177F000", Offset = "0x177E200", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600081B")]
	private static DesignerSerializationVisibilityAttribute() { }

	[Address(RVA = "0x5E9C60", Offset = "0x5E8E60", Length = "0x24")]
	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000816")]
	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility) { }

	[Address(RVA = "0x177EED0", Offset = "0x177E0D0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000818")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000817")]
	public DesignerSerializationVisibility get_Visibility() { }

	[Address(RVA = "0x177CCF0", Offset = "0x177BEF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000819")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x177EF90", Offset = "0x177E190", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600081A")]
	public virtual bool IsDefaultAttribute() { }

}

