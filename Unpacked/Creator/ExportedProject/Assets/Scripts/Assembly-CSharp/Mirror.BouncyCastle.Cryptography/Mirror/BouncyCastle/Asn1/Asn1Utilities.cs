namespace Mirror.BouncyCastle.Asn1;

[Token(Token = "0x20001B1")]
public abstract class Asn1Utilities
{

	[Address(RVA = "0x10ED930", Offset = "0x10ECB30", Length = "0xCA")]
	[CalledBy(Type = typeof(DerExternal), Member = "GetExternalContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Asn1Utilities), Member = "GetTagClassText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Asn1Utilities), Member = "GetTagClassText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000FF5")]
	internal static Asn1TaggedObject CheckContextTagClass(Asn1TaggedObject taggedObject) { }

	[Address(RVA = "0x10EDA00", Offset = "0x10ECC00", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Asn1Utilities), Member = "GetTagClassText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Asn1Utilities), Member = "GetTagClassText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000FF6")]
	internal static Asn1TaggedObject CheckTagClass(Asn1TaggedObject taggedObject, int tagClass) { }

	[Address(RVA = "0x10EDB60", Offset = "0x10ECD60", Length = "0x1C")]
	[CalledBy(Type = typeof(Asn1UniversalType), Member = "GetContextInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(bool)}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1Utilities), Member = "CheckContextTagClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(Asn1TaggedObject))]
	[CalledBy(Type = typeof(Asn1Utilities), Member = "CheckTagClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(int)}, ReturnType = typeof(Asn1TaggedObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Asn1Utilities), Member = "GetTagClassText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FF7")]
	public static string GetTagClassText(Asn1TaggedObject taggedObject) { }

	[Address(RVA = "0x10EDAD0", Offset = "0x10ECCD0", Length = "0x8A")]
	[CalledBy(Type = typeof(Asn1UniversalType), Member = "GetContextInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(bool)}, ReturnType = typeof(Asn1Object))]
	[CalledBy(Type = typeof(Asn1Utilities), Member = "CheckContextTagClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(Asn1TaggedObject))]
	[CalledBy(Type = typeof(Asn1Utilities), Member = "CheckTagClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject), typeof(int)}, ReturnType = typeof(Asn1TaggedObject))]
	[CalledBy(Type = typeof(Asn1Utilities), Member = "GetTagClassText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000FF8")]
	public static string GetTagClassText(int tagClass) { }

	[Address(RVA = "0x10EDB80", Offset = "0x10ECD80", Length = "0x20")]
	[CalledBy(Type = typeof(DerExternal), Member = "GetExternalContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1TaggedObject)}, ReturnType = typeof(Asn1Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000FF9")]
	public static string GetTagText(Asn1TaggedObject taggedObject) { }

	[Address(RVA = "0x10EDBB0", Offset = "0x10ECDB0", Length = "0xAE")]
	[CalledBy(Type = typeof(Asn1TaggedObject), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000FFA")]
	public static string GetTagText(int tagClass, int tagNo) { }

}

