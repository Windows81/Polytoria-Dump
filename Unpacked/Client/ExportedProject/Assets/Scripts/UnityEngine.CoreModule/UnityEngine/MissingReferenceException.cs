namespace UnityEngine;

[Token(Token = "0x200015E")]
public class MissingReferenceException : Exception
{

	[Address(RVA = "0x1963D90", Offset = "0x1962F90", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009FB")]
	public MissingReferenceException() { }

	[Address(RVA = "0x1963D20", Offset = "0x1962F20", Length = "0x61")]
	[CalledBy(Type = typeof(MonoBehaviour), Member = "get_destroyCancellationToken", ReturnType = typeof(CancellationToken))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009FC")]
	public MissingReferenceException(string message) { }

	[Address(RVA = "0x1963CA0", Offset = "0x1962EA0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009FD")]
	protected MissingReferenceException(SerializationInfo info, StreamingContext context) { }

}

