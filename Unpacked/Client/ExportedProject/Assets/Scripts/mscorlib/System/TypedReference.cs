namespace System;

[CLSCompliant(False)]
[ComVisible(True)]
[IsByRefLike]
[NonVersionable]
[Token(Token = "0x2000195")]
public struct TypedReference
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000670")]
	private RuntimeTypeHandle type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000671")]
	private IntPtr Value; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000672")]
	private IntPtr Type; //Field offset: 0x10

	[Token(Token = "0x17000144")]
	internal bool IsNull
	{
		[Address(RVA = "0x1506610", Offset = "0x1505810", Length = "0x13")]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValueDirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypedReference), typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000E92")]
		internal get { } //Length: 19
	}

	[Address(RVA = "0x1505F20", Offset = "0x1505120", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E91")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1506610", Offset = "0x1505810", Length = "0x13")]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValueDirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypedReference), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E92")]
	internal bool get_IsNull() { }

	[Address(RVA = "0x1505F80", Offset = "0x1505180", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E90")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1505FF0", Offset = "0x15051F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B470")]
	[Token(Token = "0x6000E8F")]
	private static void InternalMakeTypedReference(Void* result, object target, IntPtr[] flds, RuntimeType lastFieldType) { }

	[Address(RVA = "0x1506000", Offset = "0x1505200", Length = "0x5B1")]
	[CalledBy(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(ObjectHolder), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MissingMemberException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020B470")]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeFieldInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214040")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[CLSCompliant(False)]
	[Token(Token = "0x6000E8E")]
	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	[Address(RVA = "0x15065C0", Offset = "0x15057C0", Length = "0x4E")]
	[CalledBy(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(ObjectHolder), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000E93")]
	public static void SetTypedReference(TypedReference target, object value) { }

}

