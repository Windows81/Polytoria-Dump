namespace UnityEngine;

[NativeHeader("Runtime/Utilities/Hash128.h")]
[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[Token(Token = "0x20000EA")]
[UsedByNativeCode]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000321")]
	internal ulong u64_0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000322")]
	internal ulong u64_1; //Field offset: 0x8

	[Address(RVA = "0x880C70", Offset = "0x87FE70", Length = "0x8")]
	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A5")]
	public Hash128(ulong u64_0, ulong u64_1) { }

	[Address(RVA = "0x1945BD0", Offset = "0x1944DD0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006A6")]
	public override int CompareTo(Hash128 rhs) { }

	[Address(RVA = "0x1945AF0", Offset = "0x1944CF0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006AD")]
	public override int CompareTo(object obj) { }

	[Address(RVA = "0x1945C20", Offset = "0x1944E20", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006AA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1945CD0", Offset = "0x1944ED0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006AB")]
	public override bool Equals(Hash128 obj) { }

	[Address(RVA = "0x1945D00", Offset = "0x1944F00", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60006AC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1945D80", Offset = "0x1944F80", Length = "0xAC")]
	[CalledBy(Type = typeof(Hash128), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("Hash128ToString", IsThreadSafe = True)]
	[Token(Token = "0x60006A9")]
	private static string Hash128ToStringImpl(Hash128 hash) { }

	[Address(RVA = "0x1945D30", Offset = "0x1944F30", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B2")]
	private static void Hash128ToStringImpl_Injected(in Hash128 hash, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1946070", Offset = "0x1945270", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60006AE")]
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	[Address(RVA = "0x1946090", Offset = "0x1945290", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006B0")]
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	[Address(RVA = "0x19460C0", Offset = "0x19452C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006AF")]
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	[Address(RVA = "0x1945E80", Offset = "0x1945080", Length = "0x1C4")]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field+Hash128Input", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field+Hash128Input", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlHash128AttributeDescription+<>c", Member = "<GetValueFromBag>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Hash128)}, ReturnType = typeof(Hash128))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("StringToHash128", IsThreadSafe = True)]
	[Token(Token = "0x60006A8")]
	public static Hash128 Parse(string hashString) { }

	[Address(RVA = "0x1945E30", Offset = "0x1945030", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006B1")]
	private static void Parse_Injected(ref ManagedSpanWrapper hashString, out Hash128 ret) { }

	[Address(RVA = "0x1946050", Offset = "0x1945250", Length = "0x1D")]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field", Member = "set_value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field", Member = "SetValueWithoutNotify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Hash128Field", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hash128), Member = "Hash128ToStringImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, ReturnType = typeof(string))]
	[Token(Token = "0x60006A7")]
	public virtual string ToString() { }

}

