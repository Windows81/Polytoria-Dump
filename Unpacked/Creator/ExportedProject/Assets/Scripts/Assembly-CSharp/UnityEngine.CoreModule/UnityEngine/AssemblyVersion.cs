namespace UnityEngine;

[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200013A")]
internal struct AssemblyVersion
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000541")]
	public ushort major; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000542")]
	public ushort minor; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000543")]
	public ushort build; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000544")]
	public ushort revision; //Field offset: 0x6

	[Address(RVA = "0x195AD80", Offset = "0x1959F80", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000915")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x195AE30", Offset = "0x195A030", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort), typeof(ushort), typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort), typeof(ushort), typeof(ushort)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000916")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x195B0D0", Offset = "0x195A2D0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000913")]
	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	[Address(RVA = "0x195AED0", Offset = "0x195A0D0", Length = "0x1FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000914")]
	public virtual string ToString() { }

}

