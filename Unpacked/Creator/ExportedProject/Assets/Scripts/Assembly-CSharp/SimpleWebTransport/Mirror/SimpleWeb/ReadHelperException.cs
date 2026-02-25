namespace Mirror.SimpleWeb;

[Token(Token = "0x200001B")]
public class ReadHelperException : Exception
{

	[Address(RVA = "0x15578E0", Offset = "0x1556AE0", Length = "0x59")]
	[CalledBy(Type = typeof(ReadHelper), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600007C")]
	public ReadHelperException(string message) { }

	[Address(RVA = "0x1557940", Offset = "0x1556B40", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Token(Token = "0x600007D")]
	protected ReadHelperException(SerializationInfo info, StreamingContext context) { }

}

