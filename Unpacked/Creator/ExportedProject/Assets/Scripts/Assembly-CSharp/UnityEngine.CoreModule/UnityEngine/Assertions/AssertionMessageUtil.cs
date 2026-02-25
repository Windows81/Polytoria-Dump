namespace UnityEngine.Assertions;

[Token(Token = "0x20002A1")]
internal class AssertionMessageUtil
{

	[Address(RVA = "0x197A7E0", Offset = "0x19799E0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D69")]
	public static string BooleanFailureMessage(bool expected) { }

	[Address(RVA = "0x197A870", Offset = "0x1979A70", Length = "0xE2")]
	[CalledBy(Type = typeof(Assert), Member = "AreEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T", typeof(string), "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000D67")]
	public static string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	[Address(RVA = "0x197AB70", Offset = "0x1979D70", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000D65")]
	public static string GetMessage(string failureMessage) { }

	[Address(RVA = "0x197A960", Offset = "0x1979B60", Length = "0x20A")]
	[CalledBy(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsTrue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsFalse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "AreEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AssertionMessageUtil), Member = "NullFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssertionMessageUtil), Member = "BooleanFailureMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000D66")]
	public static string GetMessage(string failureMessage, string expected) { }

	[Address(RVA = "0x197ABC0", Offset = "0x1979DC0", Length = "0x98")]
	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Assert), Member = "IsNotNull", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AssertionMessageUtil), Member = "GetMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000D68")]
	public static string NullFailureMessage(object value, bool expectNull) { }

}

