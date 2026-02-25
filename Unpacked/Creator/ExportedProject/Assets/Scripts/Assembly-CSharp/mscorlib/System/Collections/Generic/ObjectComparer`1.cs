namespace System.Collections.Generic;

[Token(Token = "0x20005FD")]
internal class ObjectComparer : Comparer<T>
{

	[Address(RVA = "0x963BC0", Offset = "0x962DC0", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C02")]
	public ObjectComparer`1() { }

	[Address(RVA = "0xE3CEC0", Offset = "0xE3C0C0", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Comparer), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BFF")]
	public virtual int Compare(T x, T y) { }

	[Address(RVA = "0xE408D0", Offset = "0xE3FAD0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C00")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAE1270", Offset = "0xAE0470", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C01")]
	public virtual int GetHashCode() { }

}

