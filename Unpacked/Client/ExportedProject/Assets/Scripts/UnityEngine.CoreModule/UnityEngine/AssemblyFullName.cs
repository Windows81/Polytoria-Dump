namespace UnityEngine;

[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200013B")]
internal struct AssemblyFullName
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("name")]
	[Token(Token = "0x4000545")]
	public string Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("version")]
	[Token(Token = "0x4000546")]
	public AssemblyVersion Version; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("publicKeyToken")]
	[Token(Token = "0x4000547")]
	public string PublicKeyToken; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("culture")]
	[Token(Token = "0x4000548")]
	public string Culture; //Field offset: 0x18

	[Address(RVA = "0x195A9A0", Offset = "0x1959BA0", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000917")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x195AAD0", Offset = "0x1959CD0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(AssemblyVersion), typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(AssemblyVersion), typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000918")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x195AB70", Offset = "0x1959D70", Length = "0x201")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000919")]
	public virtual string ToString() { }

}

