namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Property (128))]
[Token(Token = "0x2000176")]
public sealed class SettingsBindableAttribute : Attribute
{
	[Token(Token = "0x400061B")]
	public static readonly SettingsBindableAttribute Yes; //Field offset: 0x0
	[Token(Token = "0x400061C")]
	public static readonly SettingsBindableAttribute No; //Field offset: 0x8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400061D")]
	private readonly bool <Bindable>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170001B5")]
	public bool Bindable
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000910")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17A9310", Offset = "0x17A8510", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000913")]
	private static SettingsBindableAttribute() { }

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600090F")]
	public SettingsBindableAttribute(bool bindable) { }

	[Address(RVA = "0x17A9270", Offset = "0x17A8470", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000911")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000910")]
	public bool get_Bindable() { }

	[Address(RVA = "0x11DDC40", Offset = "0x11DCE40", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000912")]
	public virtual int GetHashCode() { }

}

