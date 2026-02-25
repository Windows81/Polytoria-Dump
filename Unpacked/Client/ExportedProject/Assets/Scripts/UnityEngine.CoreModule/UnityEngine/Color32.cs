namespace UnityEngine;

[DefaultMember("Item")]
[Token(Token = "0x20000F4")]
[UsedByNativeCode]
public struct Color32 : IEquatable<Color32>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Ignore(DoesNotContributeToSize = True)]
	[Token(Token = "0x4000485")]
	private int rgba; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000486")]
	public byte r; //Field offset: 0x0
	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000487")]
	public byte g; //Field offset: 0x1
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000488")]
	public byte b; //Field offset: 0x2
	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000489")]
	public byte a; //Field offset: 0x3

	[Address(RVA = "0x181ECB0", Offset = "0x181DEB0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006FD")]
	public Color32(byte r, byte g, byte b, byte a) { }

	[Address(RVA = "0x1942130", Offset = "0x1941330", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000701")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x192B3D0", Offset = "0x192A5D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000702")]
	public override bool Equals(Color32 other) { }

	[Address(RVA = "0x192B460", Offset = "0x192A660", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000700")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2D83F0", Offset = "0x2D75F0", Length = "0x3D7")]
	[CallerCount(Count = 110)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006FE")]
	public static Color32 op_Implicit(Color c) { }

	[Address(RVA = "0x1942420", Offset = "0x1941620", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006FF")]
	public static Color op_Implicit(Color32 c) { }

	[Address(RVA = "0x1942410", Offset = "0x1941610", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E29C90")]
	[Token(Token = "0x6000703")]
	public virtual string ToString() { }

	[Address(RVA = "0x19421B0", Offset = "0x19413B0", Length = "0x259")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000704")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

