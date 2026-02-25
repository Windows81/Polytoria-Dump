namespace System.Collections.Generic;

[Token(Token = "0x2000601")]
internal class ObjectEqualityComparer : EqualityComparer<T>
{

	[Address(RVA = "0xE41660", Offset = "0xE40860", Length = "0x14")]
	[CalledBy(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C20")]
	public ObjectEqualityComparer`1() { }

	[Address(RVA = "0xE40AA0", Offset = "0xE3FCA0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySegment`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C1A")]
	public virtual bool Equals(T x, T y) { }

	[Address(RVA = "0xE40B40", Offset = "0xE3FD40", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C1E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xE40C50", Offset = "0xE3FE50", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySegment`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C1B")]
	public virtual int GetHashCode(T obj) { }

	[Address(RVA = "0xAE1270", Offset = "0xAE0470", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C1F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xE40CC0", Offset = "0xE3FEC0", Length = "0x106")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySegment`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C1C")]
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0xE412C0", Offset = "0xE404C0", Length = "0x106")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArraySegment`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C1D")]
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }

}

