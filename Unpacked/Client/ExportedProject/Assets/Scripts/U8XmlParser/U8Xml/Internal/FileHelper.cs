namespace U8Xml.Internal;

[Token(Token = "0x2000030")]
internal static class FileHelper
{

	[Address(RVA = "0x1807880", Offset = "0x1806A80", Length = "0x105")]
	[CalledBy(Type = typeof(XmlParser), Member = "ParseFileCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(XmlObjectCore))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStream))]
	[Calls(Type = typeof(StreamExtension), Member = "ReadAllToUnmanaged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<U8Xml.Internal.UnmanagedBuffer, System.Int32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180739630")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E7")]
	public static ValueTuple<UnmanagedBuffer, Int32> ReadFileToUnmanaged(string filePath) { }

}

