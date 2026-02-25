namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = True)]
[Token(Token = "0x2000147")]
public sealed class DesignerCategoryAttribute : Attribute
{
	[Token(Token = "0x40005D3")]
	public static readonly DesignerCategoryAttribute Component; //Field offset: 0x0
	[Token(Token = "0x40005D4")]
	public static readonly DesignerCategoryAttribute Default; //Field offset: 0x8
	[Token(Token = "0x40005D5")]
	public static readonly DesignerCategoryAttribute Form; //Field offset: 0x10
	[Token(Token = "0x40005D6")]
	public static readonly DesignerCategoryAttribute Generic; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005D7")]
	private readonly string <Category>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700017B")]
	public string Category
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000810")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017C")]
	public virtual object TypeId
	{
		[Address(RVA = "0x177EE80", Offset = "0x177E080", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000814")]
		 get { } //Length: 69
	}

	[Address(RVA = "0x177EC70", Offset = "0x177DE70", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000815")]
	private static DesignerCategoryAttribute() { }

	[Address(RVA = "0x177EE40", Offset = "0x177E040", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080E")]
	public DesignerCategoryAttribute() { }

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600080F")]
	public DesignerCategoryAttribute(string category) { }

	[Address(RVA = "0x177EB70", Offset = "0x177DD70", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000811")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000810")]
	public string get_Category() { }

	[Address(RVA = "0x177EE80", Offset = "0x177E080", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000814")]
	public virtual object get_TypeId() { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000812")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x177EBF0", Offset = "0x177DDF0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000813")]
	public virtual bool IsDefaultAttribute() { }

}

