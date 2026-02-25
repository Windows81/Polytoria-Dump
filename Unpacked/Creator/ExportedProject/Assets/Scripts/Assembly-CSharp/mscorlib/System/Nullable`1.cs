namespace System;

[NonVersionable]
[Token(Token = "0x2000119")]
public struct Nullable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000438")]
	private readonly bool hasValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000439")]
	internal T value; //Field offset: 0x0

	[Token(Token = "0x17000093")]
	public bool HasValue
	{
		[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
		[CallerCount(Count = 29)]
		[DeduplicatedMethod]
		[NonVersionable]
		[Token(Token = "0x60008AB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000094")]
	public T Value
	{
		[Address(RVA = "0xE36DA0", Offset = "0xE35FA0", Length = "0x31")]
		[CallerCount(Count = 36)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_NoValue", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60008AC")]
		 get { } //Length: 49
	}

	[Address(RVA = "0xE36B00", Offset = "0xE35D00", Length = "0xB")]
	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x60008AA")]
	public Nullable`1(T value) { }

	[Address(RVA = "0xE2C5B0", Offset = "0xE2B7B0", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B1")]
	private static object Box(Nullable<T> o) { }

	[Address(RVA = "0xE2D5E0", Offset = "0xE2C7E0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = "Unity.Collections.NativeArray`1", Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AE")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x3B87B0", Offset = "0x3B79B0", Length = "0x4")]
	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x60008AB")]
	public bool get_HasValue() { }

	[Address(RVA = "0xE36DA0", Offset = "0xE35FA0", Length = "0x31")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_NoValue", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AC")]
	public T get_Value() { }

	[Address(RVA = "0xE2EE20", Offset = "0xE2E020", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = "Unity.Collections.NativeArray`1", Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xCE38B0", Offset = "0xCE2AB0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x60008AD")]
	public T GetValueOrDefault() { }

	[Address(RVA = "0xE31DE0", Offset = "0xE30FE0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ValueType), Member = "ToString", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B0")]
	public virtual string ToString() { }

	[Address(RVA = "0xE353E0", Offset = "0xE345E0", Length = "0xE1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B2")]
	private static Nullable<T> Unbox(object o) { }

	[Address(RVA = "0xE330A0", Offset = "0xE322A0", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B3")]
	private static Nullable<T> UnboxExact(object o) { }

}

